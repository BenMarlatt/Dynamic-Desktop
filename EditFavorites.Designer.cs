namespace Dynamic_Desktop
{
    partial class EditFavorites
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
            this.EditFavorites_NameLabel = new System.Windows.Forms.Label();
            this.EditFavorites_NameTextbox = new System.Windows.Forms.TextBox();
            this.EditFavorites_LocationTextbox = new System.Windows.Forms.TextBox();
            this.EditFavorites_LocationLabel = new System.Windows.Forms.Label();
            this.EditFavorites_CancelButton = new System.Windows.Forms.Button();
            this.EditFavorites_ApplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditFavorites_NameLabel
            // 
            this.EditFavorites_NameLabel.AutoSize = true;
            this.EditFavorites_NameLabel.Location = new System.Drawing.Point(12, 15);
            this.EditFavorites_NameLabel.Name = "EditFavorites_NameLabel";
            this.EditFavorites_NameLabel.Size = new System.Drawing.Size(35, 13);
            this.EditFavorites_NameLabel.TabIndex = 0;
            this.EditFavorites_NameLabel.Text = "Name";
            // 
            // EditFavorites_NameTextbox
            // 
            this.EditFavorites_NameTextbox.Location = new System.Drawing.Point(89, 12);
            this.EditFavorites_NameTextbox.Name = "EditFavorites_NameTextbox";
            this.EditFavorites_NameTextbox.Size = new System.Drawing.Size(158, 20);
            this.EditFavorites_NameTextbox.TabIndex = 2;
            // 
            // EditFavorites_LocationTextbox
            // 
            this.EditFavorites_LocationTextbox.Location = new System.Drawing.Point(89, 38);
            this.EditFavorites_LocationTextbox.Name = "EditFavorites_LocationTextbox";
            this.EditFavorites_LocationTextbox.Size = new System.Drawing.Size(158, 20);
            this.EditFavorites_LocationTextbox.TabIndex = 4;
            // 
            // EditFavorites_LocationLabel
            // 
            this.EditFavorites_LocationLabel.AutoSize = true;
            this.EditFavorites_LocationLabel.Location = new System.Drawing.Point(12, 41);
            this.EditFavorites_LocationLabel.Name = "EditFavorites_LocationLabel";
            this.EditFavorites_LocationLabel.Size = new System.Drawing.Size(48, 13);
            this.EditFavorites_LocationLabel.TabIndex = 3;
            this.EditFavorites_LocationLabel.Text = "Location";
            // 
            // EditFavorites_CancelButton
            // 
            this.EditFavorites_CancelButton.Location = new System.Drawing.Point(172, 73);
            this.EditFavorites_CancelButton.Name = "EditFavorites_CancelButton";
            this.EditFavorites_CancelButton.Size = new System.Drawing.Size(75, 23);
            this.EditFavorites_CancelButton.TabIndex = 5;
            this.EditFavorites_CancelButton.Text = "Cancel";
            this.EditFavorites_CancelButton.UseVisualStyleBackColor = true;
            this.EditFavorites_CancelButton.Click += new System.EventHandler(this.EditFavorites_CancelButton_Click);
            // 
            // EditFavorites_ApplyButton
            // 
            this.EditFavorites_ApplyButton.Location = new System.Drawing.Point(89, 73);
            this.EditFavorites_ApplyButton.Name = "EditFavorites_ApplyButton";
            this.EditFavorites_ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.EditFavorites_ApplyButton.TabIndex = 6;
            this.EditFavorites_ApplyButton.Text = "Apply";
            this.EditFavorites_ApplyButton.UseVisualStyleBackColor = true;
            this.EditFavorites_ApplyButton.Click += new System.EventHandler(this.EditFavorites_ApplyButton_Click);
            // 
            // EditFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 108);
            this.Controls.Add(this.EditFavorites_ApplyButton);
            this.Controls.Add(this.EditFavorites_CancelButton);
            this.Controls.Add(this.EditFavorites_LocationTextbox);
            this.Controls.Add(this.EditFavorites_LocationLabel);
            this.Controls.Add(this.EditFavorites_NameTextbox);
            this.Controls.Add(this.EditFavorites_NameLabel);
            this.Name = "EditFavorites";
            this.Text = "EditFavorites";
            this.Load += new System.EventHandler(this.EditFavorites_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditFavorites_NameLabel;
        private System.Windows.Forms.TextBox EditFavorites_NameTextbox;
        private System.Windows.Forms.TextBox EditFavorites_LocationTextbox;
        private System.Windows.Forms.Label EditFavorites_LocationLabel;
        private System.Windows.Forms.Button EditFavorites_CancelButton;
        private System.Windows.Forms.Button EditFavorites_ApplyButton;
    }
}