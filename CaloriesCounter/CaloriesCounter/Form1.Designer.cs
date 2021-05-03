namespace CaloriesCounter
{
    partial class CaloriesCounterForm
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
            this.FatLabel = new System.Windows.Forms.Label();
            this.CarbohydrateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.carbohydrateTextBox = new System.Windows.Forms.TextBox();
            this.proteinTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FatLabel
            // 
            this.FatLabel.AutoSize = true;
            this.FatLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FatLabel.Location = new System.Drawing.Point(96, 48);
            this.FatLabel.Name = "FatLabel";
            this.FatLabel.Size = new System.Drawing.Size(49, 20);
            this.FatLabel.TabIndex = 0;
            this.FatLabel.Text = "Fat:";
            // 
            // CarbohydrateLabel
            // 
            this.CarbohydrateLabel.AutoSize = true;
            this.CarbohydrateLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CarbohydrateLabel.Location = new System.Drawing.Point(96, 96);
            this.CarbohydrateLabel.Name = "CarbohydrateLabel";
            this.CarbohydrateLabel.Size = new System.Drawing.Size(139, 20);
            this.CarbohydrateLabel.TabIndex = 1;
            this.CarbohydrateLabel.Text = "Carbohydrate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(96, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Protein:";
            // 
            // fatTextBox
            // 
            this.fatTextBox.Location = new System.Drawing.Point(240, 48);
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(100, 25);
            this.fatTextBox.TabIndex = 3;
            // 
            // carbohydrateTextBox
            // 
            this.carbohydrateTextBox.Location = new System.Drawing.Point(240, 96);
            this.carbohydrateTextBox.Name = "carbohydrateTextBox";
            this.carbohydrateTextBox.Size = new System.Drawing.Size(100, 25);
            this.carbohydrateTextBox.TabIndex = 4;
            // 
            // proteinTextBox
            // 
            this.proteinTextBox.Location = new System.Drawing.Point(240, 144);
            this.proteinTextBox.Name = "proteinTextBox";
            this.proteinTextBox.Size = new System.Drawing.Size(100, 25);
            this.proteinTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(56, 240);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(96, 32);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "&calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(176, 240);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(188, 32);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "c&lear the text box";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(384, 240);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(96, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "calories count:";
            // 
            // sumLabel
            // 
            this.sumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sumLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sumLabel.Location = new System.Drawing.Point(288, 192);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(120, 23);
            this.sumLabel.TabIndex = 10;
            // 
            // CaloriesCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.proteinTextBox);
            this.Controls.Add(this.carbohydrateTextBox);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarbohydrateLabel);
            this.Controls.Add(this.FatLabel);
            this.Name = "CaloriesCounterForm";
            this.Text = "Calories Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FatLabel;
        private System.Windows.Forms.Label CarbohydrateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.TextBox carbohydrateTextBox;
        private System.Windows.Forms.TextBox proteinTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sumLabel;
    }
}

