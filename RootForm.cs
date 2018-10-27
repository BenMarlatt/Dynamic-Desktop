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
        Desktop_Manager desktop_Manager = new Desktop_Manager();
        public RootForm()
        {
            InitializeComponent();
        }

        private void ExploreButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            DirectoryTextBox.Text = folderBrowser.SelectedPath;

        }

        public void SetDirectoryTextBox(string Directory)
        {
            DirectoryTextBox.Text = Directory;
        }

        private void ChangeDesktopButton_Click(object sender, EventArgs e)
        {
            ChangeDesktop.Change_Desktop(DirectoryTextBox.Text);
        }

        private void RootForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Directory.GetCurrentDirectory() + $"\\Desktop.xml");
            if (File.Exists(Directory.GetCurrentDirectory() + $"\\Desktops.xml"))
            {
                desktop_Manager.Load_Desktop();
            }
            else
            {
                Console.WriteLine("Loading from default");
                desktop_Manager.createDefaultDesktop_List();
                desktop_Manager.Save_Desktops();
            }

            DirectoryTextBox.Text = desktop_Manager.location;
            refreshFavorites();
        }

        private void refreshFavorites()
        {
            if (favoritesToolStripMenuItem.DropDownItems.Count != 0)
                for (int i = favoritesToolStripMenuItem.DropDownItems.Count; i >= 1; i--)
                {
                    favoritesToolStripMenuItem.DropDownItems.RemoveAt(i - 1);
                }

            if (editFavoritesToolStripMenuItem.DropDownItems.Count != 0)
                for (int i = editFavoritesToolStripMenuItem.DropDownItems.Count; i >= 1; i--)
                {
                    editFavoritesToolStripMenuItem.DropDownItems.RemoveAt(i - 1);
                }

            foreach (Desktop desktop in desktop_Manager.desktop_List)
            {
                ToolStripMenuItem favoritesItem = new ToolStripMenuItem(desktop.name, null, setDesktop );
                favoritesItem.Text = desktop.name;
                favoritesItem.Tag = desktop;

                ToolStripMenuItem editItem = new ToolStripMenuItem(desktop.name, null, editFavorites);
                editItem.Text = "Edit " + desktop.name;
                editItem.Tag = desktop;

                favoritesToolStripMenuItem.DropDownItems.Add(favoritesItem);
                editFavoritesToolStripMenuItem.DropDownItems.Add(editItem);
            }
        }

        private void setDesktop(object sender, EventArgs e)
        {
            Desktop desktop = (sender as ToolStripMenuItem).Tag as Desktop;
            DirectoryTextBox.Text = desktop.location;
            ChangeDesktop.Change_Desktop(desktop.location);
        }

        private void RootForm_Activated(object sender, EventArgs e)
        {
            refreshFavorites();
        }

        private void revertToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("" +
                "Are you sure you want to revert to defaults?\n" +
                "This will erase all your saved favorites", 
                "Caption", 
                MessageBoxButtons.YesNo);

            if (response.ToString() == "Yes")
            {
                desktop_Manager.createDefaultDesktop_List();
                desktop_Manager.Save_Desktops();
                refreshFavorites();
            }
        }

        private void editFavorites(object sender, EventArgs e)
        {
            Desktop desktop = (sender as ToolStripMenuItem).Tag as Desktop;
            EditFavorites editFavorites = new EditFavorites(desktop);
            editFavorites.Show();
            

        }

        private void changeDesktopButton_Click_1(object sender, EventArgs e)
        {
            ChangeDesktop.Change_Desktop(DirectoryTextBox.Text);
        }
    }
}
