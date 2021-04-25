using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sunnyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sunnyPictureBox.BorderStyle = BorderStyle.Fixed3D;
            snowyPictureBox.BorderStyle = BorderStyle.None;
            RainyPictureBox.BorderStyle = BorderStyle.None;
            cloudyPictureBox.BorderStyle = BorderStyle.None;

            outputLabel.Text = "It looks like sunny weather today," + nameTextBox.Text;
        }

        private void snowyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sunnyPictureBox.BorderStyle = BorderStyle.None;
            snowyPictureBox.BorderStyle = BorderStyle.Fixed3D;
            RainyPictureBox.BorderStyle = BorderStyle.None;
            cloudyPictureBox.BorderStyle = BorderStyle.None;

            outputLabel.Text = "It looks like snowy weather today," + nameTextBox.Text;
        }

        private void rainyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sunnyPictureBox.BorderStyle = BorderStyle.None;
            snowyPictureBox.BorderStyle = BorderStyle.None;
            RainyPictureBox.BorderStyle = BorderStyle.Fixed3D;
            cloudyPictureBox.BorderStyle = BorderStyle.None;

            outputLabel.Text = "It looks like rainy weather today," + nameTextBox.Text;
        }

        private void cloudyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sunnyPictureBox.BorderStyle = BorderStyle.None;
            snowyPictureBox.BorderStyle = BorderStyle.None;
            RainyPictureBox.BorderStyle = BorderStyle.None;
            cloudyPictureBox.BorderStyle = BorderStyle.Fixed3D;

            outputLabel.Text = "It looks like cloudy weather today," + nameTextBox.Text;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sunnyPictureBox_Click(object sender, EventArgs e)
        {
            sunnyRadioButton.Checked = true;

            sunnyPictureBox.BorderStyle = BorderStyle.Fixed3D;
            snowyPictureBox.BorderStyle = BorderStyle.None;
            RainyPictureBox.BorderStyle = BorderStyle.None;
            cloudyPictureBox.BorderStyle = BorderStyle.None;

            outputLabel.Text = "It looks like sunny weather today," + nameTextBox.Text;
        }

        private void snowyPictureBox_Click(object sender, EventArgs e)
        {
            snowyRadioButton.Checked = true;

            sunnyPictureBox.BorderStyle = BorderStyle.None;
            snowyPictureBox.BorderStyle = BorderStyle.Fixed3D;
            RainyPictureBox.BorderStyle = BorderStyle.None;
            cloudyPictureBox.BorderStyle = BorderStyle.None;

            outputLabel.Text = "It looks like snowy weather today," + nameTextBox.Text;
        }

        private void RainyPictureBox_Click(object sender, EventArgs e)
        {
            rainyRadioButton.Checked = true;

            sunnyPictureBox.BorderStyle = BorderStyle.None;
            snowyPictureBox.BorderStyle = BorderStyle.None;
            RainyPictureBox.BorderStyle = BorderStyle.Fixed3D;
            cloudyPictureBox.BorderStyle = BorderStyle.None;

            outputLabel.Text = "It looks like rainy weather today," + nameTextBox.Text;
        }

        private void cloudyPictureBox_Click(object sender, EventArgs e)
        {
            cloudyRadioButton.Checked = true;

            sunnyPictureBox.BorderStyle = BorderStyle.None;
            snowyPictureBox.BorderStyle = BorderStyle.None;
            RainyPictureBox.BorderStyle = BorderStyle.None;
            cloudyPictureBox.BorderStyle = BorderStyle.Fixed3D;

            outputLabel.Text = "It looks like cloudy weather today," + nameTextBox.Text;
        }
    }
}
