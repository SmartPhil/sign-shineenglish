namespace ShineEnglishSign
{
    partial class GetSignRecord
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
            this.datetime_begin = new System.Windows.Forms.DateTimePicker();
            this.datetime_end = new System.Windows.Forms.DateTimePicker();
            this.txtbox_classcode = new System.Windows.Forms.TextBox();
            this.txtbox_stuname = new System.Windows.Forms.TextBox();
            this.btn_get = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.listview_record = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "起始时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "截止时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "班级编码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "学员姓名";
            // 
            // datetime_begin
            // 
            this.datetime_begin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_begin.Location = new System.Drawing.Point(105, 24);
            this.datetime_begin.Name = "datetime_begin";
            this.datetime_begin.Size = new System.Drawing.Size(114, 21);
            this.datetime_begin.TabIndex = 16;
            this.datetime_begin.Value = new System.DateTime(2016, 4, 9, 0, 0, 0, 0);
            this.datetime_begin.ValueChanged += new System.EventHandler(this.datetime_begin_ValueChanged);
            // 
            // datetime_end
            // 
            this.datetime_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_end.Location = new System.Drawing.Point(331, 24);
            this.datetime_end.Name = "datetime_end";
            this.datetime_end.Size = new System.Drawing.Size(114, 21);
            this.datetime_end.TabIndex = 17;
            this.datetime_end.Value = new System.DateTime(2016, 4, 9, 0, 0, 0, 0);
            this.datetime_end.ValueChanged += new System.EventHandler(this.datetime_end_ValueChanged);
            // 
            // txtbox_classcode
            // 
            this.txtbox_classcode.Location = new System.Drawing.Point(105, 69);
            this.txtbox_classcode.Name = "txtbox_classcode";
            this.txtbox_classcode.Size = new System.Drawing.Size(114, 21);
            this.txtbox_classcode.TabIndex = 18;
            // 
            // txtbox_stuname
            // 
            this.txtbox_stuname.Location = new System.Drawing.Point(331, 70);
            this.txtbox_stuname.Name = "txtbox_stuname";
            this.txtbox_stuname.Size = new System.Drawing.Size(114, 21);
            this.txtbox_stuname.TabIndex = 19;
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(757, 17);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(75, 38);
            this.btn_get.TabIndex = 20;
            this.btn_get.Text = "查询";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click_1);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(757, 60);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 38);
            this.btn_export.TabIndex = 21;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click_1);
            // 
            // listview_record
            // 
            this.listview_record.Location = new System.Drawing.Point(34, 107);
            this.listview_record.Name = "listview_record";
            this.listview_record.Size = new System.Drawing.Size(798, 304);
            this.listview_record.TabIndex = 22;
            this.listview_record.UseCompatibleStateImageBehavior = false;
            this.listview_record.View = System.Windows.Forms.View.Details;
            // 
            // GetSignRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 423);
            this.Controls.Add(this.listview_record);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.txtbox_stuname);
            this.Controls.Add(this.txtbox_classcode);
            this.Controls.Add(this.datetime_end);
            this.Controls.Add(this.datetime_begin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "GetSignRecord";
            this.Text = "查询考勤记录";
            this.Load += new System.EventHandler(this.GetSignRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datetime_begin;
        private System.Windows.Forms.DateTimePicker datetime_end;
        private System.Windows.Forms.TextBox txtbox_classcode;
        private System.Windows.Forms.TextBox txtbox_stuname;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ListView listview_record;
    }
}