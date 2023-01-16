namespace Snake
{
    partial class Settings
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
            this.AddObstacles = new System.Windows.Forms.CheckBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ChangeMapSizeSelect = new System.Windows.Forms.ComboBox();
            this.ChangeMapSizeText = new System.Windows.Forms.Label();
            this.ChangeVelText = new System.Windows.Forms.Label();
            this.ChangeVelSelect = new System.Windows.Forms.ComboBox();
            this.ChangeGameplayTypeText = new System.Windows.Forms.Label();
            this.ChangeStyleText = new System.Windows.Forms.Label();
            this.ChangeGameplayTypeSelect = new System.Windows.Forms.ComboBox();
            this.ChangeStyleSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddObstacles
            // 
            this.AddObstacles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddObstacles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddObstacles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddObstacles.Checked = true;
            this.AddObstacles.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.AddObstacles.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddObstacles.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AddObstacles.Location = new System.Drawing.Point(270, 555);
            this.AddObstacles.Name = "AddObstacles";
            this.AddObstacles.Size = new System.Drawing.Size(540, 70);
            this.AddObstacles.TabIndex = 4;
            this.AddObstacles.Text = "DODANIE PRZESZKÓD";
            this.AddObstacles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddObstacles.UseVisualStyleBackColor = false;
            this.AddObstacles.CheckedChanged += new System.EventHandler(this.AddObstacles_CheckedChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ExitButton.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ExitButton.Location = new System.Drawing.Point(270, 680);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(540, 70);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "WYJŚCIE";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChangeMapSizeSelect
            // 
            this.ChangeMapSizeSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeMapSizeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChangeMapSizeSelect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ChangeMapSizeSelect.FormattingEnabled = true;
            this.ChangeMapSizeSelect.Items.AddRange(new object[] {
            "5x5",
            "50x50",
            "100x100"});
            this.ChangeMapSizeSelect.Location = new System.Drawing.Point(270, 108);
            this.ChangeMapSizeSelect.Name = "ChangeMapSizeSelect";
            this.ChangeMapSizeSelect.Size = new System.Drawing.Size(540, 23);
            this.ChangeMapSizeSelect.TabIndex = 7;
            this.ChangeMapSizeSelect.SelectionChangeCommitted += new System.EventHandler(this.ChangeMapSizeSelect_SelectionChangeCommitted);
            // 
            // ChangeMapSizeText
            // 
            this.ChangeMapSizeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeMapSizeText.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeMapSizeText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ChangeMapSizeText.Location = new System.Drawing.Point(270, 58);
            this.ChangeMapSizeText.Name = "ChangeMapSizeText";
            this.ChangeMapSizeText.Size = new System.Drawing.Size(540, 47);
            this.ChangeMapSizeText.TabIndex = 8;
            this.ChangeMapSizeText.Text = "ZMIANA ROZMIARU PLANSZY";
            this.ChangeMapSizeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeVelText
            // 
            this.ChangeVelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeVelText.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeVelText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ChangeVelText.Location = new System.Drawing.Point(270, 180);
            this.ChangeVelText.Name = "ChangeVelText";
            this.ChangeVelText.Size = new System.Drawing.Size(540, 47);
            this.ChangeVelText.TabIndex = 9;
            this.ChangeVelText.Text = "ZMIANA PRĘDKOŚCI WĘŻA";
            this.ChangeVelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeVelSelect
            // 
            this.ChangeVelSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeVelSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChangeVelSelect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ChangeVelSelect.FormattingEnabled = true;
            this.ChangeVelSelect.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ChangeVelSelect.Location = new System.Drawing.Point(270, 230);
            this.ChangeVelSelect.Name = "ChangeVelSelect";
            this.ChangeVelSelect.Size = new System.Drawing.Size(540, 23);
            this.ChangeVelSelect.TabIndex = 10;
            this.ChangeVelSelect.SelectionChangeCommitted += new System.EventHandler(this.ChangeVelSelect_SelectionChangeCommitted);
            // 
            // ChangeGameplayTypeText
            // 
            this.ChangeGameplayTypeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeGameplayTypeText.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeGameplayTypeText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ChangeGameplayTypeText.Location = new System.Drawing.Point(270, 305);
            this.ChangeGameplayTypeText.Name = "ChangeGameplayTypeText";
            this.ChangeGameplayTypeText.Size = new System.Drawing.Size(540, 47);
            this.ChangeGameplayTypeText.TabIndex = 11;
            this.ChangeGameplayTypeText.Text = "ZMIANA TYPU GRY";
            this.ChangeGameplayTypeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeStyleText
            // 
            this.ChangeStyleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeStyleText.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeStyleText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ChangeStyleText.Location = new System.Drawing.Point(270, 430);
            this.ChangeStyleText.Name = "ChangeStyleText";
            this.ChangeStyleText.Size = new System.Drawing.Size(540, 47);
            this.ChangeStyleText.TabIndex = 12;
            this.ChangeStyleText.Text = "ZMIANA WYGLĄDU";
            this.ChangeStyleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeGameplayTypeSelect
            // 
            this.ChangeGameplayTypeSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeGameplayTypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChangeGameplayTypeSelect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ChangeGameplayTypeSelect.FormattingEnabled = true;
            this.ChangeGameplayTypeSelect.Items.AddRange(new object[] {
            "Glob",
            "Pokój"});
            this.ChangeGameplayTypeSelect.Location = new System.Drawing.Point(270, 355);
            this.ChangeGameplayTypeSelect.Name = "ChangeGameplayTypeSelect";
            this.ChangeGameplayTypeSelect.Size = new System.Drawing.Size(540, 23);
            this.ChangeGameplayTypeSelect.TabIndex = 13;
            this.ChangeGameplayTypeSelect.SelectionChangeCommitted += new System.EventHandler(this.ChangeGameplayTypeSelect_SelectionChangeCommitted);
            // 
            // ChangeStyleSelect
            // 
            this.ChangeStyleSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeStyleSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChangeStyleSelect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ChangeStyleSelect.FormattingEnabled = true;
            this.ChangeStyleSelect.Items.AddRange(new object[] {
            "Styl 1",
            "Styl 2"});
            this.ChangeStyleSelect.Location = new System.Drawing.Point(270, 480);
            this.ChangeStyleSelect.Name = "ChangeStyleSelect";
            this.ChangeStyleSelect.Size = new System.Drawing.Size(540, 23);
            this.ChangeStyleSelect.TabIndex = 14;
            this.ChangeStyleSelect.SelectionChangeCommitted += new System.EventHandler(this.ChangeStyleSelect_SelectionChangeCommitted);
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1064, 771);
            this.Controls.Add(this.ChangeStyleSelect);
            this.Controls.Add(this.ChangeGameplayTypeSelect);
            this.Controls.Add(this.ChangeStyleText);
            this.Controls.Add(this.ChangeGameplayTypeText);
            this.Controls.Add(this.ChangeVelSelect);
            this.Controls.Add(this.ChangeVelText);
            this.Controls.Add(this.ChangeMapSizeText);
            this.Controls.Add(this.ChangeMapSizeSelect);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddObstacles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opcje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private CheckBox AddObstacles;
        private Button ExitButton;
        private ComboBox ChangeMapSizeSelect;
        private Label ChangeMapSizeText;
        private Label ChangeVelText;
        private ComboBox ChangeVelSelect;
        private Label ChangeGameplayTypeText;
        private Label ChangeStyleText;
        private ComboBox ChangeGameplayTypeSelect;
        private ComboBox ChangeStyleSelect;
    }
}
