namespace ShineEnglishSign
{
    partial class GeneralQRcode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_classCode = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.txtbox_englishname = new System.Windows.Forms.TextBox();
            this.num_totalclasstime = new System.Windows.Forms.NumericUpDown();
            this.num_singleclasstime = new System.Windows.Forms.NumericUpDown();
            this.skinButton1 = new System.Windows.Forms.Button();
            this.btn_saveCode = new System.Windows.Forms.Button();
            this.codePicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_totalclasstime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_singleclasstime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "班级编码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "英文姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "总学时：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "单次学时：";
            // 
            // txtbox_classCode
            // 
            this.txtbox_classCode.Location = new System.Drawing.Point(99, 29);
            this.txtbox_classCode.Name = "txtbox_classCode";
            this.txtbox_classCode.Size = new System.Drawing.Size(160, 21);
            this.txtbox_classCode.TabIndex = 22;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(98, 74);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(160, 21);
            this.nameText.TabIndex = 23;
            // 
            // txtbox_englishname
            // 
            this.txtbox_englishname.Location = new System.Drawing.Point(98, 119);
            this.txtbox_englishname.Name = "txtbox_englishname";
            this.txtbox_englishname.Size = new System.Drawing.Size(160, 21);
            this.txtbox_englishname.TabIndex = 23;
            // 
            // num_totalclasstime
            // 
            this.num_totalclasstime.Location = new System.Drawing.Point(98, 172);
            this.num_totalclasstime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_totalclasstime.Name = "num_totalclasstime";
            this.num_totalclasstime.Size = new System.Drawing.Size(160, 21);
            this.num_totalclasstime.TabIndex = 24;
            // 
            // num_singleclasstime
            // 
            this.num_singleclasstime.Location = new System.Drawing.Point(99, 215);
            this.num_singleclasstime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_singleclasstime.Name = "num_singleclasstime";
            this.num_singleclasstime.Size = new System.Drawing.Size(160, 21);
            this.num_singleclasstime.TabIndex = 25;
            // 
            // skinButton1
            // 
            this.skinButton1.Location = new System.Drawing.Point(310, 21);
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.Size = new System.Drawing.Size(98, 35);
            this.skinButton1.TabIndex = 26;
            this.skinButton1.Text = "生成二维码";
            this.skinButton1.UseVisualStyleBackColor = true;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click_1);
            // 
            // btn_saveCode
            // 
            this.btn_saveCode.Location = new System.Drawing.Point(310, 77);
            this.btn_saveCode.Name = "btn_saveCode";
            this.btn_saveCode.Size = new System.Drawing.Size(98, 33);
            this.btn_saveCode.TabIndex = 27;
            this.btn_saveCode.Text = "保存";
            this.btn_saveCode.UseVisualStyleBackColor = true;
            this.btn_saveCode.Click += new System.EventHandler(this.btn_saveCode_Click_1);
            // 
            // codePicBox
            // 
            this.codePicBox.Location = new System.Drawing.Point(292, 134);
            this.codePicBox.Name = "codePicBox";
            this.codePicBox.Size = new System.Drawing.Size(116, 102);
            this.codePicBox.TabIndex = 28;
            this.codePicBox.TabStop = false;
            // 
            // GeneralQRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 259);
            this.Controls.Add(this.codePicBox);
            this.Controls.Add(this.btn_saveCode);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.num_singleclasstime);
            this.Controls.Add(this.num_totalclasstime);
            this.Controls.Add(this.txtbox_englishname);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.txtbox_classCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "GeneralQRcode";
            this.Text = "生成二维码";
            ((System.ComponentModel.ISupportInitialize)(this.num_totalclasstime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_singleclasstime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_classCode;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox txtbox_englishname;
        private System.Windows.Forms.NumericUpDown num_totalclasstime;
        private System.Windows.Forms.NumericUpDown num_singleclasstime;
        private System.Windows.Forms.Button skinButton1;
        private System.Windows.Forms.Button btn_saveCode;
        private System.Windows.Forms.PictureBox codePicBox;
    }
}