using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Scoreboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                Gameplay gameplayForm = new Gameplay();
                gameplayForm.Show();
            }
            else if (this.DialogResult == DialogResult.Cancel)
            {
                FormProvider.mainmenuForm.Show();
            }
            else
                Application.Exit();   
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {

        }
    }
}
