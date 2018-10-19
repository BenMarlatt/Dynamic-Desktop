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
    public partial class FavoritesForm : Form
    {
        public FavoritesForm()
        {
            InitializeComponent();
        }

        private void FavoritesForm_ExitButton0_Click(object sender, EventArgs e)
        {
            int FavoritesSlot = 0;
            EditFavorites editFavorites = new EditFavorites(FavoritesSlot);
            editFavorites.Show();
            editFavorites.Activate();
        }

        private void FavoritesForm_ExitButton1_Click(object sender, EventArgs e)
        {
            int FavoritesSlot = 1;
            EditFavorites editFavorites = new EditFavorites(FavoritesSlot);
            editFavorites.Show();
            editFavorites.Activate();
        }
    }
}
