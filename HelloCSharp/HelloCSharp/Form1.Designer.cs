namespace HelloCSharp
{
    partial class Form1
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
            this.massage_label = new System.Windows.Forms.Label();
            this.englishButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.spanishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // massage_label
            // 
            this.massage_label.Location = new System.Drawing.Point(304, 144);
            this.massage_label.Name = "massage_label";
            this.massage_label.Size = new System.Drawing.Size(136, 56);
            this.massage_label.TabIndex = 3;
            // 
            // englishButton
            // 
            this.englishButton.Location = new System.Drawing.Point(96, 264);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(200, 64);
            this.englishButton.TabIndex = 1;
            this.englishButton.Text = "push me(English)";
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // spanishButton
            // 
            this.spanishButton.Location = new System.Drawing.Point(472, 264);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(200, 64);
            this.spanishButton.TabIndex = 4;
            this.spanishButton.Text = "push me(Spanish)";
            this.spanishButton.UseVisualStyleBackColor = true;
            this.spanishButton.Click += new System.EventHandler(this.spanishButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 445);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.englishButton);
            this.Controls.Add(this.massage_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label massage_label;
        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button spanishButton;
    }
}

