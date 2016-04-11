using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Aspose.Cells;


namespace ShineEnglishSign
{
    public partial class GetSignRecord : Form
    {
        public GetSignRecord()
        {
            InitializeComponent();
        }

        private void GetSignRecord_Load(object sender, EventArgs e)
        {
            this.datetime_begin.Format = DateTimePickerFormat.Custom;
            this.datetime_begin.CustomFormat = "   ";
            this.datetime_end.Format = DateTimePickerFormat.Custom;
            this.datetime_end.CustomFormat = "   "; 

            ColumnHeader ch0 = new ColumnHeader();
            ch0.Text = "序号";
            ch0.Width = 50;
            ch0.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch1 = new ColumnHeader();
            ch1.Text = "班级编码";
            ch1.Width = 100;
            ch1.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch2 = new ColumnHeader();
            ch2.Text = "学员姓名";
            ch2.Width = 100;
            ch2.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch3 = new ColumnHeader();
            ch3.Text = "签到时间";
            ch3.Width = 120;
            ch3.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch4 = new ColumnHeader();
            ch4.Text = "打卡次数";
            ch4.Width = 100;
            ch4.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch5 = new ColumnHeader();
            ch5.Text = "英文姓名";
            ch5.Width = 100;
            ch5.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch6 = new ColumnHeader();
            ch6.Text = "总学时";
            ch6.Width = 100;
            ch6.TextAlign = HorizontalAlignment.Left;
            
            ColumnHeader ch7 = new ColumnHeader();
            ch7.Text = "剩余学时";
            ch7.Width = 100;
            ch7.TextAlign = HorizontalAlignment.Left;

            listview_record.Columns.Add(ch0);
            listview_record.Columns.Add(ch1);
            listview_record.Columns.Add(ch2);
            listview_record.Columns.Add(ch5);
            listview_record.Columns.Add(ch3);
            listview_record.Columns.Add(ch4);
            listview_record.Columns.Add(ch6);
            listview_record.Columns.Add(ch7);
        }

        /// <summary>
        /// 具体导出的方法
        /// </summary>
        /// <param name="listView">ListView</param>
        /// <param name="strFileName">导出到的文件名</param>
        private void DoExport(ListView listView, string strFileName)
        {
            int rowNum = listView.Items.Count;
            int columnNum = listView.Items[0].SubItems.Count;
            if (rowNum == 0 || string.IsNullOrEmpty(strFileName))
            {
                return;
            }
            if (rowNum > 0)
            {
                Workbook wb = new Workbook();
                Worksheet ws = wb.Worksheets[0];
                Cells cell = ws.Cells;
                //设置样式
                Style style1 = wb.Styles[wb.Styles.Add()];
                style1.HorizontalAlignment = TextAlignmentType.Center;
                style1.Font.Name = "宋体";
                style1.Font.IsBold = true;
                style1.Font.Size = 12;

                Style style2 = wb.Styles[wb.Styles.Add()];
                style2.HorizontalAlignment = TextAlignmentType.Center;
                style2.Font.Size = 12;

                //将ListView的列名导入Excel表第一行
                int i = 0;
                foreach (ColumnHeader dc in listView.Columns)
                {
                    cell[0, i].PutValue(dc.Text);
                    cell[0, i].SetStyle(style1);
                    i++;
                }

               //将ListView中的数据导入Excel中
                for (int m = 0; m < listView.Items.Count; m++) 
                {
                    for (int n = 0; n < listView.Columns.Count; n++) 
                    {
                        cell[m + 1, n].PutValue(Convert.ToString(listView.Items[m].SubItems[n].Text) + "\t");
                        cell[m + 1, n].SetStyle(style2);
                    }
                }

                int[] widths = new int[8];
                widths[0] = 12;
                widths[1] = 13;
                widths[2] = 14;
                widths[3] = 14;
                widths[4] = 30;
                widths[5] = 13;
                widths[6] = 12;
                widths[7] = 13;

                for (int j = 0; j < listView.Columns.Count; j++) 
                {
                    cell.SetColumnWidth(j, widths[j]);
                }

                wb.Save(strFileName);
                MessageBox.Show("导出成功！");
            }
        }

        private void btn_get_Click_1(object sender, EventArgs ea)
        {
            string beginDate = datetime_begin.Text;
            string endDate = datetime_end.Text;
            string classcode = txtbox_classcode.Text;
            string stuname = txtbox_stuname.Text;
            if (beginDate.Equals("") && endDate.Equals("") && classcode.Equals("") && stuname.Equals(""))
            {
                MessageBox.Show("请输入查询条件！");
                return;
            }
            else
            {
                listview_record.Items.Clear();
                listview_record.Refresh();

                MySqlConnection con = DBConnector.getcon();
                con.Open();
                //首先查询出符合条件的学员
                string sql1 = "select * from student where 1=1";
                if (!stuname.Equals(""))
                {
                    sql1 += " and stuname = '" + stuname + "'";
                }
                if (!classcode.Equals(""))
                {
                    sql1 += " and classcode = '" + classcode + "'";
                }
                MySqlCommand comm1 = new MySqlCommand(sql1, con);
                MySqlDataReader reader1 = comm1.ExecuteReader();
                List<student> studentList = new List<student>();
                try
                {
                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            student stu = new student();
                            stu.id = reader1.GetInt32(0);
                            stu.stuname = reader1.GetString(1);
                            stu.englishname = reader1.GetString(2);
                            stu.classtime = reader1.GetInt32(3);
                            stu.signtime = reader1.GetInt32(4);
                            stu.classcode = reader1.GetString(5);
                            stu.singleclasstime = reader1.GetInt32(6);
                            stu.remainderclasstime = reader1.GetInt32(7);
                            studentList.Add(stu);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("查询学员信息失败：" + e.Message);
                }
                finally
                {
                    reader1.Close();
                }
                //单独列出符合条件的学员ID
                List<int> stuidList = new List<int>();
                string idstring = "";
                foreach (student stu in studentList)
                {
                    stuidList.Add(stu.id);
                    idstring += "'" + stu.id.ToString() + "',";
                }
                if (!idstring.Equals(""))
                {
                    idstring = idstring.Substring(0, idstring.Length - 1);
                }

                //防止起截止时间为空
                if (beginDate.Equals(""))
                {
                    beginDate = "1949-01-01";
                }
                if (endDate.Equals(""))
                {
                    endDate = "9999-12-31";
                }

                string sql2 = "select * from signlist where signtime >= '" + beginDate + "' and signtime <= '" + endDate + "'";
                MySqlCommand comm2 = new MySqlCommand(sql2, con);
                MySqlDataReader reader2 = comm2.ExecuteReader();
                List<signlist> Signlist = new List<signlist>();
                while (reader2.Read())
                {
                    signlist list = new signlist();
                    list.id = reader2.GetInt32(0);
                    list.signtime = reader2.GetString(1);
                    list.stuid = reader2.GetInt32(2);
                    Signlist.Add(list);
                }
                reader2.Close();
                List<record> records = new List<record>();
                //MySqlDataReader reader3;
                foreach (signlist sign in Signlist)
                {
                    record record = new record();
                    int stuid = sign.stuid;
                    foreach (student stu in studentList)
                    {
                        if (stu.id == stuid)
                        {
                            record.stuname = stu.stuname;
                            record.englishname = stu.englishname;
                            record.classcode = stu.classcode;
                            record.signdate = sign.signtime;
                            record.signtime = stu.signtime;
                            record.classtime = stu.classtime;
                            record.remainderclasstime = stu.remainderclasstime;
                            records.Add(record);
                        }
                    }
                }

                int mark = 0;
                listview_record.BeginUpdate();
                foreach (record record in records)
                {
                    mark++;
                    ListViewItem lvi1 = new ListViewItem();
                    lvi1.Text = mark.ToString();
                    lvi1.SubItems.Add(record.classcode);
                    lvi1.SubItems.Add(record.stuname);
                    lvi1.SubItems.Add(record.englishname);
                    lvi1.SubItems.Add(record.signdate);
                    lvi1.SubItems.Add(record.signtime.ToString());
                    lvi1.SubItems.Add(record.classtime.ToString());
                    lvi1.SubItems.Add(record.remainderclasstime.ToString());
                    listview_record.Items.Add(lvi1);
                }
                listview_record.EndUpdate();
            }
        }

        private void btn_export_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "xls";
            sfd.Filter = "Excel文件(*.xls)|*.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DoExport(this.listview_record, sfd.FileName);
            }
        }

        private void datetime_begin_ValueChanged(object sender, EventArgs e)
        {
            this.datetime_begin.CustomFormat = null; 
        }

        private void datetime_end_ValueChanged(object sender, EventArgs e)
        {
            this.datetime_end.CustomFormat = null; 
        }
    }
}
