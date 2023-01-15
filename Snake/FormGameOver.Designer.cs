namespace Snake
{
    partial class GameOver
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
            this.Okbutton = new System.Windows.Forms.Button();
            this.GameOverInput = new System.Windows.Forms.TextBox();
            this.GameOverext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Okbutton
            // 
            this.Okbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Okbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Okbutton.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Okbutton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Okbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Okbutton.Location = new System.Drawing.Point(47, 185);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(200, 45);
            this.Okbutton.TabIndex = 9;
            this.Okbutton.Text = "Dalej";
            this.Okbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Okbutton.UseVisualStyleBackColor = false;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // GameOverInput
            // 
            this.GameOverInput.Location = new System.Drawing.Point(47, 156);
            this.GameOverInput.Name = "GameOverInput";
            this.GameOverInput.Size = new System.Drawing.Size(200, 23);
            this.GameOverInput.TabIndex = 8;
            this.GameOverInput.TextChanged += new System.EventHandler(this.GameOverInput_TextChanged);
            // 
            // GameOverext
            // 
            this.GameOverext.AutoSize = true;
            this.GameOverext.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameOverext.ForeColor = System.Drawing.Color.RoyalBlue;
            this.GameOverext.Location = new System.Drawing.Point(12, 9);
            this.GameOverext.Name = "GameOverext";
            this.GameOverext.Size = new System.Drawing.Size(274, 68);
            this.GameOverext.TabIndex = 10;
            this.GameOverext.Text = "Wpisz swoją nazwę,\r\n aby zapisać swój wynik\r\n";
            this.GameOverext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(299, 264);
            this.Controls.Add(this.GameOverext);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.GameOverInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameOver_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Okbutton;
        private TextBox GameOverInput;
        private Label GameOverext;
    }
}