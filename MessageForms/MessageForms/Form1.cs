using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            messageLabel.ForeColor = Color.Red;         
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //连接两个文本框中的文本、并输出在标签中
            messageLabel.Text = nameTextBox.Text + "," + messageTextBox.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();//清空姓名框
            messageTextBox.Clear();//清空消息框
            nameTextBox.Focus();//给姓名框设置焦点
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            messageLabel.ForeColor = Color.Green;
        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            messageLabel.ForeColor = Color.Blue;
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            messageLabel.ForeColor = Color.Black;
        }

        private void littlePictureBox_Click(object sender, EventArgs e)
        {
            bigPictureBox.Visible = littlePictureBox.Visible;//显示大图片
            littlePictureBox.Visible = !littlePictureBox.Visible;//隐藏小图片
        }

        private void bigPictureBox_Click(object sender, EventArgs e)
        {
            littlePictureBox.Visible = bigPictureBox.Visible;//显示小图片
            bigPictureBox.Visible = !bigPictureBox.Visible;//隐藏大图片
        }

        private void visibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            colorGroupBox.Visible = visibleCheckBox.Checked;//颜色标签的可见性与复选框相对应
        }
    }
}
