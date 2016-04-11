namespace ShineEnglishSign
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.signList = new System.Windows.Forms.ListView();
            this.skinButton1 = new System.Windows.Forms.Button();
            this.btn_getSignRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(206, 26);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(391, 21);
            this.txtBox_name.TabIndex = 4;
            this.txtBox_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "扫码时请将鼠标放置于该输入框中";
            // 
            // signList
            // 
            this.signList.Location = new System.Drawing.Point(15, 62);
            this.signList.Name = "signList";
            this.signList.Size = new System.Drawing.Size(784, 316);
            this.signList.TabIndex = 7;
            this.signList.UseCompatibleStateImageBehavior = false;
            this.signList.View = System.Windows.Forms.View.Details;
            // 
            // skinButton1
            // 
            this.skinButton1.Location = new System.Drawing.Point(15, 396);
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.Size = new System.Drawing.Size(85, 30);
            this.skinButton1.TabIndex = 8;
            this.skinButton1.Text = "生成二维码";
            this.skinButton1.UseVisualStyleBackColor = true;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click_1);
            // 
            // btn_getSignRecord
            // 
            this.btn_getSignRecord.Location = new System.Drawing.Point(120, 396);
            this.btn_getSignRecord.Name = "btn_getSignRecord";
            this.btn_getSignRecord.Size = new System.Drawing.Size(97, 30);
            this.btn_getSignRecord.TabIndex = 9;
            this.btn_getSignRecord.Text = "查询考勤记录";
            this.btn_getSignRecord.UseVisualStyleBackColor = true;
            this.btn_getSignRecord.Click += new System.EventHandler(this.btn_getSignRecord_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 440);
            this.Controls.Add(this.btn_getSignRecord);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.signList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_name);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "签到";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_name;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView signList;
        private System.Windows.Forms.Button skinButton1;
        private System.Windows.Forms.Button btn_getSignRecord;
    }
}

