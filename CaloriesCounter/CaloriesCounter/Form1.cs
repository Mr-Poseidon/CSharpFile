using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriesCounter
{
    public partial class CaloriesCounterForm : Form
    {
        public CaloriesCounterForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const int conFatCaloriesPerG = 9, conCarboCaloriesPerG = 4, conProteinCaloriesPerG = 4;

            try
            {
                int intCaloriesCount = 0;
                intCaloriesCount += conFatCaloriesPerG * int.Parse(fatTextBox.Text);
                intCaloriesCount += conCarboCaloriesPerG * int.Parse(carbohydrateTextBox.Text);
                intCaloriesCount += conProteinCaloriesPerG * int.Parse(proteinTextBox.Text);

                sumLabel.Text = intCaloriesCount.ToString("N");
            }
            catch
            {
                MessageBox.Show("input error,please input again");
                return;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fatTextBox.Clear();
            carbohydrateTextBox.Clear();
            proteinTextBox.Clear();
            sumLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
