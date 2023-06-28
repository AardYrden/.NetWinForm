using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class FrmRegister : Form
    {
        private NetContext netContext = new NetContext();
        private string filePath = "C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/null.png";

        /* 验证
         * 账号 3 - 10 位
         * 密码 3 - 15 位, 包含字母数字
         * 用户名 1 - 15 位
         */
        private bool IsUNoLeave = false;
        private bool IsUPwdLeave = false;
        private bool IsUNameLeave = false;

        private string? tmpUNo;
        private string? tmpUPwd;
        private string? tmpUName;

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            textUNo.MaxLength = 10;
            textUPwd.MaxLength = 15;
            textUName.MaxLength = 15;
            radioButton1.Checked = true;
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (label7.Text.Equals("×") || label8.Text.Equals("×") || label9.Text.Equals("×"))
            {
                MessageBox.Show("注册信息不正确", "error");
            }
            else
            {
                TUser user = new TUser();
                user.Uno = textUNo.Text;
                user.Upwd = textUPwd.Text;
                user.Uname = textUName.Text;
                user.Usxey = radioButton1.Checked ? 1 : 0;
                user.Ubdate = dateTimePicker1.Value;

                Bitmap bmp = new Bitmap(filePath);
                Image img = Image.FromHbitmap(bmp.GetHbitmap());
                user.Uimg = Util.ImgToByte(img, ImageFormat.Jpeg);

                user.Utele = textUTele.Text;

                string admin = adminText.Text;
                if (admin != "")
                {
                    MySqlConnection conn = new MySqlConnection("data source=localhost;database=net;user id=root;password=123456;");
                    MySqlCommand? cmd = new MySqlCommand("select count(*) from t_admin where ano = " + admin, conn);

                    conn.Open();
                    user.Isadmin = Convert.ToInt16(cmd.ExecuteScalar()!.ToString()) != 0 ? 1 : 0;
                }
                else user.Isadmin = 0;

                user.Good = 2;

                netContext.Add(user);
                netContext.SaveChanges();
                MessageBox.Show("注册成功!", "success");
                this.Close();
            }
            //new FrmLogin().Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //new FrmLogin().Show();
        }

        // 验证账号
        private void textUNo_MouseClick(object sender, MouseEventArgs e)
        {
            textUNo.Text = tmpUNo;
            textUNo.ForeColor = Color.Black;
            if (IsUNoLeave)
            {
                textUNo.Focus();
                textUNo.Select(tmpUNo!.Length, 0);
            }
        }

        private void textUNo_Leave(object sender, EventArgs e)
        {
            IsUNoLeave = true;
            int unoLength = textUNo.Text.Trim().Length;
            tmpUNo = textUNo.Text.Equals("账号 3 - 10 位") ? "" : textUNo.Text;
            if (unoLength < 3 || unoLength > 10)
            {
                label7.Text = "×";
                label7.ForeColor = Color.Red;
                textUNo.Text = "账号 3 - 10 位";
                textUNo.ForeColor = Color.Red;
            }
            else
            {
                label7.Text = "√";
                label7.ForeColor = Color.Green;
            }
        }

        // 验证密码
        private void textUPwd_MouseClick(object sender, MouseEventArgs e)
        {
            textUPwd.Text = tmpUPwd;
            if (IsUPwdLeave && !tmpUPwd!.Equals("密码 3 - 15 位, 包含字母数字"))
            {
                textUPwd.ForeColor = Color.Black;
                textUPwd.Select(tmpUPwd!.Length, 0);
            }
        }

        private void textUPwd_Leave(object sender, EventArgs e)
        {
            IsUPwdLeave = true;
            tmpUPwd = textUPwd.Text.Equals("密码 3 - 15 位, 包含字母数字") ? "" : textUPwd.Text;
            if (!TestPwd(tmpUPwd))
            {
                label8.Text = "×";
                label8.ForeColor = Color.Red;
                textUPwd.Text = "密码 3 - 15 位, 包含字母数字";
                textUPwd.ForeColor = Color.Red;
            }
            else
            {
                label8.Text = "√";
                label8.ForeColor = Color.Green;
            }
        }

        public bool TestPwd(string pwd)
        {
            string reg = @"^(?![0-9]+$)(?![a-zA-Z]+$)[0-9A-Za-z]{3,15}$";
            Match m = new Regex(reg).Match(pwd);
            return m.Success;
        }

        // 验证用户名
        private void textUName_MouseClick(object sender, MouseEventArgs e)
        {
            textUName.Text = tmpUName;
            if (IsUNameLeave)
            {
                textUName.ForeColor = Color.Black;
                textUName.Select(tmpUName!.Length, 0);
            }
        }

        private void textUName_Leave(object sender, EventArgs e)
        {
            IsUNameLeave = true;
            int unameLength = textUName.Text.Trim().Length;
            tmpUName = textUName.Text.Equals("用户名 1 - 15 位") ? "" : textUName.Text;
            if (unameLength < 1 || unameLength > 15 || textUName.Text.Equals("用户名 1 - 15 位"))
            {
                label9.Text = "×";
                label9.ForeColor = Color.Red;
                textUName.Text = "用户名 1 - 15 位";
                textUName.ForeColor = Color.Red;
            }
            else
            {
                label9.Text = "√";
                label9.ForeColor = Color.Green;
            }
        }

        private void textUNo_TextChanged(object sender, EventArgs e)
        {
            textUNo.ForeColor = Color.Black;
        }

        private void textUPwd_TextChanged(object sender, EventArgs e)
        {
            textUPwd.ForeColor = Color.Black;
        }

        private void textUName_TextChanged(object sender, EventArgs e)
        {
            textUName.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "图片(*.jpg, *.png)|*.jpg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName.Replace('\\', '/');
                Bitmap bmp = new Bitmap(filePath);
                Image img = Image.FromHbitmap(bmp.GetHbitmap());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = img;
            }
        }
    }
}
