using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using WMPLib;
using System.Collections.Generic;
using System.Security.Policy;
using System.Drawing;
using NAudio.Wave;
using System.Drawing.Drawing2D;
using Adio_player;

namespace OnlineSongImplement
{
    public partial class Form1 : Form
    {
        private string lastSelectedFolderPath;
        private const string LastFolderFile = "last_folder.txt"; // Store last folder path
        private string[] musicFiles;
        private int currentIndex = 0;
        private int playPuseCount = 1;
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private Timer trackTimer;
        private string[] filteredFiles;
        private List<ListViewItem> allOnlineSongs = new List<ListViewItem>();
        private bool isDragging = false;
        private double progressRatio = 0;
        private List<float> waveformSamples = new List<float>();
        //private Bitmap waveformImage;
        private Timer waveformTimer;
        int waveformOffset = 0;
        List<float> currentSamples = new List<float>();


        //For song bit
        string bitColor = "Orange";
        //for listViewSong font and back color
        string ListViewHeaderFontColor;
        string ListViewHeaderBackColor;

        public Form1()
        {
            InitializeComponent();
            trackTimer = new Timer { Interval = 1000 };
            trackTimer.Tick += TrackTimer_Tick;

            trackBarVolume.Minimum = 0;
            trackBarVolume.Maximum = 100;
            trackBarVolume.Value = 100;
            player.settings.volume = 100;
            SoundMeter.Text = "100";

            treeViewFolders.AfterSelect += treeViewFolders_AfterSelect;

            //listViewSongs column width
            SetupListView();
            ResizeListViewColumns();
            metroProgressBar1.Style = MetroFramework.MetroColorStyle.Orange;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeViewFolders.Nodes.Clear();

            // Load last selected folder if exists
            if (File.Exists(LastFolderFile))
            {
                lastSelectedFolderPath = File.ReadAllText(LastFolderFile);
                if (Directory.Exists(lastSelectedFolderPath))
                {
                    LoadDirectoryTree(lastSelectedFolderPath);
                    SelectLastFolder(treeViewFolders.Nodes[0]); // Start from root
                }
            }

            waveformTimer = new Timer();
            waveformTimer.Interval = 100; // Update every 100ms
            waveformTimer.Tick += (s, args) =>
            {
                waveformOffset += 1; // 👈 this moves it!
                wavePanel.Invalidate();
            };
            waveformTimer.Start();


            typeof(Panel).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
            null, wavePanel, new object[] { true });

            whiteToolStripMenuItem_Click(sender, e);

        }

        private void TrackTimer_Tick(object sender, EventArgs e)
        {
            if (player.currentMedia != null && player.currentMedia.duration > 0)
            {
                double currentTime = player.controls.currentPosition;
                double duration = player.currentMedia.duration;


                if (currentTime >= 0 && duration > 0)
                {
                    lblTimer.Text = $"{TimeSpan.FromSeconds(currentTime):mm\\:ss} / {TimeSpan.FromSeconds(duration):mm\\:ss}";

                    // Prevent sudden jumps in UI
                    if (metroProgressBar1.Value != (int)currentTime)
                    {
                        metroProgressBar1.Maximum = (int)duration;
                        metroProgressBar1.Value = (int)currentTime;
                    }

                }
                //else if(currentTime == duration)
                //{
                //    MessageBox.Show("sohel stop");
                //}                
            }

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    musicFiles = Directory.GetFiles(folderDialog.SelectedPath, "*.mp3");

                    if (musicFiles.Length == 0)
                    {
                        MessageBox.Show("No MP3 files found in the selected folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    listViewSongs.Items.Clear();
                    filteredFiles = musicFiles; // Reset filtered files when loading new songs

                    WindowsMediaPlayer tempPlayer = new WindowsMediaPlayer();

                    foreach (string file in musicFiles)
                    {
                        if (!File.Exists(file))
                        {
                            MessageBox.Show($"File not found: {file}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        try
                        {
                            IWMPMedia mediaInfo = tempPlayer.newMedia(file);
                            double durationInSeconds = mediaInfo.duration;
                            TimeSpan timeSpan = TimeSpan.FromSeconds(durationInSeconds);
                            string formattedDuration = $"{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";

                            FileInfo fileInfo = new FileInfo(file);
                            string fileSize = (fileInfo.Length / 1024.0).ToString("0.00") + " KB";

                            ListViewItem item = new ListViewItem(Path.GetFileName(file));
                            item.SubItems.Add(formattedDuration);
                            item.SubItems.Add(fileSize);

                            listViewSongs.Items.Add(item);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading file: {file}\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }



        private void PlaySong(string url)
        {

            SongName.Text = Path.GetFileName(url);
            try
            {
                player.URL = url;
                player.controls.play();
                trackTimer.Start();

                // Update currentIndex based on the song's position in the array
                if (musicFiles != null)
                {
                    int newIndex = Array.IndexOf(musicFiles, url);
                    if (newIndex >= 0)
                        currentIndex = newIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing song: " + ex.Message, "Playback Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (musicFiles != null && musicFiles.Length > 0)
            {
                currentIndex = (currentIndex - 1 + musicFiles.Length) % musicFiles.Length;
                PlaySong(musicFiles[currentIndex]);
                playPuseCount = 1;
                btnPlayPuse_Click(sender, e);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (musicFiles != null && musicFiles.Length > 0)
            {
                currentIndex = (currentIndex + 1) % musicFiles.Length;
                PlaySong(musicFiles[currentIndex]);
                playPuseCount = 1;
                btnPlayPuse_Click(sender, e);    
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBarVolume.Value;
            SoundMeter.Text = ""+player.settings.volume;
        }


        private void TypeSongName_TextChanged(object sender, EventArgs e)
        {
            if (musicFiles == null && listViewSongs.Items.Count == 0)
                return;

            string searchText = SearchSong.Text.ToLower();
            listViewSongs.Items.Clear(); // Clear the ListView before adding search results

            // Search through offline songs
            if (musicFiles != null)
            {
                foreach (string file in musicFiles)
                {
                    if (Path.GetFileName(file).ToLower().Contains(searchText))
                    {
                        AddSongToList(file);
                    }
                }
            }

            // Search through online songs (songs stored as URLs in listViewSongs)
            foreach (ListViewItem item in allOnlineSongs) // Store all online songs separately
            {
                if (item.Text.ToLower().Contains(searchText))
                {
                    listViewSongs.Items.Add((ListViewItem)item.Clone());
                }
            }

            // If search box is empty, reload all songs
            if (string.IsNullOrEmpty(searchText))
            {
                ReloadAllSongs();
            }
        }

        private void ReloadAllSongs()
        {
            listViewSongs.Items.Clear();

            // Re-add local songs
            if (musicFiles != null)
            {
                foreach (string file in musicFiles)
                {
                    AddSongToList(file);
                }
            }

            // Re-add online songs
            foreach (ListViewItem item in allOnlineSongs)
            {
                listViewSongs.Items.Add((ListViewItem)item.Clone());
            }
        }



      


        private void LoadFolders(string rootPath, TreeNode parentNode)
        {
            try
            {
                string[] directories = Directory.GetDirectories(rootPath);
                foreach (string dir in directories)
                {
                    TreeNode node = new TreeNode(Path.GetFileName(dir)) { Tag = dir };
                    parentNode.Nodes.Add(node);
                    LoadFolders(dir, node); // Recursive load subfolders
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Handle access restrictions
            }
        }

        

        private void SelectLastFolder(TreeNode node)
        {
            foreach (TreeNode childNode in node.Nodes)
            {
                if (childNode.Tag != null && childNode.Tag.ToString() == lastSelectedFolderPath)
                {
                    treeViewFolders.SelectedNode = childNode;
                    childNode.Expand();
                    return;
                }
                SelectLastFolder(childNode); // Recursive call for subfolders
            }
        }
        private void LoadDirectoryTree(string selectedPath)
        {
            treeViewFolders.Nodes.Clear();
            TreeNode rootNode = new TreeNode("Local Music");
            rootNode.Tag = selectedPath;
            treeViewFolders.Nodes.Add(rootNode);
            LoadFoldersAndFiles(selectedPath, rootNode);
            rootNode.Expand();
        }
        private void LoadFoldersAndFiles(string rootPath, TreeNode parentNode)
        {
            try
            {
                string[] directories = Directory.GetDirectories(rootPath);
                foreach (string dir in directories)
                {
                    TreeNode folderNode = new TreeNode(Path.GetFileName(dir)) { Tag = dir };
                    parentNode.Nodes.Add(folderNode);
                    LoadFoldersAndFiles(dir, folderNode);
                }

                string[] files = Directory.GetFiles(rootPath, "*.mp3");
                foreach (string file in files)
                {
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file)) { Tag = file };
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException) { }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    LoadDirectoryTree(selectedPath);
                    lastSelectedFolderPath = selectedPath;
                    File.WriteAllText(LastFolderFile, lastSelectedFolderPath);
                }
            }
        }


        private void treeViewFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            playPuseCount = 1;

            if (e.Node.Tag == null) 
                return;

            string selectedPath = e.Node.Tag.ToString();

            if (File.Exists(selectedPath)) // If a file is selected, play it
            {
                PlaySong(selectedPath);
                btnPlayPuse_Click(sender, e);
                LoadWaveformSamples(selectedPath);


            }
            else if (Directory.Exists(selectedPath)) // If a folder is selected, update last selected folder
            {
                lastSelectedFolderPath = selectedPath;
                File.WriteAllText(LastFolderFile, lastSelectedFolderPath); // Save last folder
            }
        }

        private void treeViewFolders_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode node = (TreeNode)e.Item;
            if (node.Tag != null)
            {
                string path = node.Tag.ToString();
                if (Directory.Exists(path) || (File.Exists(path) && path.ToLower().EndsWith(".mp3")))
                {
                    DoDragDrop(path, DragDropEffects.Copy);
                }
            }
        }

        private void listViewSongs_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string path = (string)e.Data.GetData(DataFormats.StringFormat);
                if (Directory.Exists(path) || path.ToLower().EndsWith(".mp3"))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }

        private void listViewSongs_DragDrop(object sender, DragEventArgs e)
        {
            List<string> newMusicFiles = new List<string>(); // Temp list to store updated songs

            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string path = (string)e.Data.GetData(DataFormats.StringFormat);

                if (File.Exists(path) && path.ToLower().EndsWith(".mp3"))
                {
                    AddSongToList(path);
                    newMusicFiles.Add(path); // Add single file
                }
                else if (Directory.Exists(path)) // If a folder is dragged
                {
                    string[] mp3Files = Directory.GetFiles(path, "*.mp3", SearchOption.AllDirectories);
                    foreach (string file in mp3Files)
                    {
                        AddSongToList(file);
                        newMusicFiles.Add(file);
                    }
                }
            }

            // Update the musicFiles array
            musicFiles = newMusicFiles.ToArray();
            currentIndex = 0; // Reset index to start with the first song
            TypeSongName_TextChanged(sender, e);

        }
        private void AddSongToList(string filePath)
        {
            // Prevent duplicate entries
            foreach (ListViewItem file in listViewSongs.Items)
            {
                if (file.Tag != null && file.Tag.ToString() == filePath)
                {
                    return; // Skip duplicate
                }
            }

            FileInfo fileInfo = new FileInfo(filePath);
            IWMPMedia mediaInfo = player.newMedia(filePath);
            TimeSpan duration = TimeSpan.FromSeconds(mediaInfo.duration);
            string formattedDuration = $"{duration.Minutes:D2}:{duration.Seconds:D2}";
            string fileSize = (fileInfo.Length / 1024.0).ToString("0.00") + " KB";

            ListViewItem item = new ListViewItem("🎵 " + Path.GetFileName(filePath));
            item.SubItems.Add(formattedDuration);
            item.SubItems.Add(fileSize);
            item.Tag = filePath;
            listViewSongs.Items.Add(item);
        }

        private string ShowInputDialog(string title, string prompt)
        {
            Form promptForm = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 10, Top = 10, Text = prompt, AutoSize = true };
            TextBox inputBox = new TextBox() { Left = 10, Top = 40, Width = 360 };
            Button okButton = new Button() { Text = "OK", Left = 280, Width = 90, Top = 70, DialogResult = DialogResult.OK };

            promptForm.Controls.Add(textLabel);
            promptForm.Controls.Add(inputBox);
            promptForm.Controls.Add(okButton);
            promptForm.AcceptButton = okButton;

            if (promptForm.ShowDialog() == DialogResult.OK)
            {
                return inputBox.Text;
            }
            return null;
        }

        private void addOnlineSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string onlineSongUrl = ShowInputDialog("Add Online Song", "Enter the online song URL:");
            if (!string.IsNullOrWhiteSpace(onlineSongUrl) && Uri.IsWellFormedUriString(onlineSongUrl, UriKind.Absolute))
            {


                // Create a new ListViewItem for the online song
                ListViewItem item = new ListViewItem("🎵 " + onlineSongUrl); // Display URL with a music note icon
                item.SubItems.Add("N/A"); // Show it's an online song
                item.SubItems.Add("Online"); // No file size for online songs
                item.Tag = onlineSongUrl; // Store URL as Tag for later use

                listViewSongs.Items.Add(item);
                allOnlineSongs.Add((ListViewItem)item.Clone()); // Store in the online song list
            }
            else
            {
                MessageBox.Show("Invalid URL! Please enter a valid online song link.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteOnlineSong_Click(object sender, EventArgs e)
        {
            //allOnlineSongs.Remove()
        }

        private void listViewSongs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                btnPlayPuse_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Left)
            {
                btnNext_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Right)
            {
                btnPrevious_Click(sender, e);
            }else if(e.KeyCode == Keys.Enter)
            {
                listViewSongs_DoubleClick(sender, e);
            }
        }

        private void listViewSongs_DoubleClick(object sender, EventArgs e)
        {
            playPuseCount = 1;

            if (listViewSongs.SelectedItems.Count == 0)
                return;

            // Get file path or URL from Tag
            string selectedFile = listViewSongs.SelectedItems[0].Tag?.ToString();

            if (!string.IsNullOrEmpty(selectedFile))
            {
                PlaySong(selectedFile);
                btnPlayPuse_Click(sender, e);
                LoadWaveformSamples(selectedFile); //Load once
                waveformTimer.Interval = 90; // ~33 FPS
                waveformTimer.Start(); // 🔥 Start the animation

            }
            else if (musicFiles != null && musicFiles.Length > 0)
            {
                currentIndex = (currentIndex + 1) % musicFiles.Length;
                PlaySong(musicFiles[listViewSongs.SelectedIndices[0]]);
                btnPlayPuse_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Invalid file path or URL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //wave front color.
        private void wavePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int midY = wavePanel.Height / 2;
            int width = wavePanel.Width;
            int height = wavePanel.Height;

            int step = Math.Max(1, currentSamples.Count / width);

            for (int x = 0; x < width - 1; x++)
            {
                int i = waveformOffset + x * step;
                if (i >= currentSamples.Count)
                    break;

                float sample = currentSamples[i];
                float y = sample * midY;

                // Alpha gradient color..
                int alpha = Math.Max(50, 255 - (int)((float)x / width));
                Color fadedColor = Color.FromArgb(alpha, Color.FromName(bitColor)); // corrected line
                using (Pen fadedPen = new Pen(fadedColor, 1.5f))
                {
                    g.DrawLine(fadedPen, x, midY - y, x, midY + y);
                }
            }
        }


        private void LoadWaveformSamples(string filePath)
        {
            currentSamples.Clear();

            using (var reader = new AudioFileReader(filePath))
            {
                float[] buffer = new float[reader.WaveFormat.SampleRate];
                int read;
                while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    currentSamples.AddRange(buffer.Take(read).Select(s => Math.Abs(s)));
                }
            }
        }

        private void SetupListView()
        {
            listViewSongs.View = View.Details;
            listViewSongs.FullRowSelect = true;
            listViewSongs.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            // Add columns first!
            listViewSongs.Columns.Add("Song Name");
            listViewSongs.Columns.Add("Duration");
            listViewSongs.Columns.Add("Size");

            // Resize columns
            ResizeListViewColumns();

        }

        // Method to resize columns dynamically
        private void ResizeListViewColumns()
        {
            if (listViewSongs.Columns.Count == 0) return; // Prevent errors

            int totalWidth = listViewSongs.ClientSize.Width;

            listViewSongs.Columns[0].Width = (int)(totalWidth * 0.50); // 50% of ListView width
            listViewSongs.Columns[1].Width = (int)(totalWidth * 0.25); // 25%
            listViewSongs.Columns[2].Width = (int)(totalWidth * 0.25); // 25%
        }

        string GlobalFont;
        private void FontChangeMethod(string fnt = "Segoe UI")
        {
            GlobalFont = fnt;
            this.treeViewFolders.Font = new System.Drawing.Font(GlobalFont, 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSongs.Font = new System.Drawing.Font(GlobalFont, 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SongName.Font = new Font(GlobalFont, 12, FontStyle.Regular);
            lblTimer.Font = new Font(GlobalFont, 12, FontStyle.Regular);
            SoundMeter.Font = new Font(GlobalFont, 12, FontStyle.Regular);
            SoundMeter.Font = new Font(GlobalFont, 12, FontStyle.Regular);
            informationLabel.Font = new Font(GlobalFont, 12, FontStyle.Regular);
            informationLabel2.Font = new Font(GlobalFont, 12, FontStyle.Regular);
            SearchSong.Font = new Font(GlobalFont, 12, FontStyle.Bold);
        }
        private void listViewSongs_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Fill the background of the header
            e.Graphics.FillRectangle(new SolidBrush(Color.FromName(ListViewHeaderBackColor)), e.Bounds);

            // Create a new Font object with the desired font family and size
            using (Font headerFont = new Font(GlobalFont, 14, FontStyle.Regular)) // Change "Arial" and size as needed
            {

                // Draw the text using the new font
                TextRenderer.DrawText(e.Graphics, e.Header.Text, headerFont, e.Bounds, Color.FromName(ListViewHeaderFontColor), TextFormatFlags.VerticalCenter);
            }
        }

        private void listViewSongs_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            string firtlineColor = "252, 228, 174";
            if (e.ItemIndex % 2 == 0)

                //first line
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(Convert.ToInt32(firtlineColor))), e.Bounds);
            else
                //list line
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(Convert.ToInt32(firtlineColor))), e.Bounds);

            e.DrawText();
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeListViewColumns();

        }

        private void metroProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            SetPlayerPositionFromMouse(e.X);
        }


        private void metroProgressBar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                SetPlayerPositionFromMouse(e.X);
            }
        }

        private void metroProgressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            SetPlayerPositionFromMouse(e.X);
        }

        private void SetPlayerPositionFromMouse(int mouseX)
        {
            if (player.currentMedia != null && player.currentMedia.duration > 0)
            {
                progressRatio = (double)mouseX / metroProgressBar1.Width;
                progressRatio = Math.Max(0, Math.Min(1, progressRatio)); // Clamp between 0 and 1
                int newTime = (int)(player.currentMedia.duration * progressRatio);
                player.controls.currentPosition = newTime;
                metroProgressBar1.Value = newTime;

            }
        }

        private void TrackTimer_Tick_1(object sender, EventArgs e)
        {
            waveformOffset += 2; // 🔁 Speed of scroll
            wavePanel.Invalidate();
        }

        private void btnPlayPuse_Click(object sender, EventArgs e)
        {
            if (playPuseCount == 1)
            {
                this.btnPlayPuse.IconChar = FontAwesome.Sharp.IconChar.Pause;
                btnPlayPuse.Text = "";
                if (!string.IsNullOrEmpty(player.URL))
                    player.controls.play();
                waveformTimer.Start();
                trackTimer.Start();
                playPuseCount = 0;
            }
            else if (playPuseCount == 0)
            {
                this.btnPlayPuse.IconChar = FontAwesome.Sharp.IconChar.Play;
                btnPlayPuse.Text = "";
                player.controls.pause();
                trackTimer.Stop();
                playPuseCount = 1;
                waveformTimer.Stop();

            }
        }

        //thame change...
        public void ChangeThame(string col = "white")
        {
            if (col == "white")
            {
                //back color
                BackPanel.BackColor = Color.FromName(col);
                lblTimer.BackColor = Color.FromName(col);
                lblTotalTime.BackColor = Color.FromName(col);
                trackBarVolume.BackColor = Color.FromName(col);
                SoundMeter.BackColor = Color.FromName(col);
                SongName.BackColor = Color.FromName(col);
                informationLabel.BackColor = Color.FromName(col);
                informationLabel2.BackColor = Color.FromName(col);
                treeViewFolders.BackColor = Color.FloralWhite;
                wavePanel.BackColor = Color.FromName(col);
                toolStrip1.BackColor = Color.FromName(col);
                

                //system different design : color orange
                metroProgressBar1.Style = MetroFramework.MetroColorStyle.Orange;
                btnPrevious.ForeColor = Color.Orange;
                btnPlayPuse.ForeColor = Color.Orange;
                btnNext.ForeColor = Color.Orange;

                //all component ForColor
                string AllComponentForColor = "black";
                lblTimer.ForeColor = Color.FromName(AllComponentForColor);
                SongName.ForeColor = Color.FromName(AllComponentForColor);
                treeViewFolders.ForeColor = Color.FromName(AllComponentForColor);

                //ListViewSong back and font color
                ListViewHeaderFontColor = "white";
                ListViewHeaderBackColor = "orange";
                listViewSongs.DrawColumnHeader += listViewSongs_DrawColumnHeader;
                listViewSongs.BackColor = Color.FloralWhite;
                listViewSongs.ForeColor = Color.Black;



            }
            else if (col == "orange")
            {
                //back color
                BackPanel.BackColor = Color.FromName(col);
                lblTimer.BackColor = Color.FromName(col);
                lblTotalTime.BackColor = Color.Red;
                trackBarVolume.BackColor = Color.FromName(col);
                SoundMeter.BackColor = Color.FromName(col);
                SongName.BackColor = Color.FromName(col);
                informationLabel.BackColor = Color.FromName(col);
                informationLabel2.BackColor = Color.FromName(col);
                wavePanel.BackColor = Color.FromName(col);

                treeViewFolders.BackColor = Color.Black;
                toolStrip1.BackColor = Color.Black;

                //system different design
                metroProgressBar1.Style = MetroFramework.MetroColorStyle.Black;

                //all component ForColor
                string AllComponentForColor = "White";
                lblTimer.ForeColor = Color.FromName(AllComponentForColor);
                SongName.ForeColor = Color.FromName(AllComponentForColor);
                treeViewFolders.ForeColor = Color.FromName(AllComponentForColor);

                //ListViewSong back and font color
                ListViewHeaderFontColor = "white";
                ListViewHeaderBackColor = "black";
                listViewSongs.DrawColumnHeader += listViewSongs_DrawColumnHeader;
                listViewSongs.BackColor = Color.FromArgb(252, 228, 174);
                listViewSongs.ForeColor = Color.Black;



            }
            else if (col == "red")
            {
                //back color
                BackPanel.BackColor = Color.FromName(col);
                lblTimer.BackColor = Color.FromName(col);
                lblTotalTime.BackColor = Color.FromName(col);
                trackBarVolume.BackColor = Color.FromName(col);
                SoundMeter.BackColor = Color.FromName(col);
                SongName.BackColor = Color.FromName(col);
                informationLabel.BackColor = Color.FromName(col);
                informationLabel2.BackColor = Color.FromName(col);
                wavePanel.BackColor = Color.FromName(col);
                treeViewFolders.BackColor = Color.Black;
                toolStrip1.BackColor = Color.FromName(col);

                //all component ForColor
                string AllComponentForColor = "White";
                lblTimer.ForeColor = Color.FromName(AllComponentForColor);
                SongName.ForeColor = Color.FromName(AllComponentForColor);
                treeViewFolders.ForeColor = Color.FromName(AllComponentForColor);

                //ListViewSong back and font color
                ListViewHeaderFontColor = "black";
                ListViewHeaderBackColor = "white";
                listViewSongs.DrawColumnHeader += listViewSongs_DrawColumnHeader;
                listViewSongs.BackColor = Color.Black;
                listViewSongs.ForeColor = Color.White;

            }else if(col == "blue")
            {
                //back color
                BackPanel.BackColor = Color.FromName(col);
                lblTimer.BackColor = Color.FromName(col);
                lblTotalTime.BackColor = Color.FromName(col);
                trackBarVolume.BackColor = Color.FromName(col);
                SoundMeter.BackColor = Color.FromName(col);
                SongName.BackColor = Color.FromName(col);
                informationLabel.BackColor = Color.FromName(col);
                informationLabel2.BackColor = Color.FromName(col);
                wavePanel.BackColor = Color.FromName(col);
                treeViewFolders.BackColor = Color.Black;
                toolStrip1.BackColor = Color.FromName(col);

                //all component ForColor
                string AllComponentForColor = "White";
                lblTimer.ForeColor = Color.FromName(AllComponentForColor);
                SongName.ForeColor = Color.FromName(AllComponentForColor);
                treeViewFolders.ForeColor = Color.FromName(AllComponentForColor);

                //ListViewSong back and font color
                ListViewHeaderFontColor = "black";
                ListViewHeaderBackColor = "white";
                listViewSongs.DrawColumnHeader += listViewSongs_DrawColumnHeader;
                listViewSongs.BackColor = Color.Black;
                listViewSongs.ForeColor = Color.White;
            }
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //for back color change...
            ChangeThame("white");

            //for song bit color change...
            bitColor = "orange";
            wavePanel.Paint += wavePanel_Paint;

             //refresh system...
            this.Refresh();
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //for back color change...
            ChangeThame("orange");

            //for song bit color change...
            bitColor = "black";
            wavePanel.Paint += wavePanel_Paint;

            //refresh system...
            this.Refresh();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeThame("red");
            bitColor = "white";

            //refresh system...
            this.Refresh();
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeThame("blue");
            bitColor = "white";

            //refresh system...
            this.Refresh();
        }

        // font customize...
        private void segoeUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("Segoe UI");

        }
        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("Arial");

        }

        private void arialBlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("aria Black");
        }

        private void calibriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("calibri");
        }

        private void comicSansMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("Comic Sans MS");
        }

        private void courierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("Courier New");

        }

        private void georgiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("Georgia");

        }

        private void impactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("Impact");

        }

        private void lucidaConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("lucida Console");

        }

        private void microsoftSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("Microsoft Sans Serif");

        }

        private void tahomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("tahoma");

        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("times New Roman");
        }

        private void trebuchetMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("trebuchet MS");

        }

        private void verdanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("verdana");

        }

        private void weddingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("weddings");

        }

        private void wingdingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChangeMethod("wingdings");

        }

        private void bachThameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // font style method end
    }

}
