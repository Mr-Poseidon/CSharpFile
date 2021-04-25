using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flag_Viewer_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            title.Visible = titleCheckBox.Checked;
        }

        private void countryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            countryGroupBox.Visible = countryCheckBox.Checked;
        }

        private void programerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            programmerLabel.Visible = programerCheckBox.Checked;
        }

        private void ChinaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            flagPictureBox.Image = ChinaFlag.Image;
            flagNameLabel.Text = "China";
        }

        private void AmericaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            flagPictureBox.Image = AmericaFlag.Image;
            flagNameLabel.Text = "America";
        }

        private void EnglandRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            flagPictureBox.Image = EnglandFlag.Image;
            flagNameLabel.Text = "England";
        }

        private void GermanyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            flagPictureBox.Image = GermanyFlag.Image;
            flagNameLabel.Text = "Germany";
        }

        private void JapanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            flagPictureBox.Image = JapanFlag.Image;
            flagNameLabel.Text = "Japan";
        }

        private void IndiaRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            flagPictureBox.Image = IndiaFlag.Image;
            flagNameLabel.Text = "India";
        }
    }
}
