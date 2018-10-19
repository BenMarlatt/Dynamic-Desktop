using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Desktop
{
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
        }

        private void ExploreButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            string folder = folderBrowser.SelectedPath;
            if (folder == "")
            {
                MessageBox.Show("User Canceled");
            }
            else
            {
                //previousFilesToolStripMenuItem.
                DirectoryTextBox.Text = folder;
            }
        }

        public void SetDirectoryTextBox(string Directory)
        {
            DirectoryTextBox.Text = Directory;
        }

        private void ChangeDesktopButton_Click(object sender, EventArgs e)
        {
            ChangeDesktop.Change_Desktop(DirectoryTextBox.Text);
        }

        private void DefaultDesktopButton_Click(object sender, EventArgs e)
        {
            ChangeDesktop.Change_Desktop(@"C:\Users\" + Environment.UserName + @"\Desktop\");
        }

        private void checkPublicDesktop()
        {
            string PublicDesktopDir = @"C:\Users\Public\Desktop";
            if (Directory.GetFiles(PublicDesktopDir).Length != 0)
            {
                DialogResult userAnswer = MessageBox.Show(
                    "The directory C:\\Users\\Public\\Desktop\\ contains files.\nWould you like to move them to your user's Desktop instead?\n" +
                    "It's recommended to move them or files in the Public Desktop will always show.", 
                    "Do you want to move files?", MessageBoxButtons.YesNo);

                if (userAnswer == DialogResult.Yes)
                {

                    string userDesktopDir = @"C:\Users\" + Environment.UserName + @"\Desktop\";
                    DirectoryInfo pubdir = new DirectoryInfo(PublicDesktopDir);
                    FileInfo[] files = pubdir.GetFiles();

                    foreach (FileInfo file in files)
                    {
                        if (file.Length > 0)
                        {
                            if (File.Exists(userDesktopDir + file.Name))
                            {
                                File.Delete(userDesktopDir + file.Name);
                            }
                            file.MoveTo(userDesktopDir + file.Name);
                        }
                    }
                }
            }
        }

        private void FavoritesButton_Click(object sender, EventArgs e)
        {
            FavoritesForm favoritesForm = new FavoritesForm();
            favoritesForm.ShowDialog();
            favoritesForm.Activate();
        }

        private void RootForm_Load(object sender, EventArgs e)
        {
            Desktop_Manager.Load_Desktop();
            DirectoryTextBox.Text = Desktop_Manager.Desktop_List[Desktop_Manager.selectedDesktop].location;
        }

        private void RootForm_Activated(object sender, EventArgs e)
        {
            DirectoryTextBox.Text = Desktop_Manager.Desktop_List[Desktop_Manager.selectedDesktop].location;
        }
    }
}
