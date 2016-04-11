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
using System.Xml;

namespace ShineEnglishSign
{
    public partial class Form1 : Form
    {
        public int mark = 0;
        delegate void HandleInterfaceUpdateDelegate(string text);  //委托，此为重点
        HandleInterfaceUpdateDelegate interfaceUpdateHandle;
        public Form1()
        {
            InitializeComponent();
            interfaceUpdateHandle = new HandleInterfaceUpdateDelegate(UpdateTextBox);  //实例化委托对象
        }

        private void UpdateTextBox(string text)
        {
            this.txtBox_name.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");    //加载Xml文件
            XmlElement rootElem = doc.DocumentElement;   //获取根节点
            XmlNodeList portNodes = rootElem.GetElementsByTagName("port"); //获取person子节点集合
            serialPort1.PortName = portNodes[0].InnerText;
            serialPort1.Open();

            ColumnHeader ch0 = new ColumnHeader();
            ch0.Text = "序号";
            ch0.Width = 50;
            ch0.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch3 = new ColumnHeader();
            ch3.Text = "班级编码";
            ch3.Width = 100;
            ch3.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch1 = new ColumnHeader();
            ch1.Text = "学员姓名";
            ch1.Width = 100;
            ch1.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch2 = new ColumnHeader();
            ch2.Text = "签到时间";
            ch2.Width = 120;
            ch2.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch4 = new ColumnHeader();
            ch4.Text = "打卡次数";
            ch4.Width = 100;
            ch4.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch5 = new ColumnHeader();
            ch5.Text = "英文姓名";
            ch5.Width = 100;
            ch5.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch6 = new ColumnHeader();
            ch6.Text = "剩余课时";
            ch6.Width = 100;
            ch6.TextAlign = HorizontalAlignment.Left;

            ColumnHeader ch7 = new ColumnHeader();
            ch7.Text = "总课时";
            ch7.Width = 100;
            ch7.TextAlign = HorizontalAlignment.Left;

            signList.Columns.Add(ch0);
            signList.Columns.Add(ch3);
            signList.Columns.Add(ch1);
            signList.Columns.Add(ch5);
            signList.Columns.Add(ch2);
            signList.Columns.Add(ch4);
            signList.Columns.Add(ch6);
            signList.Columns.Add(ch7);
        }

        private void textBox1_TextChanged(object sender, EventArgs ea)
        {
            if (txtBox_name.Text.EndsWith("*")) {
                mark++;
                string name = txtBox_name.Text.Split('*')[0];
               
                //通过学员姓名查询学员信息
                MySqlConnection con = DBConnector.getcon();
                con.Open();
                string sql = "select * from student where stuname = '" + name + "'";
                MySqlCommand comm = new MySqlCommand(sql, con);
                MySqlDataReader reader = comm.ExecuteReader();
                student stu = new student();
                try
                {
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("无此学员信息！");
                        return;
                    }
                    while(reader.Read())
                    {
                       stu.id = reader.GetInt32(0);
                       stu.stuname = reader.GetString(1);
                       stu.englishname = reader.GetString(2);
                       stu.classtime = reader.GetInt32(3);
                       stu.signtime = reader.GetInt32(4);
                       stu.classcode = reader.GetString(5);
                       stu.singleclasstime = reader.GetInt32(6);
                       stu.remainderclasstime = reader.GetInt32(7);
                    }
                }
                catch 
                {
                    MessageBox.Show("查询学员信息失败！");
                }
                reader.Close();

                //判断此学员是今天第几次打卡
                bool isSign = false;
                string sql2 = "select * from signlist where stuid = " + stu.id + " and signtime >= '" + DateTime.Now.ToString().Split(' ')[0] + "'";
                MySqlCommand comm2 = new MySqlCommand(sql2, con);
                MySqlDataReader reader2 = comm2.ExecuteReader();
                try
                {
                    //今天没有当前学员的打卡记录
                    if (!reader2.HasRows)
                    {
                        stu.signtime++;
                        isSign = false;
                    }
                    else 
                    {
                        isSign = true;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("查询当前学员打卡记录失败！---" + e.Message);
                }
                finally 
                {
                    reader2.Close();
                }

                //保存此学员打卡信息 

                if (!isSign) 
                {
                    stu.remainderclasstime = stu.remainderclasstime - stu.singleclasstime;
                }
                string sql1 = "update student set signtime = " + stu.signtime + ",remainderclasstime = " + stu.remainderclasstime + " where id = '" + stu.id + "'";
                MySqlCommand comm1 = new MySqlCommand(sql1, con);
                try
                {
                    if (comm1.ExecuteNonQuery() > 0)
                    {
                        //
                    }
                    else {
                        MessageBox.Show("保存学员打卡信息失败！");
                    }
                }
                catch
                {
                    MessageBox.Show("保存学员打卡信息失败！");
                }

                string now = DateTime.Now.ToString();
                string sql3 = "insert into signlist(signtime,stuid) values('" + now + "'," + stu.id + ")";
                MySqlCommand comm3 = new MySqlCommand(sql3, con);
                try
                {
                    if (comm3.ExecuteNonQuery() > 0)
                    {
                        //
                    }
                    else
                    {
                        MessageBox.Show("保存打卡信息失败！");
                    }
                }
                catch
                {
                    MessageBox.Show("保存打卡信息失败！");
                }
                finally {
                    if (con.State == ConnectionState.Open) {
                        con.Close();
                    }
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                //显示打卡信息
                signList.BeginUpdate();
                ListViewItem lvi1 = new ListViewItem();
                lvi1.Text = mark.ToString();
                lvi1.SubItems.Add(stu.classcode);
                lvi1.SubItems.Add(stu.stuname);
                lvi1.SubItems.Add(stu.englishname);
                lvi1.SubItems.Add(DateTime.Now.ToString().Split(' ')[1]);
                lvi1.SubItems.Add(stu.signtime.ToString());
                lvi1.SubItems.Add(stu.remainderclasstime.ToString());
                lvi1.SubItems.Add(stu.classtime.ToString());
                signList.Items.Add(lvi1);
                signList.EndUpdate();
                txtBox_name.Text = "";
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int length = serialPort1.BytesToRead;
            byte[] bytes = new byte[length];

            serialPort1.Read(bytes, 0, length);
            string data = Encoding.UTF8.GetString(bytes);
            this.Invoke(interfaceUpdateHandle, data);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void skinButton1_Click_1(object sender, EventArgs e)
        {
            GeneralQRcode codeForm = new GeneralQRcode();
            codeForm.Show();
        }

        private void btn_getSignRecord_Click_1(object sender, EventArgs e)
        {
            GetSignRecord recordform = new GetSignRecord();
            recordform.Show();
        }
    }
}
