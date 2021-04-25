namespace Reading_and_Refreshment01
{
    partial class BillingForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemAmountLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.taxCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cappuccinoRadioButton = new System.Windows.Forms.RadioButton();
            this.expressoRadioButton = new System.Windows.Forms.RadioButton();
            this.latteRadioButton = new System.Windows.Forms.RadioButton();
            this.icedLatteRadioButton = new System.Windows.Forms.RadioButton();
            this.icedCappuccinoRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalDueLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.calculateButton);
            this.groupBox1.Controls.Add(this.taxCheckBox);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.itemAmountLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ItemAmount";
            // 
            // itemAmountLabel
            // 
            this.itemAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemAmountLabel.Location = new System.Drawing.Point(136, 200);
            this.itemAmountLabel.Name = "itemAmountLabel";
            this.itemAmountLabel.Size = new System.Drawing.Size(100, 23);
            this.itemAmountLabel.TabIndex = 2;
            this.itemAmountLabel.Text = "           ";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(112, 32);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(144, 25);
            this.quantityTextBox.TabIndex = 3;
            // 
            // taxCheckBox
            // 
            this.taxCheckBox.AutoSize = true;
            this.taxCheckBox.Location = new System.Drawing.Point(32, 80);
            this.taxCheckBox.Name = "taxCheckBox";
            this.taxCheckBox.Size = new System.Drawing.Size(93, 19);
            this.taxCheckBox.TabIndex = 4;
            this.taxCheckBox.Text = "Ta&keout?";
            this.taxCheckBox.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(32, 120);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(88, 56);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "&Calculate Selection";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(136, 120);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(88, 56);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C&lear for Next Item";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.icedCappuccinoRadioButton);
            this.groupBox2.Controls.Add(this.icedLatteRadioButton);
            this.groupBox2.Controls.Add(this.latteRadioButton);
            this.groupBox2.Controls.Add(this.expressoRadioButton);
            this.groupBox2.Controls.Add(this.cappuccinoRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(312, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 208);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coffee Selection";
            // 
            // cappuccinoRadioButton
            // 
            this.cappuccinoRadioButton.AutoSize = true;
            this.cappuccinoRadioButton.Location = new System.Drawing.Point(24, 32);
            this.cappuccinoRadioButton.Name = "cappuccinoRadioButton";
            this.cappuccinoRadioButton.Size = new System.Drawing.Size(108, 19);
            this.cappuccinoRadioButton.TabIndex = 0;
            this.cappuccinoRadioButton.TabStop = true;
            this.cappuccinoRadioButton.Text = "C&appuccino";
            this.cappuccinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // expressoRadioButton
            // 
            this.expressoRadioButton.AutoSize = true;
            this.expressoRadioButton.Location = new System.Drawing.Point(24, 66);
            this.expressoRadioButton.Name = "expressoRadioButton";
            this.expressoRadioButton.Size = new System.Drawing.Size(92, 19);
            this.expressoRadioButton.TabIndex = 1;
            this.expressoRadioButton.TabStop = true;
            this.expressoRadioButton.Text = "Express&o";
            this.expressoRadioButton.UseVisualStyleBackColor = true;
            // 
            // latteRadioButton
            // 
            this.latteRadioButton.AutoSize = true;
            this.latteRadioButton.Location = new System.Drawing.Point(24, 100);
            this.latteRadioButton.Name = "latteRadioButton";
            this.latteRadioButton.Size = new System.Drawing.Size(68, 19);
            this.latteRadioButton.TabIndex = 2;
            this.latteRadioButton.TabStop = true;
            this.latteRadioButton.Text = "La&tte";
            this.latteRadioButton.UseVisualStyleBackColor = true;
            // 
            // icedLatteRadioButton
            // 
            this.icedLatteRadioButton.AutoSize = true;
            this.icedLatteRadioButton.Location = new System.Drawing.Point(24, 134);
            this.icedLatteRadioButton.Name = "icedLatteRadioButton";
            this.icedLatteRadioButton.Size = new System.Drawing.Size(108, 19);
            this.icedLatteRadioButton.TabIndex = 3;
            this.icedLatteRadioButton.TabStop = true;
            this.icedLatteRadioButton.Text = "&Iced Latte";
            this.icedLatteRadioButton.UseVisualStyleBackColor = true;
            // 
            // icedCappuccinoRadioButton
            // 
            this.icedCappuccinoRadioButton.AutoSize = true;
            this.icedCappuccinoRadioButton.Location = new System.Drawing.Point(24, 168);
            this.icedCappuccinoRadioButton.Name = "icedCappuccinoRadioButton";
            this.icedCappuccinoRadioButton.Size = new System.Drawing.Size(148, 19);
            this.icedCappuccinoRadioButton.TabIndex = 4;
            this.icedCappuccinoRadioButton.TabStop = true;
            this.icedCappuccinoRadioButton.Text = "Iced Ca&ppuccino";
            this.icedCappuccinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalDueLabel);
            this.groupBox3.Controls.Add(this.taxLabel);
            this.groupBox3.Controls.Add(this.subtotalLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(40, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 136);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "SubTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tax ( if Takeout )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Due";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalLabel.Location = new System.Drawing.Point(208, 40);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(100, 23);
            this.subtotalLabel.TabIndex = 3;
            // 
            // taxLabel
            // 
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxLabel.Location = new System.Drawing.Point(208, 72);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(100, 23);
            this.taxLabel.TabIndex = 4;
            // 
            // totalDueLabel
            // 
            this.totalDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDueLabel.Location = new System.Drawing.Point(208, 104);
            this.totalDueLabel.Name = "totalDueLabel";
            this.totalDueLabel.Size = new System.Drawing.Size(100, 23);
            this.totalDueLabel.TabIndex = 5;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(48, 456);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(128, 40);
            this.newOrderButton.TabIndex = 2;
            this.newOrderButton.Text = "&New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(208, 456);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(128, 40);
            this.summaryButton.TabIndex = 3;
            this.summaryButton.Text = "&Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(376, 456);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 516);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "BillingForm";
            this.Text = "BillingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton icedCappuccinoRadioButton;
        private System.Windows.Forms.RadioButton icedLatteRadioButton;
        private System.Windows.Forms.RadioButton latteRadioButton;
        private System.Windows.Forms.RadioButton expressoRadioButton;
        private System.Windows.Forms.RadioButton cappuccinoRadioButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.CheckBox taxCheckBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label itemAmountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label totalDueLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button exitButton;
    }
}

