using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileStack
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        // List to hold file extensions
        List<string> documents = new List<string> { ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".pdf", ".txt", ".rtf", ".odt", ".ods", ".odp" };
        // Images list 
        List<string> Images = new List<string> { ".jpg", "jpeg", ".png", ".gif", ".bmp", ".tiff", ".tif", ".wepg", ".heic", "heif", ".ico" };
        // Audio List
        List<string> Audio = new List<string> { ".mp3", ".wav", ".aac", ".flac", ".ogg", ".m4a"};
        // Video List 
        List<string> Video = new List<string> { ".mp4", ".avi", ".mov", ".wmv", ".mkv", ".flv" };
        // Compressed files
        List<string> cFiles = new List<string> { ".zip", ".rar", ".7z", ".tar", ".gz", ".bz2" };
        // Coding files
        List<string> pFiles = new List<string> { ".cs", ".cpp", ".h", ".hpp", ".py", ".js", ".html", ".htm", ".css", ".java", ".php" };
        // Other files
        List<string> otherFiles = new List<string> { ".log", ".ini", ".json", ".xml", ".csv" };
        // string to hold selected path of folder
        string path;
        string[] files;
        private void folderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            browserDialog.ShowNewFolderButton = false;
            browserDialog.ShowDialog();
            path = browserDialog.SelectedPath;
            selectedPath.Text = path;
            // grab all files in the folder
            files = Directory.GetFiles(path);
            // get all and list files
            foreach (string file in files)
            {
                filesListBox.Items.Add(Path.GetFileName(file));
                
            }
        }

        private void sortFilesButton_Click(object sender, EventArgs e)
        {
            filesListBox.Items.Clear();
            try
            {
                foreach (string file in files)
                {
                    FileInfo fI = new FileInfo(file);
                    string ext = fI.Extension.ToString();
                    // If text files checked
                    if (txtFilesButton.Checked)
                    {
                        if (documents.Contains(ext))
                        {
                            filesListBox.Items.Add(Path.GetFileName(file));
                            // Create path for sorted files 
                            string dPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            string folderName = "Text Files - FileStack";
                            string combinedPath = Path.Combine(dPath, folderName);
                            string fileName = Path.GetFileName(file);
                            string newPath = Path.Combine(combinedPath, fileName);
                            // check if path exist
                            if (!Directory.Exists(combinedPath))
                            {
                                Directory.CreateDirectory(combinedPath);
                            }
                            else
                            {
                                File.Move(file, newPath);
                            }

                        }
                    }
                    // If image files checked
                    if (imageFiles.Checked)
                    {
                        if (Images.Contains(ext))
                        {
                            filesListBox.Items.Add(Path.GetFileName(file));
                            string imageFiles = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            string folderName = "Image Files - FileStack";
                            string combinedPath = Path.Combine(imageFiles, folderName);
                            string fileName = Path.GetFileName(file);
                            string newPath = Path.Combine( combinedPath, fileName);
                            // Check if path exist
                            if (!Directory.Exists(combinedPath))
                            {
                                Directory.CreateDirectory(combinedPath);
                            }
                            else
                            {
                                File.Move(file, newPath);
                            }
                        }
                    }
                    // audio files checked
                    if (audioFilesButton.Checked)
                    {
                        if (Audio.Contains(ext))
                        {
                            filesListBox.Items.Add(Path.GetFileName(file));
                            string audioFiles = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            string folderName = "Audio Files - FileStack";
                            string combinedPath = Path.Combine(audioFiles, folderName);
                            string fileName = Path.GetFileName(file);
                            string newPath = Path.Combine(combinedPath, fileName);
                            // Check if path exist 
                            if (!Directory.Exists(combinedPath))
                            {
                                Directory.CreateDirectory(combinedPath);
                            }
                            else
                            {
                                File.Move (file, newPath);
                            }
                        }
                    }
                    // Video files
                    if (videoFilesButton.Checked)
                    {
                        if (Video.Contains(ext))
                        {
                            filesListBox.Items.Add(Path.GetFileName(file));
                            string videoFiles = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            string folderName = "Video Files - FileStack";
                            string combinedPath = Path.Combine(videoFiles, folderName);
                            string fileName = Path.GetFileName(file);
                            string newPath = Path.Combine( combinedPath, fileName);
                            // check if path exist 
                            if(!Directory.Exists(combinedPath))
                            {
                                Directory.CreateDirectory(combinedPath);
                            }
                            else
                            {
                                File.Move(file, newPath);
                            }
                        }
                    }
                    // Compressed files
                    if (compressedFilesButton.Checked)
                    {
                        if (cFiles.Contains(ext))
                        {
                            filesListBox.Items.Add(Path.GetFileName(file));
                            string compressedFiles = Environment.GetFolderPath (Environment.SpecialFolder.Desktop);
                            string folderName = "Compressed Files - FileStack";
                            string combinedPath = Path.Combine(compressedFiles, folderName);
                            string fileName = Path.GetFileName(file);
                            string newPath = Path.Combine(combinedPath, fileName);
                            // Check if path exist
                            if(!Directory.Exists(combinedPath))
                            {
                                Directory.CreateDirectory(combinedPath);
                            }
                            else
                            {
                                File.Move (file, newPath);
                            }
                        }
                    }
                    // programming files
                    if (codingFilesButton.Checked)
                    {
                        if (pFiles.Contains(ext))
                        {
                            filesListBox.Items.Add(Path.GetFileName(file));
                            string codeFiles = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            string folderName = "Coding Files - FileStack";
                            string combinedPath = Path.Combine(codeFiles, folderName);
                            string fileName = Path.GetFileName(file);
                            string newPath = Path.Combine( combinedPath, fileName);
                            // check if path exist
                            if (Directory.Exists(combinedPath))
                            {
                                Directory.CreateDirectory(combinedPath);
                            }
                            else
                            {
                                File.Move(file, newPath);
                            }
                        }
                    }
                    // other files 
                    if (otherFilesButton.Checked)
                    {
                        if (otherFiles.Contains(ext))
                        {
                            filesListBox.Items.Add(Path.GetFileName(file));
                            string otherFiles = Environment.GetFolderPath (Environment.SpecialFolder.Desktop);
                            string folderName = "Other Files - FileStack";
                            string combinedPath = Path.Combine(otherFiles, folderName);
                            string fileName = Path.GetFileName(file);
                            string newPath = Path.Combine(combinedPath, fileName);
                            // Check if path exist
                            if (!Directory.Exists(combinedPath))
                            {
                                Directory.CreateDirectory(combinedPath);
                            }
                            else
                            {
                                File.Move (file, newPath);
                            }
                        }
                    }
                }
                MessageBox.Show("The files shown have been moved to a folder on your desktop", "Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
