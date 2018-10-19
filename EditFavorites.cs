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
        public EditFavorites(int FavoritesSlot)
        {
            desktop_Manager.selectedDesktop = FavoritesSlot;
            InitializeComponent();
        }

        private void SaveToDesktop()
        {
            
            desktop_Manager.name = EditFavorites_NameTextbox.Text;
            desktop_Manager.location = EditFavorites_LocationTextbox.Text;
        }

        private void EditFavorites_ApplyButton_Click(object sender, EventArgs e)
        {
            SaveToDesktop();
        }

        private void EditFavorites_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditFavorites_Load(object sender, EventArgs e)
        {

            this.EditFavorites_LocationTextbox.Text = desktop_Manager.location;
            this.EditFavorites_NameTextbox.Text = desktop_Manager.name;
        }
    }
}
