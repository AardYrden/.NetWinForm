using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class FrmAddObj : Form
    {
        private NetContext netContext = new NetContext();
        private TUser? user;
        private string filePath = "C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/null.png";

        public FrmAddObj() { }

        public FrmAddObj(TUser user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oname = textBox1.Text;

            int ocate;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "书":
                    ocate = 1;
                    break;
                case "体育用品":
                    ocate = 2;
                    break;
                case "工具":
                    ocate = 3;
                    break;
                case "电子产品":
                    ocate = 4;
                    break;
                case "乐器":
                    ocate = 5;
                    break;
                case "小玩意":
                    ocate = 6;
                    break;
                default:
                    ocate = 7;
                    break;
            }

            int oretime = Convert.ToInt32(comboBox2.SelectedItem.ToString()!.Substring(0, comboBox2.SelectedItem.ToString()!.Length - 1));

            int ostatus = 1;

            MySqlConnection conn = new MySqlConnection("data source=localhost;database=net;user id=root;password=123456;");
            MySqlCommand cmd = new MySqlCommand("insert into t_obj(oname, ocate, oimg, oretime, ostatus, uid) values('" + oname + "', " + ocate + ", LOAD_FILE('" + filePath + "'), " + oretime + ", " + ostatus + ", " + user!.Uid + ")", conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            conn.Close();

            if (r != 0) MessageBox.Show("添加成功!", "success");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
