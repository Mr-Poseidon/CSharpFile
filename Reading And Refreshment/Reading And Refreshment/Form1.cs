using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reading_And_Refreshment
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        int intQuantitySum = 0, intSaleCount = 0;
        decimal decPriceSum = 0, decDiscountPriceSum = 0;
        const decimal decDiscountRate = 0.15M;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int intQuantity=0;
            decimal decPrice=0;

            try
            {
                intQuantity = int.Parse(quantityTextBox.Text);
                decPrice = decimal.Parse(priceTextBox.Text);

                decimal decExtendedPrice = intQuantity * decPrice;

                extendedPriceLabel.Text = decExtendedPrice.ToString("C");
                discountLabel.Text = (decExtendedPrice * decDiscountRate).ToString("C");
                discountPriceLabel.Text = (decExtendedPrice * ((decimal)1.0 - decDiscountRate)).ToString("C");

                intSaleCount++;//销售次数+1
                intQuantitySum += intQuantity;//累加销售的书本数
                decDiscountPriceSum += decExtendedPrice * decDiscountRate;//累加折扣价
                decPriceSum += decExtendedPrice * ((decimal)1.0 - decDiscountRate);//累加销售金额

                quantitySumLabel.Text = intQuantitySum.ToString("C");//总销售数
                discountSumLabel.Text = decDiscountPriceSum.ToString("C");//总折扣金额
                PriceSumLabel.Text = decPriceSum.ToString("C");//总销售金额
                averageDiscountLabel.Text = (decDiscountPriceSum / intSaleCount).ToString("C");//平均折扣金额

            }
            catch(FormatException fe)
            {
                MessageBox.Show("价格或数量不能为空","温馨提示");
                return;
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            quantityTextBox.Clear();
            titleTextBox.Clear();
            priceTextBox.Clear();
            extendedPriceLabel.Text = string.Empty;
            discountLabel.Text = string.Empty;
            discountPriceLabel.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
