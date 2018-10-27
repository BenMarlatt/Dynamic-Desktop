namespace Dynamic_Desktop
{
    partial class RootForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExploreButton = new System.Windows.Forms.Button();
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDesktopButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExploreButton
            // 
            this.ExploreButton.Location = new System.Drawing.Point(12, 27);
            this.ExploreButton.Name = "ExploreButton";
            this.ExploreButton.Size = new System.Drawing.Size(75, 23);
            this.ExploreButton.TabIndex = 0;
            this.ExploreButton.Text = "Explore";
            this.ExploreButton.UseVisualStyleBackColor = true;
            this.ExploreButton.Click += new System.EventHandler(this.ExploreButton_Click);
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.Location = new System.Drawing.Point(93, 29);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.Size = new System.Drawing.Size(267, 20);
            this.DirectoryTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.favoritesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editFavoritesToolStripMenuItem,
            this.revertToDefaultToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editFavoritesToolStripMenuItem
            // 
            this.editFavoritesToolStripMenuItem.Name = "editFavoritesToolStripMenuItem";
            this.editFavoritesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editFavoritesToolStripMenuItem.Text = "Edit Favorites";
            // 
            // revertToDefaultToolStripMenuItem
            // 
            this.revertToDefaultToolStripMenuItem.Name = "revertToDefaultToolStripMenuItem";
            this.revertToDefaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revertToDefaultToolStripMenuItem.Text = "Revert to default";
            this.revertToDefaultToolStripMenuItem.Click += new System.EventHandler(this.revertToDefaultToolStripMenuItem_Click);
            // 
            // favoritesToolStripMenuItem
            // 
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.favoritesToolStripMenuItem.Text = "Favorites";
            // 
            // changeDesktopButton
            // 
            this.changeDesktopButton.Location = new System.Drawing.Point(366, 27);
            this.changeDesktopButton.Name = "changeDesktopButton";
            this.changeDesktopButton.Size = new System.Drawing.Size(98, 23);
            this.changeDesktopButton.TabIndex = 8;
            this.changeDesktopButton.Text = "Change Desktop";
            this.changeDesktopButton.UseVisualStyleBackColor = true;
            this.changeDesktopButton.Click += new System.EventHandler(this.changeDesktopButton_Click_1);
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 57);
            this.Controls.Add(this.changeDesktopButton);
            this.Controls.Add(this.DirectoryTextBox);
            this.Controls.Add(this.ExploreButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RootForm";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.RootForm_Activated);
            this.Load += new System.EventHandler(this.RootForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExploreButton;
        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertToDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.Button changeDesktopButton;
    }
}

