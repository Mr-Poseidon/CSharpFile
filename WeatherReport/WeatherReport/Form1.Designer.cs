namespace WeatherReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.weatherGroupBox = new System.Windows.Forms.GroupBox();
            this.sunnyRadioButton = new System.Windows.Forms.RadioButton();
            this.snowyRadioButton = new System.Windows.Forms.RadioButton();
            this.rainyRadioButton = new System.Windows.Forms.RadioButton();
            this.cloudyRadioButton = new System.Windows.Forms.RadioButton();
            this.sunnyPictureBox = new System.Windows.Forms.PictureBox();
            this.snowyPictureBox = new System.Windows.Forms.PictureBox();
            this.RainyPictureBox = new System.Windows.Forms.PictureBox();
            this.cloudyPictureBox = new System.Windows.Forms.PictureBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.weatherGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sunnyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RainyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Enter you name here:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(288, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(376, 25);
            this.nameTextBox.TabIndex = 1;
            // 
            // weatherGroupBox
            // 
            this.weatherGroupBox.Controls.Add(this.cloudyRadioButton);
            this.weatherGroupBox.Controls.Add(this.rainyRadioButton);
            this.weatherGroupBox.Controls.Add(this.snowyRadioButton);
            this.weatherGroupBox.Controls.Add(this.sunnyRadioButton);
            this.weatherGroupBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.weatherGroupBox.Location = new System.Drawing.Point(56, 112);
            this.weatherGroupBox.Name = "weatherGroupBox";
            this.weatherGroupBox.Size = new System.Drawing.Size(160, 200);
            this.weatherGroupBox.TabIndex = 2;
            this.weatherGroupBox.TabStop = false;
            this.weatherGroupBox.Text = "Weather";
            // 
            // sunnyRadioButton
            // 
            this.sunnyRadioButton.AutoSize = true;
            this.sunnyRadioButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sunnyRadioButton.Location = new System.Drawing.Point(32, 40);
            this.sunnyRadioButton.Name = "sunnyRadioButton";
            this.sunnyRadioButton.Size = new System.Drawing.Size(68, 19);
            this.sunnyRadioButton.TabIndex = 0;
            this.sunnyRadioButton.TabStop = true;
            this.sunnyRadioButton.Text = "&Sunny";
            this.sunnyRadioButton.UseVisualStyleBackColor = true;
            this.sunnyRadioButton.CheckedChanged += new System.EventHandler(this.sunnyRadioButton_CheckedChanged);
            // 
            // snowyRadioButton
            // 
            this.snowyRadioButton.AutoSize = true;
            this.snowyRadioButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.snowyRadioButton.Location = new System.Drawing.Point(32, 82);
            this.snowyRadioButton.Name = "snowyRadioButton";
            this.snowyRadioButton.Size = new System.Drawing.Size(68, 19);
            this.snowyRadioButton.TabIndex = 1;
            this.snowyRadioButton.TabStop = true;
            this.snowyRadioButton.Text = "S&nowy";
            this.snowyRadioButton.UseVisualStyleBackColor = true;
            this.snowyRadioButton.CheckedChanged += new System.EventHandler(this.snowyRadioButton_CheckedChanged);
            // 
            // rainyRadioButton
            // 
            this.rainyRadioButton.AutoSize = true;
            this.rainyRadioButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rainyRadioButton.Location = new System.Drawing.Point(32, 124);
            this.rainyRadioButton.Name = "rainyRadioButton";
            this.rainyRadioButton.Size = new System.Drawing.Size(68, 19);
            this.rainyRadioButton.TabIndex = 2;
            this.rainyRadioButton.TabStop = true;
            this.rainyRadioButton.Text = "&Rainy";
            this.rainyRadioButton.UseVisualStyleBackColor = true;
            this.rainyRadioButton.CheckedChanged += new System.EventHandler(this.rainyRadioButton_CheckedChanged);
            // 
            // cloudyRadioButton
            // 
            this.cloudyRadioButton.AutoSize = true;
            this.cloudyRadioButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cloudyRadioButton.Location = new System.Drawing.Point(32, 166);
            this.cloudyRadioButton.Name = "cloudyRadioButton";
            this.cloudyRadioButton.Size = new System.Drawing.Size(76, 19);
            this.cloudyRadioButton.TabIndex = 3;
            this.cloudyRadioButton.TabStop = true;
            this.cloudyRadioButton.Text = "&Cloudy";
            this.cloudyRadioButton.UseVisualStyleBackColor = true;
            this.cloudyRadioButton.CheckedChanged += new System.EventHandler(this.cloudyRadioButton_CheckedChanged);
            // 
            // sunnyPictureBox
            // 
            this.sunnyPictureBox.Image = global::WeatherReport.Properties.Resources.qing;
            this.sunnyPictureBox.Location = new System.Drawing.Point(296, 120);
            this.sunnyPictureBox.Name = "sunnyPictureBox";
            this.sunnyPictureBox.Size = new System.Drawing.Size(176, 96);
            this.sunnyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunnyPictureBox.TabIndex = 3;
            this.sunnyPictureBox.TabStop = false;
            this.sunnyPictureBox.Click += new System.EventHandler(this.sunnyPictureBox_Click);
            // 
            // snowyPictureBox
            // 
            this.snowyPictureBox.Image = global::WeatherReport.Properties.Resources.xuehua;
            this.snowyPictureBox.Location = new System.Drawing.Point(472, 120);
            this.snowyPictureBox.Name = "snowyPictureBox";
            this.snowyPictureBox.Size = new System.Drawing.Size(176, 96);
            this.snowyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowyPictureBox.TabIndex = 4;
            this.snowyPictureBox.TabStop = false;
            this.snowyPictureBox.Click += new System.EventHandler(this.snowyPictureBox_Click);
            // 
            // RainyPictureBox
            // 
            this.RainyPictureBox.Image = global::WeatherReport.Properties.Resources.xiayu;
            this.RainyPictureBox.Location = new System.Drawing.Point(296, 216);
            this.RainyPictureBox.Name = "RainyPictureBox";
            this.RainyPictureBox.Size = new System.Drawing.Size(176, 96);
            this.RainyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RainyPictureBox.TabIndex = 5;
            this.RainyPictureBox.TabStop = false;
            this.RainyPictureBox.Click += new System.EventHandler(this.RainyPictureBox_Click);
            // 
            // cloudyPictureBox
            // 
            this.cloudyPictureBox.Image = global::WeatherReport.Properties.Resources.duoyun;
            this.cloudyPictureBox.Location = new System.Drawing.Point(472, 216);
            this.cloudyPictureBox.Name = "cloudyPictureBox";
            this.cloudyPictureBox.Size = new System.Drawing.Size(176, 96);
            this.cloudyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloudyPictureBox.TabIndex = 6;
            this.cloudyPictureBox.TabStop = false;
            this.cloudyPictureBox.Click += new System.EventHandler(this.cloudyPictureBox_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outputLabel.Location = new System.Drawing.Point(64, 352);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(504, 24);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(616, 344);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 32);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Programmed by: Jenkins Black";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.cloudyPictureBox);
            this.Controls.Add(this.RainyPictureBox);
            this.Controls.Add(this.snowyPictureBox);
            this.Controls.Add(this.sunnyPictureBox);
            this.Controls.Add(this.weatherGroupBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Weather Report";
            this.weatherGroupBox.ResumeLayout(false);
            this.weatherGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sunnyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RainyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox weatherGroupBox;
        private System.Windows.Forms.RadioButton cloudyRadioButton;
        private System.Windows.Forms.RadioButton rainyRadioButton;
        private System.Windows.Forms.RadioButton snowyRadioButton;
        private System.Windows.Forms.RadioButton sunnyRadioButton;
        private System.Windows.Forms.PictureBox sunnyPictureBox;
        private System.Windows.Forms.PictureBox snowyPictureBox;
        private System.Windows.Forms.PictureBox RainyPictureBox;
        private System.Windows.Forms.PictureBox cloudyPictureBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
    }
}

