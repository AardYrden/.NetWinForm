using System.Data.SqlClient;
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
using MySqlConnector;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class FrmMain : Form
    {
        private NetContext netContext;
        private MySqlConnection conn = new MySqlConnection("data source=localhost;database=net;user id=root;password=123456;");
        private MySqlCommand? cmd;
        private TUser? user;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(TUser user)
        {
            InitializeComponent();
            this.user = user;

            welcomeuname.Text = user.Uname;
            welcomeIdentity.ForeColor = Color.Gray;
            if (user.Isadmin == 0) welcomeIdentity.Text = " -用户-";
            else welcomeIdentity.Text = "-管理员-";

            // 图片等比例缩放
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.Image = Util.ByteToImg(user.Uimg);

            getMyObjDataListViewData();
            getMyBorDataListViewData();
            getMyLostDataListViewData();
        }

        private void homeHide()
        {
            myObjInfoLabel.Hide();
            myBorInfoLabel.Hide();
            myLostInfoLabel.Hide();

            myObjCountLabel.Hide();
            myBorCountLabel.Hide();
            myLostCountLabel.Hide();

            myObjMore.Hide();
            myBorMore.Hide();
            myLostMore.Hide();

            myObjInfoListView.Hide();
            myBorInfoListView.Hide();
            myLostInfoListView.Hide();

            myObjDataListView.Hide();
            myBorDataListView.Hide();
            myLostDataListView.Hide();

        }

        private void homeShow()
        {
            myObjInfoLabel.Show();
            myBorInfoLabel.Show();
            myLostInfoLabel.Show();

            myObjCountLabel.Show();
            myBorCountLabel.Show();
            myLostCountLabel.Show();

            myObjMore.Show();
            myBorMore.Show();
            myLostMore.Show();

            myObjInfoListView.Show();
            myBorInfoListView.Show();
            myLostInfoListView.Show();

            myObjDataListView.Show();
            myBorDataListView.Show();
            myLostDataListView.Show();
        }

        private void objHide()
        {
            objNameQueryTextBox.Hide();
            objCategoryQueryComboBox.Hide();

            objNameClear.Hide();
            objCategoryClear.Hide();

            objAddBtn.Hide();
            objEditBtn.Hide();
            objDelBtn.Hide();
            objNameQueryBtn.Hide();
            objCategoryQueryBtn.Hide();

            objListView.Hide();
        }

        private void objShow()
        {
            objNameQueryTextBox.Show();
            objCategoryQueryComboBox.Show();

            objNameClear.Show();
            objCategoryClear.Show();

            objAddBtn.Show();
            objEditBtn.Show();
            objDelBtn.Show();
            objNameQueryBtn.Show();
            objCategoryQueryBtn.Show();

            objListView.Show();
        }

        private void borHide()
        {
            borObjNameQueryTextBox.Hide();
            borObjCategoryQueryComboBox.Hide();

            borObjNameClear.Hide();
            borObjCategoryClear.Hide();

            borBorBtn.Hide();
            borReBtn.Hide();
            borProBorBtn.Hide();
            borObjNameQueryBtn.Hide();
            borObjCategoryQueryBtn.Hide();

            borObjListView.Hide();
            borReListView.Hide();
        }

        private void borShow()
        {
            borObjNameQueryTextBox.Show();
            borObjCategoryQueryComboBox.Show();

            borObjNameClear.Show();
            borObjCategoryClear.Show();

            borBorBtn.Show();
            borReBtn.Show();
            borProBorBtn.Show();
            borObjNameQueryBtn.Show();
            borObjCategoryQueryBtn.Show();

            borObjListView.Show();
            borReListView.Show();
        }

        private void applyHide()
        {
            applyAgreeBtn.Hide();
            applyRejectBtn.Hide();

            applyListView.Hide();
        }

        private void applyShow()
        {
            applyAgreeBtn.Show();
            applyRejectBtn.Show();

            applyListView.Show();
        }

        private void lostHide()
        {

            lostWarnBtn.Hide();
            LostWarnAndDepriveBtn.Hide();
            lostKickOffBtn.Hide();

            lostListView.Hide();
            lostUserListView.Hide();
        }

        private void lostShow()
        {
            lostWarnBtn.Show();
            LostWarnAndDepriveBtn.Show();
            lostKickOffBtn.Show();

            lostListView.Show();
            lostUserListView.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objHide();
            borHide();
            applyHide();
            lostHide();
            homeShow();

            // 我的物品
            getMyObjDataListViewData();
            // 我的借用
            getMyBorDataListViewData();
            // 疑似丢失
            getMyLostDataListViewData();
        }

        private void objLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            homeHide();
            borHide();
            applyHide();
            lostHide();
            objShow();

            objNameQueryTextBox.Clear();
            objCategoryQueryComboBox.Text = null;

            netContext = new NetContext();
            getObjListViewData(netContext.TObj.ToList());
        }

        private void borLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            homeHide();
            objHide();
            applyHide();
            lostHide();
            borShow();

            borReListView.Items.Clear();
            borObjListView.Items.Clear();

            getBorObjListViewData();
            getBorReListViewData();
        }

        private void applyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (user!.Isadmin == 1)
            {
                homeHide();
                objHide();
                borHide();
                lostHide();
                applyShow();

                applyListView.Items.Clear();

                getApplyListViewData();
            }
            else MessageBox.Show("您不是管理员, 无法访问", "info");
        }

        private void lostLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (user!.Isadmin == 1)
            {
                homeHide();
                objHide();
                borHide();
                applyHide();
                lostShow();

                lostListView.Items.Clear();
                lostImageList.Images.Clear();

                LostWarnAndDepriveBtn.BackColor = SystemColors.Control;
                lostKickOffBtn.BackColor = SystemColors.Control;

                getLostListViewData();
                getLostUserListViewData();
            }
            else MessageBox.Show("您不是管理员, 无法访问", "info");
        }

        private void exitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void getMyObjDataListViewData()
        {
            myObjDataListView.Items.Clear();

            conn.Open();
            cmd = new MySqlCommand("select o.oname, u.uname, o.ostatus from t_obj o left join t_borrow b on o.oid = b.oid left join t_user u on u.uid = b.uid where o.uid = " + user!.Uid, conn);
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                ListViewItem item = new ListViewItem(result["oname"].ToString());

                item.UseItemStyleForSubItems = false;

                item.SubItems.Add(result["uname"].ToString()!.Equals("") ? "无" : result["uname"].ToString());

                switch (result["ostatus"])
                {
                    case 0:
                        item.SubItems.Add("正在审核...");
                        item.SubItems[2].ForeColor = Color.Gray;
                        break;
                    case 1:
                        item.SubItems.Add("可借用");
                        item.SubItems[2].ForeColor = Color.Green;
                        break;
                    case 2:
                        item.SubItems.Add("已被借用");
                        item.SubItems[2].ForeColor = Color.Orange;
                        break;
                    case 3:
                        item.SubItems.Add("超出归还日期");
                        item.SubItems[2].ForeColor = Color.Red;
                        break;
                }
                myObjDataListView.Items.Add(item);
            }
            conn.Close();
            cmd = new MySqlCommand("select count(*) from t_obj where uid = " + user!.Uid, conn);
            conn.Open();
            myObjCountLabel.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString() + "件";
        }

        private void getMyBorDataListViewData()
        {
            myBorDataListView.Items.Clear();

            netContext = new NetContext();

            var result = from u in netContext.TUser
                         join o in netContext.TObj on u.Uid equals o.Uid
                         join b in netContext.TBorrow on o.Oid equals b.Oid
                         where b.Uid == user!.Uid && b.Pass == 1
                         select new
                         {
                             oname = o.Oname,
                             uname = u.Uname,
                             ostatus = o.Ostatus,
                             retime = b.Retime
                         };
            foreach (var r in result)
            {
                ListViewItem item = new ListViewItem(r.oname);

                item.UseItemStyleForSubItems = false;

                item.SubItems.Add(r.uname);

                item.SubItems.Add(Convert.ToDateTime(r.retime).ToString("yyyy-MM-dd")!.Substring(0, 10));

                DateTime now = DateTime.Now;

                item.SubItems[2].ForeColor = DateTime.Compare(now, (DateTime)r.retime!) < 0 ? Color.Green : Color.Red;

                myBorDataListView.Items.Add(item);
            }
            cmd = new MySqlCommand("select count(*) from t_borrow where pass = 1 and uid = " + user!.Uid, conn);
            myBorCountLabel.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString() + "件";
            conn.Close();
        }

        private void getMyLostDataListViewData()
        {
            myLostDataListView.Items.Clear();

            conn.Open();
            cmd = new MySqlCommand("select count(*) from t_obj where uid = " + user!.Uid + " and ostatus = 3", conn);
            myLostCountLabel.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString() + "件";
            if (Convert.ToInt32(cmd.ExecuteScalar()) != 0) myLostCountLabel.ForeColor = Color.Red;
            conn.Close();

            conn.Open();
            cmd = new MySqlCommand("select o.oname, u.uname, b.retime from t_obj o left join t_borrow b on o.oid = b.oid left join t_user u on u.uid = b.uid where o.uid = " + user!.Uid + " and o.ostatus = 3", conn);
            MySqlDataReader result = cmd.ExecuteReader();

            while (result.Read())
            {
                ListViewItem item = new ListViewItem(result["oname"].ToString());

                item.UseItemStyleForSubItems = false;

                item.SubItems.Add(result["uname"].ToString());

                DateTime retime = (DateTime)result["retime"];
                DateTime now = DateTime.Now;

                item.SubItems.Add(Math.Abs((int)(now - retime).TotalDays) + "天");
                item.SubItems[2].ForeColor = Color.Red;

                myLostDataListView.Items.Add(item);
            }
            conn.Close();
        }

        private void getObjListViewData(List<TObj> data)
        {
            objListView.Items.Clear();

            objImageList.Images.Clear();

            int t = 0;

            foreach (var r in data)
            {
                ListViewItem item = new ListViewItem(Convert.ToBase64String(r.Oimg));

                item.UseItemStyleForSubItems = false;

                item.SubItems[0].ForeColor = Color.White;
                objImageList.Images.Add(Util.ByteToImg(r.Oimg));
                item.ImageIndex = t++;

                item.SubItems.Add(r.Oid.ToString());

                item.SubItems.Add(r.Oname);

                switch (r.Ocate)
                {
                    case 1:
                        item.SubItems.Add("书");
                        break;
                    case 2:
                        item.SubItems.Add("体育用品");
                        break;
                    case 3:
                        item.SubItems.Add("工具");
                        break;
                    case 4:
                        item.SubItems.Add("电子产品");
                        break;
                    case 5:
                        item.SubItems.Add("乐器");
                        break;
                    case 6:
                        item.SubItems.Add("小玩意");
                        break;
                    default:
                        item.SubItems.Add("其他");
                        break;
                }

                item.SubItems.Add(r.Oretime.ToString() + "天");

                switch (r.Ostatus)
                {
                    case 0:
                        item.SubItems.Add("正在审核...");
                        item.SubItems[5].ForeColor = Color.Gray;
                        break;
                    case 1:
                        item.SubItems.Add("可借用");
                        item.SubItems[5].ForeColor = Color.Green;
                        break;
                    case 2:
                        item.SubItems.Add("已被借用");
                        item.SubItems[5].ForeColor = Color.Orange;
                        break;
                    case 3:
                        item.SubItems.Add("超出归还日期");
                        item.SubItems[5].ForeColor = Color.Red;
                        break;
                }

                item.SubItems.Add(r.Uid.ToString());

                objListView.Items.Add(item);
            }
        }

        private void getBorObjListViewData()
        {
            borObjListView.Items.Clear();

            borImageList.Images.Clear();

            netContext = new NetContext();

            var result = netContext.TObj.Where(o => o.Ostatus == 1 && o.Uid != user!.Uid).ToList();

            int t = 0;

            foreach (var r in result)
            {
                ListViewItem item = new ListViewItem();

                item.UseItemStyleForSubItems = false;

                borImageList.Images.Add(Util.ByteToImg(r.Oimg));
                item.ImageIndex = t++;

                item.SubItems.Add(r.Oname);

                switch (r.Ocate)
                {
                    case 1:
                        item.SubItems.Add("书");
                        break;
                    case 2:
                        item.SubItems.Add("体育用品");
                        break;
                    case 3:
                        item.SubItems.Add("工具");
                        break;
                    case 4:
                        item.SubItems.Add("电子产品");
                        break;
                    case 5:
                        item.SubItems.Add("乐器");
                        break;
                    case 6:
                        item.SubItems.Add("小玩意");
                        break;
                    default:
                        item.SubItems.Add("其他");
                        break;
                }

                item.SubItems.Add(r.Oretime.ToString() + "天");

                item.SubItems.Add(DateTime.Now.AddDays((double)r.Oretime!).ToString("yyyy-MM-dd").Substring(0, 10));

                item.SubItems.Add(r.Oid.ToString());

                borObjListView.Items.Add(item);
            }

        }

        private void getBorObjListViewData(List<TObj> result)
        {
            borObjListView.Items.Clear();

            borImageList.Images.Clear();

            netContext = new NetContext();

            int t = 0;

            foreach (var r in result)
            {
                ListViewItem item = new ListViewItem();

                item.UseItemStyleForSubItems = false;

                borImageList.Images.Add(Util.ByteToImg(r.Oimg));
                item.ImageIndex = t++;

                item.SubItems.Add(r.Oname);

                switch (r.Ocate)
                {
                    case 1:
                        item.SubItems.Add("书");
                        break;
                    case 2:
                        item.SubItems.Add("体育用品");
                        break;
                    case 3:
                        item.SubItems.Add("工具");
                        break;
                    case 4:
                        item.SubItems.Add("电子产品");
                        break;
                    case 5:
                        item.SubItems.Add("乐器");
                        break;
                    case 6:
                        item.SubItems.Add("小玩意");
                        break;
                    default:
                        item.SubItems.Add("其他");
                        break;
                }

                item.SubItems.Add(r.Oretime.ToString() + "天");

                item.SubItems.Add(DateTime.Now.AddDays((double)r.Oretime!).ToString("yyyy-MM-dd").Substring(0, 10));

                item.SubItems.Add(r.Oid.ToString());

                borObjListView.Items.Add(item);
            }
        }

        private void getBorReListViewData()
        {
            borReListView.Items.Clear();

            bool haveBor = false;

            netContext = new NetContext();

            var result = from u in netContext.TUser
                         join o in netContext.TObj on u.Uid equals o.Uid
                         join b in netContext.TBorrow on o.Oid equals b.Oid
                         where b.Uid == user!.Uid && b.Pass == 1
                         select new
                         {
                             bid = b.Bid,
                             oid = o.Oid,
                             oname = o.Oname,
                             uname = u.Uname,
                             ostatus = o.Ostatus,
                             oretime = o.Oretime,
                             retime = b.Retime
                         };
            foreach (var r in result)
            {
                haveBor = true;

                ListViewItem item = new ListViewItem(r.bid.ToString());

                item.UseItemStyleForSubItems = false;

                item.SubItems.Add(r.oid.ToString());

                item.SubItems.Add(r.oname);

                item.SubItems.Add(r.uname);

                DateTime now = DateTime.Now;

                item.SubItems.Add(r.oretime.ToString() + "天");

                item.SubItems.Add((int)(Convert.ToDateTime(r.retime) - now).TotalDays + "天");

                item.SubItems[5].ForeColor = DateTime.Compare(now, (DateTime)r.retime!) < 0 ? Color.Green : Color.Red;

                item.SubItems.Add(Convert.ToDateTime(r.retime).ToString("yyyy-MM-dd")!.Substring(0, 10));

                item.SubItems[6].ForeColor = DateTime.Compare(now, (DateTime)r.retime!) < 0 ? Color.Green : Color.Red;

                borReListView.Items.Add(item);
            }

            if (!haveBor) borReListView.Items.Add(new ListViewItem("您没借任何物品"));
        }

        private void getApplyListViewData()
        {

            applyListView.Items.Clear();

            netContext = new NetContext();

            var result = netContext.TBorrow.OrderBy(o => o.Pass);

            foreach (var r in result)
            {
                int oid = (int)r.Oid!;
                int uid = (int)r.Uid!;

                netContext = new NetContext();
                string oname = netContext.TObj.Where(o => o.Oid == oid).FirstOrDefault()!.Oname;

                netContext = new NetContext();

                var user = netContext.TUser.Where(o => o.Uid == uid).FirstOrDefault();

                string uname = user!.Uname;
                ListViewItem item = new ListViewItem(oname);

                item.UseItemStyleForSubItems = false;

                item.SubItems.Add(uname);

                item.SubItems.Add(r.Retime.ToString());

                int good = (int)user.Good!;

                switch (good)
                {
                    case 0:
                        item.SubItems.Add("信用差");
                        item.SubItems[3].ForeColor = Color.Red;
                        break;
                    case 1:
                        item.SubItems.Add("已被警告");
                        item.SubItems[3].ForeColor = Color.Orange;
                        break;
                    case 2:
                        item.SubItems.Add("信用好");
                        item.SubItems[3].ForeColor = Color.Green;
                        break;
                }

                item.SubItems.Add(oid.ToString());
                item.SubItems.Add(r.Bid.ToString());

                switch (r.Pass)
                {
                    case 0:
                        item.SubItems.Add("待通过");
                        item.SubItems[6].ForeColor = Color.Orange;
                        break;
                    case 1:
                        item.SubItems.Add("已通过");
                        item.SubItems[6].ForeColor = Color.Green;
                        break;
                    case 2:
                        item.SubItems.Add("未通过");
                        item.SubItems[6].ForeColor = Color.Red;
                        break;
                }

                applyListView.Items.Add(item);
            }

        }

        private void getLostListViewData()
        {
            lostListView.Items.Clear();
            lostImageList.Images.Clear();

            netContext = new NetContext();

            var result = from o in netContext.TObj
                         join b in netContext.TBorrow on o.Oid equals b.Oid
                         join u in netContext.TUser on o.Uid equals u.Uid
                         where o.Ostatus == 3
                         select new
                         {
                             oimg = o.Oimg,
                             oname = o.Oname,
                             ocate = o.Ocate,
                             retime = b.Retime,
                             uname = u.Uname,
                             bid = b.Bid
                         };

            int t = 0;

            foreach (var r in result)
            {
                ListViewItem item = new ListViewItem();

                item.UseItemStyleForSubItems = false;

                lostImageList.Images.Add(Util.ByteToImg(r.oimg));
                item.ImageIndex = t++;

                item.SubItems.Add(r.oname);

                switch (r.ocate)
                {
                    case 1:
                        item.SubItems.Add("书");
                        break;
                    case 2:
                        item.SubItems.Add("体育用品");
                        break;
                    case 3:
                        item.SubItems.Add("工具");
                        break;
                    case 4:
                        item.SubItems.Add("电子产品");
                        break;
                    case 5:
                        item.SubItems.Add("乐器");
                        break;
                    case 6:
                        item.SubItems.Add("小玩意");
                        break;
                    default:
                        item.SubItems.Add("其他");
                        break;
                }

                int outTime = Math.Abs((int)((DateTime)r.retime! - DateTime.Now).TotalDays);

                item.SubItems.Add(outTime + "天");

                if (outTime < 30) item.SubItems[3].ForeColor = Color.Orange;
                else item.SubItems[3].ForeColor = Color.Red;

                item.SubItems.Add(r.uname);

                netContext = new NetContext();

                var tr = from b in netContext.TBorrow
                         join u in netContext.TUser on b.Uid equals u.Uid
                         where b.Bid == r.bid
                         select new
                         {
                             uname = u.Uname
                         };

                foreach (var ttr in tr) item.SubItems.Add(ttr.uname);

                lostListView.Items.Add(item);
            }
        }

        private void getLostUserListViewData()
        {
            lostUserListView.Items.Clear();

            cmd = new MySqlCommand("select u.uid, u.uname, count(*) cnt, u.good from t_user u join t_borrow b on u.uid = b.uid join t_obj o on o.oid = b.oid where o.ostatus = 3 group by u.uid order by cnt desc;", conn);

            conn.Open();

            MySqlDataReader result = cmd.ExecuteReader();

            while (result.Read())
            {
                ListViewItem item = new ListViewItem(result["uid"].ToString());

                item.SubItems.Add(result["uname"].ToString());

                item.SubItems.Add(Convert.ToInt32(result["cnt"]).ToString() + "件");

                switch (result["good"].ToString())
                {
                    case "0":
                        item.ForeColor = Color.Red;
                        item.SubItems.Add("信用差");
                        break;
                    case "1":
                        item.ForeColor = Color.Orange;
                        item.SubItems.Add("已被警告");
                        break;
                    case "2":
                        item.ForeColor = Color.Green;
                        item.SubItems.Add("信用好");
                        break;
                }

                lostUserListView.Items.Add(item);
            }
            conn.Close();
        }

        private void avatar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "图片(*.jpg, *.png)|*.jpg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName.Replace('\\', '/');

                cmd = new MySqlCommand("update t_user set uimg = LOAD_FILE('" + filePath + "') where uid = " + user!.Uid, conn);
                conn.Open();
                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                {
                    user!.Uimg = (from u in netContext.TUser
                                  where u.Uid == user.Uid
                                  select u.Uimg).ToArray()[0];
                    avatar.Image = Util.ByteToImg(user!.Uimg);
                    MessageBox.Show("修改成功!", "success");
                }
                conn.Close();
            }
        }

        private void avatar_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void avatar_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = System.DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒");
        }

        private void myObjMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objLinkLabel_LinkClicked(sender, e);
        }

        private void myBorMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            borLinkLabel_LinkClicked(sender, e);
        }

        private void myLostMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lostLinkLabel_LinkClicked(sender, e);
        }

        private void objAddBtn_Click(object sender, EventArgs e)
        {
            FrmAddObj frmAddObj = new FrmAddObj(user!);
            var result = frmAddObj.ShowDialog();
            if (result == DialogResult.OK)
            {
                netContext = new NetContext();
                getObjListViewData(netContext.TObj.ToList());
            }
        }

        private void objEditBtn_Click(object sender, EventArgs e)
        {
            if (user!.Isadmin == 1)
            {
                if (objListView.SelectedItems.Count == 0 || objListView.SelectedItems.Count > 1)
                {
                    MessageBox.Show("请选择一条", "info");
                }
                else
                {
                    TObj obj = new TObj();
                    ListViewItem item = objListView.SelectedItems[0];

                    int oid = Convert.ToInt16(item.SubItems[1].Text);
                    string oname = item.SubItems[2].Text;
                    int ocate;
                    switch (item.SubItems[3].Text)
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

                    byte[] oimg = Convert.FromBase64String(item.SubItems[0].Text);

                    int oretime = Convert.ToInt16(item.SubItems[4].Text.Substring(0, item.SubItems[4].Text.Length - 1));

                    int ostatus;
                    switch (item.SubItems[5].Text)
                    {
                        case "可借用":
                            ostatus = 1;
                            break;
                        case "已被借用":
                            ostatus = 2;
                            break;
                        default:
                            ostatus = 3;
                            break;
                    }

                    obj.Oid = oid;
                    obj.Oname = oname;
                    obj.Ocate = ocate;
                    obj.Oimg = oimg;
                    obj.Oretime = oretime;
                    obj.Ostatus = ostatus;

                    FrmEditObj frmEditObj = new FrmEditObj(user!, obj);
                    var result = frmEditObj.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        netContext = new NetContext();
                        getObjListViewData(netContext.TObj.ToList());
                    }
                }
            }
            else
            {
                MessageBox.Show("您不是管理员, 不可更改信息", "error");
            }
        }

        private void objDelBtn_Click(object sender, EventArgs e)
        {
            if (user!.Isadmin == 1)
            {
                if (objListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("请选择要删除的物品", "info");
                }
                else
                {
                    if (MessageBox.Show("确定要删除吗？", "info", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        netContext = new NetContext();
                        foreach (ListViewItem item in objListView.SelectedItems)
                        {
                            netContext.TBorrow.RemoveRange(netContext.TBorrow.Where(o => o.Oid == Convert.ToInt32(item.SubItems[1].Text)));
                            netContext.TObj.Remove(netContext.TObj.Where(o => o.Oid == Convert.ToInt32(item.SubItems[1].Text)).FirstOrDefault()!);
                        }
                        netContext.SaveChanges();

                        MessageBox.Show("删除完成!", "success");

                        getObjListViewData(netContext.TObj.ToList());
                    }
                }
            }
            else
            {
                MessageBox.Show("您不是管理员, 不可删除物品", "error");
            }
        }

        private void objQueryBtn_Click(object sender, EventArgs e)
        {
            netContext = new NetContext();

            string oname = objNameQueryTextBox.Text;
            int ocate;
            if (objCategoryQueryComboBox.SelectedItem != null)
            {
                switch (objCategoryQueryComboBox.SelectedItem.ToString())
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
                getObjListViewData(netContext.TObj.Where(o => o.Oname.Contains(oname) && o.Ocate == ocate).ToList());
            }
            else
            {
                getObjListViewData(netContext.TObj.Where(o => o.Oname.Contains(oname)).ToList());
            }
        }

        private void objNameClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objNameQueryTextBox.Clear();
        }

        private void objCategoryClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objCategoryQueryComboBox.SelectedItem = null;
        }

        private void borBorBtn_Click(object sender, EventArgs e)
        {
            if (user!.Good == 0) MessageBox.Show("您信用太差, 无法再借! 先还点罢!", "info");
            else
            {
                if (borObjListView.SelectedItems.Count != 1) MessageBox.Show("请选择一条", "info");
                else
                {
                    if (MessageBox.Show("确定要借用吗？", "info", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        netContext = new NetContext();

                        ListViewItem item = borObjListView.SelectedItems[0];

                        TBorrow borrow = new TBorrow();

                        borrow.Uid = user!.Uid;
                        borrow.Oid = Convert.ToInt32(item.SubItems[5].Text);
                        borrow.Retime = Convert.ToDateTime(item.SubItems[4].Text);
                        borrow.Pass = 0;

                        netContext.TBorrow.Add(borrow);

                        netContext.TObj.Where(o => o.Oid == Convert.ToInt32(item.SubItems[5].Text)).FirstOrDefault()!.Ostatus = 0;

                        netContext.SaveChanges();

                        MessageBox.Show("借用申请提交成功! 正在等待管理员审核...", "success");

                        borObjQueryBtn_Click(sender, e);
                        //getBorReListViewData();
                    }
                }
            }
        }

        private void borReBtn_Click(object sender, EventArgs e)
        {
            if (borReListView.SelectedItems.Count == 0) MessageBox.Show("请选择一条", "info");
            else
            {
                if (MessageBox.Show("确定要归还吗？", "info", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    netContext = new NetContext();

                    var r = netContext.TUser.Where(o => o.Uid == user!.Uid).FirstOrDefault();

                    if (r.Good == 0)
                    {
                        r.Good += 1;
                        MessageBox.Show("您的信用曾岌岌可危, 还好归还了", "info");
                    }
                    else if (r.Good == 1)
                    {
                        r.Good += 1;
                        MessageBox.Show("您需注意守信", "info");
                    }
                    else MessageBox.Show("您信用很好!", "info");

                    foreach (ListViewItem item in borReListView.SelectedItems)
                    {
                        netContext.TBorrow.Remove(netContext.TBorrow.Where(o => o.Bid == Convert.ToInt32(item.SubItems[0].Text)).FirstOrDefault()!);
                        netContext.TObj.Where(o => o.Oid == Convert.ToInt32(item.SubItems[1].Text)).FirstOrDefault()!.Ostatus = 1;
                    }
                    netContext.SaveChanges();

                    MessageBox.Show("归还完成!", "success");

                    user = netContext.TUser.Where(o => o.Uid == user!.Uid).FirstOrDefault();

                    getBorObjListViewData();
                    getBorReListViewData();
                }
            }
        }

        private void borProBorBtn_Click(object sender, EventArgs e)
        {
            if (user!.Good == 0) MessageBox.Show("您信用太差, 无法再借! 先还点罢!", "info");
            else
            {
                if (borReListView.SelectedItems.Count != 1) MessageBox.Show("请选择一条", "info");
                else
                {
                    if (MessageBox.Show("确定要续借吗？", "info", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        netContext = new NetContext();

                        ListViewItem item = borReListView.SelectedItems[0];

                        int bid = Convert.ToInt32(item.SubItems[0].Text);
                        int oid = Convert.ToInt32(item.SubItems[1].Text);
                        int oretime = Convert.ToInt32(item.SubItems[4].Text.Substring(0, item.SubItems[4].Text.Length - 1));
                        int leftTime = Convert.ToInt32(item.SubItems[5].Text.Substring(0, item.SubItems[5].Text.Length - 1)) + oretime;
                        DateTime retime = Convert.ToDateTime(item.SubItems[6].Text).AddDays(oretime);

                        if (leftTime >= 0)
                        {
                            netContext.TObj.Where(o => o.Oid == oid).FirstOrDefault()!.Ostatus = 2;
                        }

                        netContext.TBorrow.Where(o => o.Bid == bid).FirstOrDefault()!.Retime = retime;

                        netContext.SaveChanges();

                        //续借提交成功! 正在等待管理员审核...
                        MessageBox.Show("续借成功!", "info");

                        getBorReListViewData();

                    }
                }
            }
        }

        private void borObjQueryBtn_Click(object sender, EventArgs e)
        {
            netContext = new NetContext();

            string oname = borObjNameQueryTextBox.Text;
            int ocate;
            if (borObjCategoryQueryComboBox.SelectedItem != null)
            {
                switch (borObjCategoryQueryComboBox.SelectedItem.ToString())
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
                getBorObjListViewData(netContext.TObj.Where(o => o.Uid != user!.Uid && o.Oname.Contains(oname) && o.Ocate == ocate && o.Ostatus == 1).ToList());
            }
            else
            {
                getBorObjListViewData(netContext.TObj.Where(o => o.Uid != user!.Uid && o.Oname.Contains(oname) && o.Ostatus == 1).ToList());
            }
        }

        private void borObjNameClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            borObjNameQueryTextBox.Clear();
        }

        private void borObjCategoryClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            borObjCategoryQueryComboBox.SelectedItem = null;
        }

        private void applyAgreeBtn_Click(object sender, EventArgs e)
        {
            if (applyListView.SelectedItems.Count < 1) MessageBox.Show("请至少选择一条", "info");
            else
            {
                for (int i = 0; i < applyListView.SelectedItems.Count; i++)
                {
                    ListViewItem item = applyListView.SelectedItems[i];

                    int oid = Convert.ToInt16(item.SubItems[4].Text);
                    int bid = Convert.ToInt16(item.SubItems[5].Text);

                    netContext = new NetContext();

                    netContext.TObj.Where(o => o.Oid == oid).FirstOrDefault()!.Ostatus = 2;

                    netContext.TBorrow.Where(o => o.Bid == bid).FirstOrDefault()!.Pass = 1;

                    netContext.SaveChanges();
                }
                MessageBox.Show("物品借用申请通过!", "info");
            }
            getApplyListViewData();
        }

        private void applyRejectBtn_Click(object sender, EventArgs e)
        {
            if (applyListView.SelectedItems.Count < 1) MessageBox.Show("请至少选择一条", "info");
            else
            {
                for (int i = 0; i < applyListView.SelectedItems.Count; i++)
                {
                    ListViewItem item = applyListView.SelectedItems[i];

                    int bid = Convert.ToInt16(item.SubItems[5].Text);
                    int oid = Convert.ToInt16(item.SubItems[4].Text);

                    netContext = new NetContext();

                    netContext.TBorrow.Where(o => o.Bid == bid).FirstOrDefault()!.Pass = 2;

                    netContext.TObj.Where(o => o.Oid == oid).FirstOrDefault()!.Ostatus = 1;

                    netContext.SaveChanges();
                }
                MessageBox.Show("申请已被处理", "info");
            }
            getApplyListViewData();
        }

        private void lostWarnBtn_Click(object sender, EventArgs e)
        {
            if (lostUserListView.SelectedItems.Count != 1) MessageBox.Show("请选择一条", "info");
            else
            {
                int uid = Convert.ToInt16(lostUserListView.SelectedItems[0].Text);

                netContext = new NetContext();

                var r = netContext.TUser.Where(o => o.Uid == uid).FirstOrDefault()!;

                if (r.Good == 2)
                {
                    r.Good -= 1;
                    MessageBox.Show("已警告", "info");
                    LostWarnAndDepriveBtn.BackColor = SystemColors.Control;
                    lostKickOffBtn.BackColor = SystemColors.Control;
                }
                else if (r.Good == 1)
                {
                    r.Good -= 1;
                    MessageBox.Show("已警告, 这边建议禁止他继续借物!", "info");
                    LostWarnAndDepriveBtn.BackColor = Color.MistyRose;
                    lostKickOffBtn.BackColor = SystemColors.Control;
                }
                else
                {
                    MessageBox.Show("已警告, 但该用户信用太差! 建议 kick off!", "info");
                    LostWarnAndDepriveBtn.BackColor = SystemColors.Control;
                    lostKickOffBtn.BackColor = Color.LightCoral;
                }

                netContext.SaveChanges();

                getLostUserListViewData();
            }
        }

        private void LostWarnAndDepriveBtn_Click(object sender, EventArgs e)
        {
            if (lostUserListView.SelectedItems.Count != 1) MessageBox.Show("请选择一条", "info");
            else
            {
                int uid = Convert.ToInt16(lostUserListView.SelectedItems[0].Text);

                netContext = new NetContext();

                netContext.TUser.Where(o => o.Uid == uid).FirstOrDefault()!.Good = 0;
                MessageBox.Show("警告完毕, 该用户已无法继续借物!", "info");
                netContext.SaveChanges();

                getLostUserListViewData();
            }
        }

        private void lostKickOffBtn_Click(object sender, EventArgs e)
        {
            if (lostUserListView.SelectedItems.Count != 1) MessageBox.Show("请选择一条", "info");
            else
            {
                if (Convert.ToInt16(lostUserListView.SelectedItems[0].Text) == user!.Uid) MessageBox.Show("还是别踢自己吧", "info");
                else
                {
                    if (MessageBox.Show("您确定删除该用户吗？", "info", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                        int uid = Convert.ToInt16(lostUserListView.SelectedItems[0].Text);

                        netContext = new NetContext();

                        string sql1 = "delete from t_user where uid = " + uid;

                        string sql2 = "delete from t_obj where uid = " + uid;

                        string sql3 = "delete from t_borrow where uid = " + uid;

                        string sql4 = "update t_obj set ostatus = 1 " +
                            "where oid in (select oid from t_borrow where uid = " + uid + ")";

                        string sql5 = "delete from t_borrow " +
                            "where oid in (select oid from t_obj where uid = " + uid + ")";

                        delHelper(sql5);
                        delHelper(sql4);
                        delHelper(sql3);
                        delHelper(sql2);
                        delHelper(sql1);


                        MessageBox.Show("删除完成", "info");
                    }

                    getLostListViewData();
                    getLostUserListViewData();
                }
            }
        }

        private void delHelper(string sql)
        {
            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
