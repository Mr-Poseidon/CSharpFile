namespace Flag_Viewer_Application
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
            this.countryGroupBox = new System.Windows.Forms.GroupBox();
            this.ChinaRadioButton = new System.Windows.Forms.RadioButton();
            this.AmericaRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglandRadioButton3 = new System.Windows.Forms.RadioButton();
            this.GermanyRadioButton = new System.Windows.Forms.RadioButton();
            this.JapanRadioButton = new System.Windows.Forms.RadioButton();
            this.IndiaRadioButton6 = new System.Windows.Forms.RadioButton();
            this.title = new System.Windows.Forms.Label();
            this.flagPictureBox = new System.Windows.Forms.PictureBox();
            this.ChinaFlag = new System.Windows.Forms.PictureBox();
            this.AmericaFlag = new System.Windows.Forms.PictureBox();
            this.EnglandFlag = new System.Windows.Forms.PictureBox();
            this.GermanyFlag = new System.Windows.Forms.PictureBox();
            this.JapanFlag = new System.Windows.Forms.PictureBox();
            this.IndiaFlag = new System.Windows.Forms.PictureBox();
            this.displayGroupBox = new System.Windows.Forms.GroupBox();
            this.titleCheckBox = new System.Windows.Forms.CheckBox();
            this.countryCheckBox = new System.Windows.Forms.CheckBox();
            this.programerCheckBox = new System.Windows.Forms.CheckBox();
            this.programmerLabel = new System.Windows.Forms.Label();
            this.flagNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.countryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChinaFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmericaFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnglandFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GermanyFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JapanFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndiaFlag)).BeginInit();
            this.displayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryGroupBox
            // 
            this.countryGroupBox.Controls.Add(this.IndiaRadioButton6);
            this.countryGroupBox.Controls.Add(this.JapanRadioButton);
            this.countryGroupBox.Controls.Add(this.GermanyRadioButton);
            this.countryGroupBox.Controls.Add(this.EnglandRadioButton3);
            this.countryGroupBox.Controls.Add(this.AmericaRadioButton);
            this.countryGroupBox.Controls.Add(this.ChinaRadioButton);
            this.countryGroupBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.countryGroupBox.Location = new System.Drawing.Point(24, 72);
            this.countryGroupBox.Name = "countryGroupBox";
            this.countryGroupBox.Size = new System.Drawing.Size(184, 296);
            this.countryGroupBox.TabIndex = 0;
            this.countryGroupBox.TabStop = false;
            this.countryGroupBox.Text = "Country";
            // 
            // ChinaRadioButton
            // 
            this.ChinaRadioButton.AutoSize = true;
            this.ChinaRadioButton.Checked = true;
            this.ChinaRadioButton.Location = new System.Drawing.Point(32, 40);
            this.ChinaRadioButton.Name = "ChinaRadioButton";
            this.ChinaRadioButton.Size = new System.Drawing.Size(73, 19);
            this.ChinaRadioButton.TabIndex = 0;
            this.ChinaRadioButton.TabStop = true;
            this.ChinaRadioButton.Text = "&China";
            this.ChinaRadioButton.UseVisualStyleBackColor = true;
            this.ChinaRadioButton.CheckedChanged += new System.EventHandler(this.ChinaRadioButton_CheckedChanged);
            // 
            // AmericaRadioButton
            // 
            this.AmericaRadioButton.AutoSize = true;
            this.AmericaRadioButton.Location = new System.Drawing.Point(32, 83);
            this.AmericaRadioButton.Name = "AmericaRadioButton";
            this.AmericaRadioButton.Size = new System.Drawing.Size(91, 19);
            this.AmericaRadioButton.TabIndex = 1;
            this.AmericaRadioButton.Text = "&America";
            this.AmericaRadioButton.UseVisualStyleBackColor = true;
            this.AmericaRadioButton.CheckedChanged += new System.EventHandler(this.AmericaRadioButton_CheckedChanged);
            // 
            // EnglandRadioButton3
            // 
            this.EnglandRadioButton3.AutoSize = true;
            this.EnglandRadioButton3.Location = new System.Drawing.Point(32, 126);
            this.EnglandRadioButton3.Name = "EnglandRadioButton3";
            this.EnglandRadioButton3.Size = new System.Drawing.Size(91, 19);
            this.EnglandRadioButton3.TabIndex = 2;
            this.EnglandRadioButton3.Text = "&England";
            this.EnglandRadioButton3.UseVisualStyleBackColor = true;
            this.EnglandRadioButton3.CheckedChanged += new System.EventHandler(this.EnglandRadioButton3_CheckedChanged);
            // 
            // GermanyRadioButton
            // 
            this.GermanyRadioButton.AutoSize = true;
            this.GermanyRadioButton.Location = new System.Drawing.Point(32, 169);
            this.GermanyRadioButton.Name = "GermanyRadioButton";
            this.GermanyRadioButton.Size = new System.Drawing.Size(91, 19);
            this.GermanyRadioButton.TabIndex = 3;
            this.GermanyRadioButton.Text = "&Germany";
            this.GermanyRadioButton.UseVisualStyleBackColor = true;
            this.GermanyRadioButton.CheckedChanged += new System.EventHandler(this.GermanyRadioButton_CheckedChanged);
            // 
            // JapanRadioButton
            // 
            this.JapanRadioButton.AutoSize = true;
            this.JapanRadioButton.Location = new System.Drawing.Point(32, 212);
            this.JapanRadioButton.Name = "JapanRadioButton";
            this.JapanRadioButton.Size = new System.Drawing.Size(73, 19);
            this.JapanRadioButton.TabIndex = 4;
            this.JapanRadioButton.Text = "&Japan";
            this.JapanRadioButton.UseVisualStyleBackColor = true;
            this.JapanRadioButton.CheckedChanged += new System.EventHandler(this.JapanRadioButton_CheckedChanged);
            // 
            // IndiaRadioButton6
            // 
            this.IndiaRadioButton6.AutoSize = true;
            this.IndiaRadioButton6.Location = new System.Drawing.Point(32, 255);
            this.IndiaRadioButton6.Name = "IndiaRadioButton6";
            this.IndiaRadioButton6.Size = new System.Drawing.Size(73, 19);
            this.IndiaRadioButton6.TabIndex = 5;
            this.IndiaRadioButton6.Text = "&India";
            this.IndiaRadioButton6.UseVisualStyleBackColor = true;
            this.IndiaRadioButton6.CheckedChanged += new System.EventHandler(this.IndiaRadioButton6_CheckedChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(232, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(273, 44);
            this.title.TabIndex = 1;
            this.title.Text = "Flag Viewer";
            // 
            // flagPictureBox
            // 
            this.flagPictureBox.Image = global::Flag_Viewer_Application.Properties.Resources.ChinaFlag;
            this.flagPictureBox.Location = new System.Drawing.Point(240, 88);
            this.flagPictureBox.Name = "flagPictureBox";
            this.flagPictureBox.Size = new System.Drawing.Size(256, 160);
            this.flagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flagPictureBox.TabIndex = 2;
            this.flagPictureBox.TabStop = false;
            // 
            // ChinaFlag
            // 
            this.ChinaFlag.Image = global::Flag_Viewer_Application.Properties.Resources.ChinaFlag;
            this.ChinaFlag.Location = new System.Drawing.Point(256, 328);
            this.ChinaFlag.Name = "ChinaFlag";
            this.ChinaFlag.Size = new System.Drawing.Size(32, 32);
            this.ChinaFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChinaFlag.TabIndex = 3;
            this.ChinaFlag.TabStop = false;
            this.ChinaFlag.Visible = false;
            // 
            // AmericaFlag
            // 
            this.AmericaFlag.Image = global::Flag_Viewer_Application.Properties.Resources.AmericaFlag;
            this.AmericaFlag.Location = new System.Drawing.Point(296, 328);
            this.AmericaFlag.Name = "AmericaFlag";
            this.AmericaFlag.Size = new System.Drawing.Size(32, 32);
            this.AmericaFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AmericaFlag.TabIndex = 4;
            this.AmericaFlag.TabStop = false;
            this.AmericaFlag.Visible = false;
            // 
            // EnglandFlag
            // 
            this.EnglandFlag.Image = global::Flag_Viewer_Application.Properties.Resources.EnglandFlag;
            this.EnglandFlag.Location = new System.Drawing.Point(336, 328);
            this.EnglandFlag.Name = "EnglandFlag";
            this.EnglandFlag.Size = new System.Drawing.Size(32, 32);
            this.EnglandFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnglandFlag.TabIndex = 5;
            this.EnglandFlag.TabStop = false;
            this.EnglandFlag.Visible = false;
            // 
            // GermanyFlag
            // 
            this.GermanyFlag.Image = global::Flag_Viewer_Application.Properties.Resources.GermanyFlag;
            this.GermanyFlag.Location = new System.Drawing.Point(376, 328);
            this.GermanyFlag.Name = "GermanyFlag";
            this.GermanyFlag.Size = new System.Drawing.Size(32, 32);
            this.GermanyFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GermanyFlag.TabIndex = 6;
            this.GermanyFlag.TabStop = false;
            this.GermanyFlag.Visible = false;
            // 
            // JapanFlag
            // 
            this.JapanFlag.Image = global::Flag_Viewer_Application.Properties.Resources.JapanFlag;
            this.JapanFlag.Location = new System.Drawing.Point(416, 328);
            this.JapanFlag.Name = "JapanFlag";
            this.JapanFlag.Size = new System.Drawing.Size(32, 32);
            this.JapanFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.JapanFlag.TabIndex = 7;
            this.JapanFlag.TabStop = false;
            this.JapanFlag.Visible = false;
            // 
            // IndiaFlag
            // 
            this.IndiaFlag.Image = global::Flag_Viewer_Application.Properties.Resources.IndiaFlag;
            this.IndiaFlag.Location = new System.Drawing.Point(456, 328);
            this.IndiaFlag.Name = "IndiaFlag";
            this.IndiaFlag.Size = new System.Drawing.Size(32, 32);
            this.IndiaFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IndiaFlag.TabIndex = 8;
            this.IndiaFlag.TabStop = false;
            this.IndiaFlag.Visible = false;
            // 
            // displayGroupBox
            // 
            this.displayGroupBox.Controls.Add(this.programerCheckBox);
            this.displayGroupBox.Controls.Add(this.countryCheckBox);
            this.displayGroupBox.Controls.Add(this.titleCheckBox);
            this.displayGroupBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.displayGroupBox.Location = new System.Drawing.Point(576, 72);
            this.displayGroupBox.Name = "displayGroupBox";
            this.displayGroupBox.Size = new System.Drawing.Size(168, 200);
            this.displayGroupBox.TabIndex = 1;
            this.displayGroupBox.TabStop = false;
            this.displayGroupBox.Text = "display";
            // 
            // titleCheckBox
            // 
            this.titleCheckBox.AutoSize = true;
            this.titleCheckBox.Checked = true;
            this.titleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.titleCheckBox.Location = new System.Drawing.Point(24, 48);
            this.titleCheckBox.Name = "titleCheckBox";
            this.titleCheckBox.Size = new System.Drawing.Size(74, 19);
            this.titleCheckBox.TabIndex = 0;
            this.titleCheckBox.Text = "&Title";
            this.titleCheckBox.UseVisualStyleBackColor = true;
            this.titleCheckBox.CheckedChanged += new System.EventHandler(this.titleCheckBox_CheckedChanged);
            // 
            // countryCheckBox
            // 
            this.countryCheckBox.AutoSize = true;
            this.countryCheckBox.Checked = true;
            this.countryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.countryCheckBox.Location = new System.Drawing.Point(24, 100);
            this.countryCheckBox.Name = "countryCheckBox";
            this.countryCheckBox.Size = new System.Drawing.Size(92, 19);
            this.countryCheckBox.TabIndex = 1;
            this.countryCheckBox.Text = "Cou&ntry";
            this.countryCheckBox.UseVisualStyleBackColor = true;
            this.countryCheckBox.CheckedChanged += new System.EventHandler(this.countryCheckBox_CheckedChanged);
            // 
            // programerCheckBox
            // 
            this.programerCheckBox.AutoSize = true;
            this.programerCheckBox.Checked = true;
            this.programerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.programerCheckBox.Location = new System.Drawing.Point(24, 152);
            this.programerCheckBox.Name = "programerCheckBox";
            this.programerCheckBox.Size = new System.Drawing.Size(119, 19);
            this.programerCheckBox.TabIndex = 2;
            this.programerCheckBox.Text = "&Programmer";
            this.programerCheckBox.UseVisualStyleBackColor = true;
            this.programerCheckBox.CheckedChanged += new System.EventHandler(this.programerCheckBox_CheckedChanged);
            // 
            // programmerLabel
            // 
            this.programmerLabel.AutoSize = true;
            this.programmerLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.programmerLabel.Location = new System.Drawing.Point(40, 408);
            this.programmerLabel.Name = "programmerLabel";
            this.programmerLabel.Size = new System.Drawing.Size(259, 15);
            this.programmerLabel.TabIndex = 10;
            this.programmerLabel.Text = "Programmed by: Jenkins Black";
            // 
            // flagNameLabel
            // 
            this.flagNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flagNameLabel.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flagNameLabel.Location = new System.Drawing.Point(240, 272);
            this.flagNameLabel.Name = "flagNameLabel";
            this.flagNameLabel.Size = new System.Drawing.Size(264, 40);
            this.flagNameLabel.TabIndex = 11;
            this.flagNameLabel.Text = "China";
            this.flagNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(600, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 32);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.flagNameLabel);
            this.Controls.Add(this.programmerLabel);
            this.Controls.Add(this.displayGroupBox);
            this.Controls.Add(this.IndiaFlag);
            this.Controls.Add(this.JapanFlag);
            this.Controls.Add(this.GermanyFlag);
            this.Controls.Add(this.EnglandFlag);
            this.Controls.Add(this.AmericaFlag);
            this.Controls.Add(this.ChinaFlag);
            this.Controls.Add(this.flagPictureBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.countryGroupBox);
            this.Name = "Form1";
            this.Text = "Flag Viewer Application";
            this.countryGroupBox.ResumeLayout(false);
            this.countryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChinaFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmericaFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnglandFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GermanyFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JapanFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndiaFlag)).EndInit();
            this.displayGroupBox.ResumeLayout(false);
            this.displayGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox countryGroupBox;
        private System.Windows.Forms.RadioButton IndiaRadioButton6;
        private System.Windows.Forms.RadioButton JapanRadioButton;
        private System.Windows.Forms.RadioButton GermanyRadioButton;
        private System.Windows.Forms.RadioButton EnglandRadioButton3;
        private System.Windows.Forms.RadioButton AmericaRadioButton;
        private System.Windows.Forms.RadioButton ChinaRadioButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox flagPictureBox;
        private System.Windows.Forms.PictureBox ChinaFlag;
        private System.Windows.Forms.PictureBox AmericaFlag;
        private System.Windows.Forms.PictureBox EnglandFlag;
        private System.Windows.Forms.PictureBox GermanyFlag;
        private System.Windows.Forms.PictureBox JapanFlag;
        private System.Windows.Forms.PictureBox IndiaFlag;
        private System.Windows.Forms.GroupBox displayGroupBox;
        private System.Windows.Forms.CheckBox programerCheckBox;
        private System.Windows.Forms.CheckBox countryCheckBox;
        private System.Windows.Forms.CheckBox titleCheckBox;
        private System.Windows.Forms.Label programmerLabel;
        private System.Windows.Forms.Label flagNameLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

