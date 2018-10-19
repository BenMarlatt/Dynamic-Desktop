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
        Desktop_Manager desktop_Manager = new Desktop_Manager();
        public FavoritesForm()
        {
            InitializeComponent();
        }

        private void openEditFavorites(int FavoritesSlot)
        {
            EditFavorites editFavorites = new EditFavorites(FavoritesSlot);
            editFavorites.Show();
            editFavorites.Activate();
        }

        private void selectEditFavorites(int FavoritesSlot)
        {
            desktop_Manager.selectedDesktop = FavoritesSlot;
        }

        private void refreshFavorites()
        {
            label1.Text = Desktop_Manager.Desktop_List[0].name;
            label2.Text = Desktop_Manager.Desktop_List[1].name;
            label3.Text = Desktop_Manager.Desktop_List[2].name;
            label4.Text = Desktop_Manager.Desktop_List[3].name;
            label5.Text = Desktop_Manager.Desktop_List[4].name;
            label6.Text = Desktop_Manager.Desktop_List[5].name;
        }

        public void FavoritesForm_Load(object sender, EventArgs e)
        {
            refreshFavorites();
        }

        private void FavoritesForm_Activated(object sender, EventArgs e)
        {
            refreshFavorites();
        }

        private void EditFavorites_ApplyButton_Click(object sender, EventArgs e)
        {
            Desktop_Manager.Save_Desktops();
        }

        private void EditFavorites_OKButton_Click(object sender, EventArgs e)
        {
            Desktop_Manager.Save_Desktops();
            this.Close();
        }

        private void EditFavorites_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FavoritesForm_ExitButton0_Click(object sender, EventArgs e)
        {
            openEditFavorites(0);
        }

        private void FavoritesForm_ExitButton1_Click(object sender, EventArgs e)
        {
            openEditFavorites(1);
        }

        private void FavoritesForm_ExitButton2_Click(object sender, EventArgs e)
        {
            openEditFavorites(2);
        }

        private void FavoritesForm_ExitButton3_Click(object sender, EventArgs e)
        {
            openEditFavorites(3);
        }

        private void FavoritesForm_ExitButton4_Click(object sender, EventArgs e)
        {
            openEditFavorites(4);
        }

        private void FavoritesForm_ExitButton5_Click(object sender, EventArgs e)
        {
            openEditFavorites(5);
        }

        private void FavoritesForm_SelectButton0_Click(object sender, EventArgs e)
        {
            selectEditFavorites(0);
            this.Close();
        }

        private void FavoritesForm_SelectButton1_Click(object sender, EventArgs e)
        {
            selectEditFavorites(1);
            this.Close();
        }

        private void FavoritesForm_SelectButton2_Click(object sender, EventArgs e)
        {
            selectEditFavorites(2);
            this.Close();
        }

        private void FavoritesForm_SelectButton3_Click(object sender, EventArgs e)
        {
            selectEditFavorites(3);
            this.Close();
        }

        private void FavoritesForm_SelectButton4_Click(object sender, EventArgs e)
        {
            selectEditFavorites(4);
            this.Close();
        }

        private void FavoritesForm_SelectButton5_Click(object sender, EventArgs e)
        {
            selectEditFavorites(5);
            this.Close();
        }
    }
}
