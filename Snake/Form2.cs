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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Settings2.LoadSettings2();
            ChangeMapSizeSelect.SelectedItem = Settings2.rozmiary;
            ChangeVelSelect.SelectedItem = Settings2.predkosc;
            ChangeGameplayTypeSelect.SelectedItem = Settings2.typ;
            ChangeStyleSelect.SelectedItem = Settings2.styl;
            AddObstacles.Checked = Settings2.Obstacles;
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                Settings2.SaveSettings();
                FormProvider.mainmenuForm.Show();
            }
            else
                Application.Exit();
        }



        private void AddObstacles_CheckedChanged(object sender, EventArgs e)
        {
            Settings2.Obstacles = AddObstacles.Checked;
        }

        private void ChangeMapSizeSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Settings2.rozmiary = ChangeMapSizeSelect.SelectedItem.ToString();
        }

        private void ChangeVelSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Settings2.predkosc = ChangeVelSelect.SelectedItem.ToString();
        }

        private void ChangeGameplayTypeSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Settings2.typ = ChangeGameplayTypeSelect.SelectedItem.ToString();
        }

        private void ChangeStyleSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Settings2.styl = ChangeStyleSelect.SelectedItem.ToString();
        }
    }
}
