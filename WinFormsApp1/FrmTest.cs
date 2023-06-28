using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class FrmTest : Form
    {

        NetContext netContext;
        public FrmTest()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            getApplyListViewData();
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

                    var obj = netContext.TObj.Where(o => o.Oid == oid).FirstOrDefault();

                    obj.Ostatus = 2;

                    var borrow = netContext.TBorrow.Where(o => o.Bid == bid).FirstOrDefault();

                    borrow.Pass = 1;

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

                    netContext = new NetContext();

                    netContext.TBorrow.Where(o => o.Bid == bid).FirstOrDefault()!.Pass = 2;

                    netContext.SaveChanges();
                }
                MessageBox.Show("申请已被处理", "info");
            }
            getApplyListViewData();
        }
    }
}
