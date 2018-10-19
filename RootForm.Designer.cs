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
            this.ChangeDesktopButton = new System.Windows.Forms.Button();
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.DefaultDesktopButton = new System.Windows.Forms.Button();
            this.FavoritesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExploreButton
            // 
            this.ExploreButton.Location = new System.Drawing.Point(12, 15);
            this.ExploreButton.Name = "ExploreButton";
            this.ExploreButton.Size = new System.Drawing.Size(75, 20);
            this.ExploreButton.TabIndex = 0;
            this.ExploreButton.Text = "Explore";
            this.ExploreButton.UseVisualStyleBackColor = true;
            this.ExploreButton.Click += new System.EventHandler(this.ExploreButton_Click);
            // 
            // ChangeDesktopButton
            // 
            this.ChangeDesktopButton.Location = new System.Drawing.Point(299, 15);
            this.ChangeDesktopButton.Name = "ChangeDesktopButton";
            this.ChangeDesktopButton.Size = new System.Drawing.Size(108, 20);
            this.ChangeDesktopButton.TabIndex = 1;
            this.ChangeDesktopButton.Text = "Change Desktop";
            this.ChangeDesktopButton.UseVisualStyleBackColor = true;
            this.ChangeDesktopButton.Click += new System.EventHandler(this.ChangeDesktopButton_Click);
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.Location = new System.Drawing.Point(93, 15);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.Size = new System.Drawing.Size(200, 20);
            this.DirectoryTextBox.TabIndex = 3;
            // 
            // DefaultDesktopButton
            // 
            this.DefaultDesktopButton.Location = new System.Drawing.Point(299, 41);
            this.DefaultDesktopButton.Name = "DefaultDesktopButton";
            this.DefaultDesktopButton.Size = new System.Drawing.Size(108, 20);
            this.DefaultDesktopButton.TabIndex = 4;
            this.DefaultDesktopButton.Text = "Default Desktop";
            this.DefaultDesktopButton.UseVisualStyleBackColor = true;
            this.DefaultDesktopButton.Click += new System.EventHandler(this.DefaultDesktopButton_Click);
            // 
            // FavoritesButton
            // 
            this.FavoritesButton.Location = new System.Drawing.Point(12, 41);
            this.FavoritesButton.Name = "FavoritesButton";
            this.FavoritesButton.Size = new System.Drawing.Size(75, 20);
            this.FavoritesButton.TabIndex = 5;
            this.FavoritesButton.Text = "Favorites";
            this.FavoritesButton.UseVisualStyleBackColor = true;
            this.FavoritesButton.Click += new System.EventHandler(this.FavoritesButton_Click);
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 70);
            this.Controls.Add(this.FavoritesButton);
            this.Controls.Add(this.DefaultDesktopButton);
            this.Controls.Add(this.DirectoryTextBox);
            this.Controls.Add(this.ChangeDesktopButton);
            this.Controls.Add(this.ExploreButton);
            this.Name = "RootForm";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.RootForm_Activated);
            this.Load += new System.EventHandler(this.RootForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExploreButton;
        private System.Windows.Forms.Button ChangeDesktopButton;
        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.Button DefaultDesktopButton;
        private System.Windows.Forms.Button FavoritesButton;
    }
}

