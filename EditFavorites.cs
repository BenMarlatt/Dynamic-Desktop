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
        int favoritesSlot;

        public EditFavorites(int FavoritesSlot)
        {
            favoritesSlot = FavoritesSlot;
            InitializeComponent();
        }

        private void SaveToDesktop()
        {
            Desktop desktop = Desktop_Manager.Desktop_List[favoritesSlot];
            desktop.name = EditFavorites_NameTextbox.Text;
            desktop.location = EditFavorites_LocationTextbox.Text;
        }

        private void EditFavorites_OKButton_Click(object sender, EventArgs e)
        {

        }

        private void EditFavorites_ApplyButton_Click(object sender, EventArgs e)
        {
            SaveToDesktop();
        }

        private void EditFavorites_CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
