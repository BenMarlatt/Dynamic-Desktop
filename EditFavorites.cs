using System;
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
    public partial class EditFavorites : Form
    {
        Desktop_Manager desktop_Manager = new Desktop_Manager();
        public EditFavorites(Desktop _desktop)
        {
            desktop_Manager.selectedDesktop = _desktop.id;
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            desktop_Manager.name = nameTextBox.Text;
            desktop_Manager.location = locationTextBox.Text;
            desktop_Manager.Save_Desktops();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditFavorites_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = desktop_Manager.name;
            locationTextBox.Text = desktop_Manager.location;
        }
    }
}
