using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class FrmEditObj : Form
    {
        private NetContext netContext = new NetContext();
        private TUser user;
        private TObj obj;
        private string? filePath;

        public FrmEditObj()
        {
            InitializeComponent();
        }

        public FrmEditObj(TUser user, TObj obj)
        {
            InitializeComponent();
            this.user = user;
            this.obj = obj;
            textBox1.Text = obj.Oname;
            switch (obj.Ocate)
            {
                case 1:
                    comboBox1.Text = "书";
                    break;
                case 2:
                    comboBox1.Text = "体育用品";
                    break;
                case 3:
                    comboBox1.Text = "工具";
                    break;
                case 4:
                    comboBox1.Text = "电子产品";
                    break;
                case 5:
                    comboBox1.Text = "乐器";
                    break;
                case 6:
                    comboBox1.Text = "小玩意";
                    break;
                default:
                    comboBox1.Text = "其他";
                    break;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Util.ByteToImg(obj.Oimg);

            comboBox2.Text = obj.Oretime.ToString() + "天";

            switch (obj.Ostatus)
            {
                case 1:
                    radioButton1.Checked = true;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    break;
                case 2:
                    radioButton1.Enabled = false;
                    radioButton2.Checked = true;
                    radioButton3.Enabled = false;
                    break;
                case 3:
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Checked = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int oid = obj.Oid;

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

            int ostatus;
            if (radioButton1.Checked) ostatus = 1;
            else if (radioButton2.Checked) ostatus = 2;
            else ostatus = 3;

            byte[] oimg = obj.Oimg;

            if (filePath != null)
            {
                Bitmap bmp = new Bitmap(filePath);
                Image img = Image.FromHbitmap(bmp.GetHbitmap());
                oimg = Util.ImgToByte(img, ImageFormat.Jpeg);
            }

            var newObj = netContext.TObj.Where(o => o.Oid == oid).FirstOrDefault();
            newObj.Oname = oname;
            newObj.Ocate = ocate;
            newObj.Oimg = oimg;
            newObj.Oretime = oretime;
            newObj.Ostatus = ostatus;
            
            if (netContext.SaveChanges()  != 0) MessageBox.Show("修改成功!", "success");
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
