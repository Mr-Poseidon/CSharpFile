using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChooseColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color colorNew;//新选择的颜色

        //多个控件调用同一个事件
        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectRadioButton = (RadioButton)sender;

            if (selectRadioButton.Name == "blueRadioButton")
                colorNew = Color.Blue;
            else if(selectRadioButton.Name == "blackRadioButton")
                colorNew = Color.Black;
            else if (selectRadioButton.Name == "redRadioButton")
                colorNew = Color.Red;
            else if (selectRadioButton.Name == "whiteRadioButton")
                colorNew = Color.White;
            else if (selectRadioButton.Name == "yellowRadioButton")
                colorNew = Color.Yellow;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            OKButton.ForeColor = colorNew;
            exitButton.ForeColor = colorNew;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
