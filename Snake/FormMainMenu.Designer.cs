namespace Snake
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StartButton.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.StartButton.Location = new System.Drawing.Point(270, 83);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(540, 160);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SettingsButton.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SettingsButton.Location = new System.Drawing.Point(270, 326);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(540, 160);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "OPCJE";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Exit.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Exit.Location = new System.Drawing.Point(270, 569);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(540, 160);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "ZAMKNIĘCIE";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1064, 771);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu główne";
            this.ResumeLayout(false);

        }

        #endregion

        private Button StartButton;
        private Button SettingsButton;
        private Button Exit;
    }
}