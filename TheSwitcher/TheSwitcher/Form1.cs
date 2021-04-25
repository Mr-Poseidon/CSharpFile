using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSwitcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipLabel.ForeColor = Color.Black;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void downPictureBox_Click(object sender, EventArgs e)
        {
            upPictureBox.Visible = downPictureBox.Visible;
            downPictureBox.Visible = !downPictureBox.Visible;
            tipLabel.Text = "Turn the light off," + nameTextBox.Text;

        }

        private void upPictureBox_Click(object sender, EventArgs e)
        {
            downPictureBox.Visible = upPictureBox.Visible;
            upPictureBox.Visible = !upPictureBox.Visible;
            tipLabel.Text = "Turn the light on," + nameTextBox.Text;
        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipLabel.ForeColor = Color.Blue;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipLabel.ForeColor = Color.Red;
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipLabel.ForeColor = Color.Green;
        }
    }
}
