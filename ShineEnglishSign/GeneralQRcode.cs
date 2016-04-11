using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
using ThoughtWorks.QRCode.Codec.Util;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ShineEnglishSign
{
    public partial class GeneralQRcode : Form
    {
        public GeneralQRcode()
        {
            InitializeComponent();
        }

        private void skinButton1_Click_1(object sender, EventArgs e)
        {
            //设置二维码
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeScale = 5;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            qrCodeEncoder.QRCodeVersion = 1;

            //生成并显示二维码
            Image image;
            String data = nameText.Text;
            image = qrCodeEncoder.Encode(data + "*", Encoding.UTF8);
            codePicBox.Image = image;
        }

        private void btn_saveCode_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = DBConnector.getcon();
            con.Open();
            try
            {
                //保存二维码到本地
                if (!Directory.Exists("d:/QRCode/"))
                {
                    Directory.CreateDirectory("d:/QRCode/");
                }
                string filename = nameText.Text + ".bmp";
                codePicBox.Image.Save(@"d:/QRCode/" + filename);

                //保存学员信息到数据库
                string classCode = txtbox_classCode.Text;
                //中文姓名
                string name = nameText.Text;
                //英文姓名
                string englishName = txtbox_englishname.Text;
                //总课时
                decimal totalClassTime = num_totalclasstime.Value;
                //单次课时
                decimal singleClassTime = num_singleclasstime.Value;

                string sql = "insert into student(stuname,englishname,classtime,signtime,classcode,singleclasstime,remainderclasstime) values('" + name + "','" + englishName + "'," + totalClassTime + ",0,'" + classCode + "'," + singleClassTime + "," + totalClassTime + ")";
                MySqlCommand comm = new MySqlCommand(sql, con);
                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("保存失败！");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
