using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reading_and_Refreshment01
{
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }

        decimal decSubtotal = 0, decTotal = 0, decGrandTotal = 0;
        int intCustomerCount = 0;

        private void clearButton_Click(object sender, EventArgs e)
        {
            if(decSubtotal!=0)
            {
                cappuccinoRadioButton.Checked = true;
                itemAmountLabel.Text = "";
                taxCheckBox.Enabled = false;
                quantityTextBox.Text = "";
                quantityTextBox.Focus();
            }
            else
            {
                MessageBox.Show("No New Order to Clear", "Customer Order",
                    MessageBoxButtons.OK);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult reponseDialogResult;
            string strMessage;

            //询问是否确定创建新订单
            strMessage = "Clear the current order figures?";
            reponseDialogResult = MessageBox.Show(strMessage, "Clear Order",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            //确定创建新订单
            if(reponseDialogResult==DialogResult.Yes)
            {
                clearButton_Click(sender, e);
                subtotalLabel.Text = "";
                taxLabel.Text = "";
                totalDueLabel.Text = "";
                try
                {
                    if (decSubtotal != 0)
                    {
                        decGrandTotal += decTotal;
                        intCustomerCount++;
                        decSubtotal = 0M;
                        decTotal = 0M;
                    }
                }
                catch
                {
                    strMessage = "Error in Calculations.";
                    MessageBox.Show(strMessage, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                taxCheckBox.Enabled = true;
                taxCheckBox.Checked = false;
            }
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            decimal decAverage;
            string strMessage;

            if (decTotal != 0)
                newOrderButton_Click(sender, e);

            if(intCustomerCount>0)
            {
                try
                {
                    decAverage = decGrandTotal / intCustomerCount;

                    strMessage = "Number of Orders:"
                        + intCustomerCount.ToString()
                        + " \n\n Total Sales: " + decGrandTotal.ToString("C")
                        + " \n\n Average Sales: " + decAverage.ToString("C");

                    MessageBox.Show(strMessage, "Coffee Sales Summary",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    strMessage = "Error in Calculations.";
                    MessageBox.Show(strMessage, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                strMessage = "No sales data to summarize.";
                MessageBox.Show(strMessage, "Coffee Sales Summary",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //各个商品的常量值
        const decimal
            decTAX_RATE = 0.08M,
            decCAPPUCCINO_PRICE = 2.0M,
            decEXPRESSO_PRICE = 2.25M,
            decLATTE_PRICE = 1.75M,
            decICED_PRICE = 2.5M;


        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal decPrice = 0M, decTax, decItemAmount;
            int intQuantity;
            string strMessage;

            //查询选择的商品
            if (cappuccinoRadioButton.Checked)
                decPrice = decCAPPUCCINO_PRICE;
            else if (expressoRadioButton.Checked)
                decPrice = decEXPRESSO_PRICE;
            else if (latteRadioButton.Checked)
                decPrice = decLATTE_PRICE;
            else if (icedCappuccinoRadioButton.Checked || icedLatteRadioButton.Checked)
                decPrice = decICED_PRICE;
            else
            {
                //没有选择，弹出提示框
                MessageBox.Show("Please make a drink selection","Seletion Require",
                    MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            }

            //判断是否有填写商品数量
            if(quantityTextBox.Text != "")
            {
                try
                {
                    intQuantity = int.Parse(quantityTextBox.Text);
                    decItemAmount = decPrice * intQuantity;
                    decSubtotal += decItemAmount;
                    if (taxCheckBox.Checked)//判断是否收税
                        decTax = decSubtotal * decTAX_RATE;
                    else
                        decTax = 0M;
                    decTotal = decSubtotal + decTax;
                    itemAmountLabel.Text = decItemAmount.ToString("C");
                    subtotalLabel.Text = decSubtotal.ToString("N");
                    taxLabel.Text = decTax.ToString("N");
                    totalDueLabel.Text = decTotal.ToString("C");
                }
                catch(FormatException err)//格式异常
                {
                    strMessage = "Nonumeric data entered for quantity.";
                    MessageBox.Show(strMessage, "Data Entry Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    quantityTextBox.Focus();
                }
                catch//计算异常
                {
                    strMessage = "Calculate error";
                    MessageBox.Show(strMessage,"Error",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    quantityTextBox.Focus();
                }

            }
            else
            {
                strMessage = "Enter the quantity.";
                MessageBox.Show(strMessage,"Data entry error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                quantityTextBox.Focus();
            }
        }
    }
}
