namespace WinFormsApp1
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            welcomeuname = new Label();
            objListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            objImageList = new ImageList(components);
            listView1 = new ListView();
            homeLinkLabel = new LinkLabel();
            objLinkLabel = new LinkLabel();
            lostLinkLabel = new LinkLabel();
            borLinkLabel = new LinkLabel();
            avatar = new PictureBox();
            objAddBtn = new Button();
            objEditBtn = new Button();
            welcomeIdentity = new Label();
            label1 = new Label();
            myLostDataListView = new ListView();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            myBorDataListView = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            myObjDataListView = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            myObjInfoLabel = new Label();
            myBorInfoLabel = new Label();
            myObjInfoListView = new ListView();
            myObjCountLabel = new Label();
            myBorInfoListView = new ListView();
            myBorCountLabel = new Label();
            myLostInfoListView = new ListView();
            myLostInfoLabel = new Label();
            myLostCountLabel = new Label();
            myObjMore = new LinkLabel();
            myLostMore = new LinkLabel();
            myBorMore = new LinkLabel();
            timer = new System.Windows.Forms.Timer(components);
            timeLabel = new Label();
            objDelBtn = new Button();
            objNameQueryTextBox = new TextBox();
            objCategoryQueryComboBox = new ComboBox();
            objNameQueryBtn = new Button();
            objCategoryQueryBtn = new Button();
            objNameClear = new LinkLabel();
            objCategoryClear = new LinkLabel();
            exitLinkLabel = new LinkLabel();
            borProBorBtn = new Button();
            borReListView = new ListView();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            borBorBtn = new Button();
            borReBtn = new Button();
            borObjListView = new ListView();
            columnHeader24 = new ColumnHeader();
            columnHeader25 = new ColumnHeader();
            columnHeader26 = new ColumnHeader();
            columnHeader27 = new ColumnHeader();
            columnHeader28 = new ColumnHeader();
            columnHeader29 = new ColumnHeader();
            borImageList = new ImageList(components);
            borObjCategoryClear = new LinkLabel();
            borObjNameClear = new LinkLabel();
            borObjCategoryQueryBtn = new Button();
            borObjNameQueryBtn = new Button();
            borObjCategoryQueryComboBox = new ComboBox();
            borObjNameQueryTextBox = new TextBox();
            lostKickOffBtn = new Button();
            LostWarnAndDepriveBtn = new Button();
            lostWarnBtn = new Button();
            lostUserListView = new ListView();
            columnHeader38 = new ColumnHeader();
            columnHeader30 = new ColumnHeader();
            columnHeader31 = new ColumnHeader();
            columnHeader39 = new ColumnHeader();
            lostListView = new ListView();
            columnHeader32 = new ColumnHeader();
            columnHeader33 = new ColumnHeader();
            columnHeader34 = new ColumnHeader();
            columnHeader35 = new ColumnHeader();
            columnHeader36 = new ColumnHeader();
            columnHeader37 = new ColumnHeader();
            lostImageList = new ImageList(components);
            applyLinkLabel = new LinkLabel();
            applyRejectBtn = new Button();
            applyAgreeBtn = new Button();
            applyListView = new ListView();
            columnHeader40 = new ColumnHeader();
            columnHeader41 = new ColumnHeader();
            columnHeader42 = new ColumnHeader();
            columnHeader43 = new ColumnHeader();
            columnHeader44 = new ColumnHeader();
            columnHeader45 = new ColumnHeader();
            columnHeader46 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            SuspendLayout();
            // 
            // welcomeuname
            // 
            welcomeuname.AutoSize = true;
            welcomeuname.BackColor = Color.White;
            welcomeuname.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeuname.ForeColor = Color.Black;
            welcomeuname.Location = new Point(110, 171);
            welcomeuname.Name = "welcomeuname";
            welcomeuname.Size = new Size(76, 25);
            welcomeuname.TabIndex = 1;
            welcomeuname.Text = "uname";
            // 
            // objListView
            // 
            objListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            objListView.FullRowSelect = true;
            objListView.Location = new Point(328, 114);
            objListView.Name = "objListView";
            objListView.Size = new Size(752, 662);
            objListView.SmallImageList = objImageList;
            objListView.TabIndex = 2;
            objListView.UseCompatibleStateImageBehavior = false;
            objListView.View = View.Details;
            objListView.Visible = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "物品图片";
            columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "OId";
            columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "物品名";
            columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "物品种类";
            columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "最长借用天数";
            columnHeader5.Width = 155;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "物品状态";
            columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "UId";
            columnHeader7.Width = 0;
            // 
            // objImageList
            // 
            objImageList.ColorDepth = ColorDepth.Depth8Bit;
            objImageList.ImageSize = new Size(90, 90);
            objImageList.TransparentColor = Color.Transparent;
            // 
            // listView1
            // 
            listView1.Location = new Point(29, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(232, 787);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // homeLinkLabel
            // 
            homeLinkLabel.ActiveLinkColor = Color.CornflowerBlue;
            homeLinkLabel.AutoSize = true;
            homeLinkLabel.BackColor = Color.White;
            homeLinkLabel.DisabledLinkColor = Color.White;
            homeLinkLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homeLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            homeLinkLabel.LinkColor = Color.Black;
            homeLinkLabel.Location = new Point(101, 296);
            homeLinkLabel.Name = "homeLinkLabel";
            homeLinkLabel.Size = new Size(92, 27);
            homeLinkLabel.TabIndex = 5;
            homeLinkLabel.TabStop = true;
            homeLinkLabel.Text = "我的主页";
            homeLinkLabel.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            homeLinkLabel.LinkClicked += homeLinkLabel_LinkClicked;
            // 
            // objLinkLabel
            // 
            objLinkLabel.ActiveLinkColor = Color.CornflowerBlue;
            objLinkLabel.AutoSize = true;
            objLinkLabel.BackColor = Color.White;
            objLinkLabel.DisabledLinkColor = Color.White;
            objLinkLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            objLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            objLinkLabel.LinkColor = Color.Black;
            objLinkLabel.Location = new Point(101, 378);
            objLinkLabel.Name = "objLinkLabel";
            objLinkLabel.Size = new Size(92, 27);
            objLinkLabel.TabIndex = 7;
            objLinkLabel.TabStop = true;
            objLinkLabel.Text = "物品管理";
            objLinkLabel.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            objLinkLabel.LinkClicked += objLinkLabel_LinkClicked;
            // 
            // lostLinkLabel
            // 
            lostLinkLabel.ActiveLinkColor = Color.CornflowerBlue;
            lostLinkLabel.AutoSize = true;
            lostLinkLabel.BackColor = Color.White;
            lostLinkLabel.DisabledLinkColor = Color.White;
            lostLinkLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lostLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            lostLinkLabel.LinkColor = Color.Black;
            lostLinkLabel.Location = new Point(101, 638);
            lostLinkLabel.Name = "lostLinkLabel";
            lostLinkLabel.Size = new Size(92, 27);
            lostLinkLabel.TabIndex = 8;
            lostLinkLabel.TabStop = true;
            lostLinkLabel.Text = "丢失处理";
            lostLinkLabel.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            lostLinkLabel.LinkClicked += lostLinkLabel_LinkClicked;
            // 
            // borLinkLabel
            // 
            borLinkLabel.ActiveLinkColor = Color.CornflowerBlue;
            borLinkLabel.AutoSize = true;
            borLinkLabel.BackColor = Color.White;
            borLinkLabel.DisabledLinkColor = Color.White;
            borLinkLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            borLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            borLinkLabel.LinkColor = Color.Black;
            borLinkLabel.Location = new Point(101, 462);
            borLinkLabel.Name = "borLinkLabel";
            borLinkLabel.Size = new Size(92, 27);
            borLinkLabel.TabIndex = 9;
            borLinkLabel.TabStop = true;
            borLinkLabel.Text = "借还处理";
            borLinkLabel.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            borLinkLabel.LinkClicked += borLinkLabel_LinkClicked;
            // 
            // avatar
            // 
            avatar.Location = new Point(101, 58);
            avatar.Name = "avatar";
            avatar.Size = new Size(92, 92);
            avatar.TabIndex = 10;
            avatar.TabStop = false;
            avatar.MouseDoubleClick += avatar_MouseDoubleClick;
            avatar.MouseLeave += avatar_MouseLeave;
            avatar.MouseHover += avatar_MouseHover;
            // 
            // objAddBtn
            // 
            objAddBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            objAddBtn.Location = new Point(734, 12);
            objAddBtn.Name = "objAddBtn";
            objAddBtn.Size = new Size(135, 44);
            objAddBtn.TabIndex = 11;
            objAddBtn.Text = "添加物品";
            objAddBtn.UseVisualStyleBackColor = true;
            objAddBtn.Visible = false;
            objAddBtn.Click += objAddBtn_Click;
            // 
            // objEditBtn
            // 
            objEditBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            objEditBtn.Location = new Point(911, 13);
            objEditBtn.Name = "objEditBtn";
            objEditBtn.Size = new Size(135, 44);
            objEditBtn.TabIndex = 13;
            objEditBtn.Text = "编辑物品";
            objEditBtn.UseVisualStyleBackColor = true;
            objEditBtn.Visible = false;
            objEditBtn.Click += objEditBtn_Click;
            // 
            // welcomeIdentity
            // 
            welcomeIdentity.AutoSize = true;
            welcomeIdentity.BackColor = Color.White;
            welcomeIdentity.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeIdentity.Location = new Point(110, 211);
            welcomeIdentity.Name = "welcomeIdentity";
            welcomeIdentity.Size = new Size(72, 23);
            welcomeIdentity.TabIndex = 14;
            welcomeIdentity.Text = "identity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(161, 151);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 16;
            label1.Text = "双击修改头像";
            label1.Visible = false;
            // 
            // myLostDataListView
            // 
            myLostDataListView.Columns.AddRange(new ColumnHeader[] { columnHeader14, columnHeader15, columnHeader16 });
            myLostDataListView.Location = new Point(720, 537);
            myLostDataListView.Name = "myLostDataListView";
            myLostDataListView.Size = new Size(360, 239);
            myLostDataListView.TabIndex = 18;
            myLostDataListView.UseCompatibleStateImageBehavior = false;
            myLostDataListView.View = View.Details;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "物品名";
            columnHeader14.Width = 110;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "借用人";
            columnHeader15.Width = 110;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "丢失天数";
            columnHeader16.Width = 120;
            // 
            // myBorDataListView
            // 
            myBorDataListView.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader12, columnHeader13 });
            myBorDataListView.Location = new Point(720, 114);
            myBorDataListView.Name = "myBorDataListView";
            myBorDataListView.Size = new Size(360, 316);
            myBorDataListView.TabIndex = 22;
            myBorDataListView.UseCompatibleStateImageBehavior = false;
            myBorDataListView.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "物品名";
            columnHeader11.Width = 110;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "所属人";
            columnHeader12.Width = 110;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "归还时间";
            columnHeader13.Width = 120;
            // 
            // myObjDataListView
            // 
            myObjDataListView.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10 });
            myObjDataListView.FullRowSelect = true;
            myObjDataListView.Location = new Point(328, 114);
            myObjDataListView.Name = "myObjDataListView";
            myObjDataListView.Size = new Size(360, 662);
            myObjDataListView.TabIndex = 23;
            myObjDataListView.UseCompatibleStateImageBehavior = false;
            myObjDataListView.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "物品名";
            columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "借用人";
            columnHeader9.Width = 110;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "物品状态";
            columnHeader10.Width = 120;
            // 
            // myObjInfoLabel
            // 
            myObjInfoLabel.AutoSize = true;
            myObjInfoLabel.BackColor = Color.White;
            myObjInfoLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            myObjInfoLabel.Location = new Point(338, 21);
            myObjInfoLabel.Name = "myObjInfoLabel";
            myObjInfoLabel.Size = new Size(92, 27);
            myObjInfoLabel.TabIndex = 24;
            myObjInfoLabel.Text = "我的物品";
            // 
            // myBorInfoLabel
            // 
            myBorInfoLabel.AutoSize = true;
            myBorInfoLabel.BackColor = Color.White;
            myBorInfoLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            myBorInfoLabel.Location = new Point(734, 21);
            myBorInfoLabel.Name = "myBorInfoLabel";
            myBorInfoLabel.Size = new Size(92, 27);
            myBorInfoLabel.TabIndex = 25;
            myBorInfoLabel.Text = "我的借用";
            // 
            // myObjInfoListView
            // 
            myObjInfoListView.Location = new Point(328, 12);
            myObjInfoListView.Name = "myObjInfoListView";
            myObjInfoListView.Size = new Size(360, 95);
            myObjInfoListView.TabIndex = 26;
            myObjInfoListView.UseCompatibleStateImageBehavior = false;
            // 
            // myObjCountLabel
            // 
            myObjCountLabel.AutoSize = true;
            myObjCountLabel.BackColor = Color.White;
            myObjCountLabel.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            myObjCountLabel.Location = new Point(468, 46);
            myObjCountLabel.Name = "myObjCountLabel";
            myObjCountLabel.Size = new Size(82, 32);
            myObjCountLabel.TabIndex = 27;
            myObjCountLabel.Text = "count";
            // 
            // myBorInfoListView
            // 
            myBorInfoListView.Location = new Point(720, 12);
            myBorInfoListView.Name = "myBorInfoListView";
            myBorInfoListView.Size = new Size(360, 95);
            myBorInfoListView.TabIndex = 28;
            myBorInfoListView.UseCompatibleStateImageBehavior = false;
            // 
            // myBorCountLabel
            // 
            myBorCountLabel.AutoSize = true;
            myBorCountLabel.BackColor = Color.White;
            myBorCountLabel.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            myBorCountLabel.Location = new Point(871, 46);
            myBorCountLabel.Name = "myBorCountLabel";
            myBorCountLabel.Size = new Size(82, 32);
            myBorCountLabel.TabIndex = 29;
            myBorCountLabel.Text = "count";
            // 
            // myLostInfoListView
            // 
            myLostInfoListView.Location = new Point(719, 436);
            myLostInfoListView.Name = "myLostInfoListView";
            myLostInfoListView.Size = new Size(360, 95);
            myLostInfoListView.TabIndex = 30;
            myLostInfoListView.UseCompatibleStateImageBehavior = false;
            // 
            // myLostInfoLabel
            // 
            myLostInfoLabel.AutoSize = true;
            myLostInfoLabel.BackColor = Color.White;
            myLostInfoLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            myLostInfoLabel.Location = new Point(734, 448);
            myLostInfoLabel.Name = "myLostInfoLabel";
            myLostInfoLabel.Size = new Size(92, 27);
            myLostInfoLabel.TabIndex = 31;
            myLostInfoLabel.Text = "疑似丢失";
            // 
            // myLostCountLabel
            // 
            myLostCountLabel.AutoSize = true;
            myLostCountLabel.BackColor = Color.White;
            myLostCountLabel.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            myLostCountLabel.Location = new Point(870, 473);
            myLostCountLabel.Name = "myLostCountLabel";
            myLostCountLabel.Size = new Size(82, 32);
            myLostCountLabel.TabIndex = 32;
            myLostCountLabel.Text = "count";
            // 
            // myObjMore
            // 
            myObjMore.ActiveLinkColor = Color.CornflowerBlue;
            myObjMore.AutoSize = true;
            myObjMore.BackColor = Color.White;
            myObjMore.DisabledLinkColor = Color.White;
            myObjMore.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            myObjMore.LinkBehavior = LinkBehavior.NeverUnderline;
            myObjMore.LinkColor = Color.Black;
            myObjMore.Location = new Point(633, 13);
            myObjMore.Name = "myObjMore";
            myObjMore.Size = new Size(54, 20);
            myObjMore.TabIndex = 33;
            myObjMore.TabStop = true;
            myObjMore.Text = "MORE";
            myObjMore.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            myObjMore.LinkClicked += myObjMore_LinkClicked;
            // 
            // myLostMore
            // 
            myLostMore.ActiveLinkColor = Color.CornflowerBlue;
            myLostMore.AutoSize = true;
            myLostMore.BackColor = Color.White;
            myLostMore.DisabledLinkColor = Color.White;
            myLostMore.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            myLostMore.LinkBehavior = LinkBehavior.NeverUnderline;
            myLostMore.LinkColor = Color.Black;
            myLostMore.Location = new Point(1024, 437);
            myLostMore.Name = "myLostMore";
            myLostMore.Size = new Size(54, 20);
            myLostMore.TabIndex = 34;
            myLostMore.TabStop = true;
            myLostMore.Text = "MORE";
            myLostMore.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            myLostMore.LinkClicked += myLostMore_LinkClicked;
            // 
            // myBorMore
            // 
            myBorMore.ActiveLinkColor = Color.CornflowerBlue;
            myBorMore.AutoSize = true;
            myBorMore.BackColor = Color.White;
            myBorMore.DisabledLinkColor = Color.White;
            myBorMore.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            myBorMore.LinkBehavior = LinkBehavior.NeverUnderline;
            myBorMore.LinkColor = Color.Black;
            myBorMore.Location = new Point(1025, 13);
            myBorMore.Name = "myBorMore";
            myBorMore.Size = new Size(54, 20);
            myBorMore.TabIndex = 35;
            myBorMore.TabStop = true;
            myBorMore.Text = "MORE";
            myBorMore.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            myBorMore.LinkClicked += myBorMore_LinkClicked;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(841, 779);
            timeLabel.Name = "timeLabel";
            timeLabel.RightToLeft = RightToLeft.Yes;
            timeLabel.Size = new Size(45, 20);
            timeLabel.TabIndex = 36;
            timeLabel.Text = "Time";
            // 
            // objDelBtn
            // 
            objDelBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            objDelBtn.Location = new Point(734, 63);
            objDelBtn.Name = "objDelBtn";
            objDelBtn.Size = new Size(312, 44);
            objDelBtn.TabIndex = 38;
            objDelBtn.Text = "删除物品";
            objDelBtn.UseVisualStyleBackColor = true;
            objDelBtn.Visible = false;
            objDelBtn.Click += objDelBtn_Click;
            // 
            // objNameQueryTextBox
            // 
            objNameQueryTextBox.Location = new Point(328, 13);
            objNameQueryTextBox.Name = "objNameQueryTextBox";
            objNameQueryTextBox.Size = new Size(197, 27);
            objNameQueryTextBox.TabIndex = 39;
            objNameQueryTextBox.Visible = false;
            // 
            // objCategoryQueryComboBox
            // 
            objCategoryQueryComboBox.FormattingEnabled = true;
            objCategoryQueryComboBox.Items.AddRange(new object[] { "书", "体育用品", "工具", "电子产品", "乐器", "小玩意", "其他" });
            objCategoryQueryComboBox.Location = new Point(328, 79);
            objCategoryQueryComboBox.Name = "objCategoryQueryComboBox";
            objCategoryQueryComboBox.Size = new Size(197, 28);
            objCategoryQueryComboBox.TabIndex = 40;
            objCategoryQueryComboBox.Visible = false;
            // 
            // objNameQueryBtn
            // 
            objNameQueryBtn.Location = new Point(573, 11);
            objNameQueryBtn.Name = "objNameQueryBtn";
            objNameQueryBtn.Size = new Size(115, 29);
            objNameQueryBtn.TabIndex = 41;
            objNameQueryBtn.Text = "按名称查询";
            objNameQueryBtn.UseVisualStyleBackColor = true;
            objNameQueryBtn.Visible = false;
            objNameQueryBtn.Click += objQueryBtn_Click;
            // 
            // objCategoryQueryBtn
            // 
            objCategoryQueryBtn.Location = new Point(573, 79);
            objCategoryQueryBtn.Name = "objCategoryQueryBtn";
            objCategoryQueryBtn.Size = new Size(115, 29);
            objCategoryQueryBtn.TabIndex = 42;
            objCategoryQueryBtn.Text = "按种类查询";
            objCategoryQueryBtn.UseVisualStyleBackColor = true;
            objCategoryQueryBtn.Visible = false;
            objCategoryQueryBtn.Click += objQueryBtn_Click;
            // 
            // objNameClear
            // 
            objNameClear.ActiveLinkColor = Color.CornflowerBlue;
            objNameClear.AutoSize = true;
            objNameClear.BackColor = SystemColors.Control;
            objNameClear.DisabledLinkColor = SystemColors.Control;
            objNameClear.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            objNameClear.LinkBehavior = LinkBehavior.NeverUnderline;
            objNameClear.LinkColor = Color.Black;
            objNameClear.Location = new Point(525, 16);
            objNameClear.Name = "objNameClear";
            objNameClear.Size = new Size(19, 20);
            objNameClear.TabIndex = 43;
            objNameClear.TabStop = true;
            objNameClear.Text = "×";
            objNameClear.Visible = false;
            objNameClear.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            objNameClear.LinkClicked += objNameClear_LinkClicked;
            // 
            // objCategoryClear
            // 
            objCategoryClear.ActiveLinkColor = Color.CornflowerBlue;
            objCategoryClear.AutoSize = true;
            objCategoryClear.BackColor = SystemColors.Control;
            objCategoryClear.DisabledLinkColor = SystemColors.Control;
            objCategoryClear.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            objCategoryClear.LinkBehavior = LinkBehavior.NeverUnderline;
            objCategoryClear.LinkColor = Color.Black;
            objCategoryClear.Location = new Point(525, 83);
            objCategoryClear.Name = "objCategoryClear";
            objCategoryClear.Size = new Size(19, 20);
            objCategoryClear.TabIndex = 44;
            objCategoryClear.TabStop = true;
            objCategoryClear.Text = "×";
            objCategoryClear.Visible = false;
            objCategoryClear.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            objCategoryClear.LinkClicked += objCategoryClear_LinkClicked;
            // 
            // exitLinkLabel
            // 
            exitLinkLabel.ActiveLinkColor = Color.CornflowerBlue;
            exitLinkLabel.AutoSize = true;
            exitLinkLabel.BackColor = Color.White;
            exitLinkLabel.DisabledLinkColor = Color.White;
            exitLinkLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            exitLinkLabel.LinkColor = Color.Black;
            exitLinkLabel.Location = new Point(101, 731);
            exitLinkLabel.Name = "exitLinkLabel";
            exitLinkLabel.Size = new Size(92, 27);
            exitLinkLabel.TabIndex = 45;
            exitLinkLabel.TabStop = true;
            exitLinkLabel.Text = "退出登录";
            exitLinkLabel.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            exitLinkLabel.LinkClicked += exitLinkLabel_LinkClicked;
            // 
            // borProBorBtn
            // 
            borProBorBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            borProBorBtn.Location = new Point(864, 406);
            borProBorBtn.Name = "borProBorBtn";
            borProBorBtn.Size = new Size(126, 48);
            borProBorBtn.TabIndex = 55;
            borProBorBtn.Text = "我想续借";
            borProBorBtn.UseVisualStyleBackColor = true;
            borProBorBtn.Visible = false;
            borProBorBtn.Click += borProBorBtn_Click;
            // 
            // borReListView
            // 
            borReListView.Columns.AddRange(new ColumnHeader[] { columnHeader17, columnHeader18, columnHeader19, columnHeader20, columnHeader21, columnHeader22, columnHeader23 });
            borReListView.FullRowSelect = true;
            borReListView.Location = new Point(328, 473);
            borReListView.Name = "borReListView";
            borReListView.Size = new Size(752, 303);
            borReListView.TabIndex = 54;
            borReListView.UseCompatibleStateImageBehavior = false;
            borReListView.View = View.Details;
            borReListView.Visible = false;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "BId";
            columnHeader17.Width = 0;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "OId";
            columnHeader18.Width = 0;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "物品名";
            columnHeader19.Width = 120;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "所属人";
            columnHeader20.Width = 120;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "最长借用时间";
            columnHeader21.Width = 160;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "剩余借用时间";
            columnHeader22.Width = 160;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "归还时间";
            columnHeader23.Width = 160;
            // 
            // borBorBtn
            // 
            borBorBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            borBorBtn.Location = new Point(827, 12);
            borBorBtn.Name = "borBorBtn";
            borBorBtn.Size = new Size(192, 93);
            borBorBtn.TabIndex = 53;
            borBorBtn.Text = "我想借物";
            borBorBtn.UseVisualStyleBackColor = true;
            borBorBtn.Visible = false;
            borBorBtn.Click += borBorBtn_Click;
            // 
            // borReBtn
            // 
            borReBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            borReBtn.Location = new Point(418, 406);
            borReBtn.Name = "borReBtn";
            borReBtn.Size = new Size(126, 48);
            borReBtn.TabIndex = 52;
            borReBtn.Text = "我想还物";
            borReBtn.UseVisualStyleBackColor = true;
            borReBtn.Visible = false;
            borReBtn.Click += borReBtn_Click;
            // 
            // borObjListView
            // 
            borObjListView.Columns.AddRange(new ColumnHeader[] { columnHeader24, columnHeader25, columnHeader26, columnHeader27, columnHeader28, columnHeader29 });
            borObjListView.FullRowSelect = true;
            borObjListView.Location = new Point(328, 114);
            borObjListView.Name = "borObjListView";
            borObjListView.Size = new Size(752, 272);
            borObjListView.SmallImageList = borImageList;
            borObjListView.TabIndex = 56;
            borObjListView.UseCompatibleStateImageBehavior = false;
            borObjListView.View = View.Details;
            borObjListView.Visible = false;
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "物品图片";
            columnHeader24.Width = 95;
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "物品名";
            columnHeader25.Width = 150;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "物品种类";
            columnHeader26.Width = 160;
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "最长借用时间";
            columnHeader27.Width = 160;
            // 
            // columnHeader28
            // 
            columnHeader28.Text = "归还日期";
            columnHeader28.Width = 160;
            // 
            // columnHeader29
            // 
            columnHeader29.Text = "OId";
            columnHeader29.Width = 0;
            // 
            // borImageList
            // 
            borImageList.ColorDepth = ColorDepth.Depth8Bit;
            borImageList.ImageSize = new Size(90, 90);
            borImageList.TransparentColor = Color.Transparent;
            // 
            // borObjCategoryClear
            // 
            borObjCategoryClear.ActiveLinkColor = Color.CornflowerBlue;
            borObjCategoryClear.AutoSize = true;
            borObjCategoryClear.BackColor = SystemColors.Control;
            borObjCategoryClear.DisabledLinkColor = SystemColors.Control;
            borObjCategoryClear.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            borObjCategoryClear.LinkBehavior = LinkBehavior.NeverUnderline;
            borObjCategoryClear.LinkColor = Color.Black;
            borObjCategoryClear.Location = new Point(525, 83);
            borObjCategoryClear.Name = "borObjCategoryClear";
            borObjCategoryClear.Size = new Size(19, 20);
            borObjCategoryClear.TabIndex = 62;
            borObjCategoryClear.TabStop = true;
            borObjCategoryClear.Text = "×";
            borObjCategoryClear.Visible = false;
            borObjCategoryClear.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            borObjCategoryClear.LinkClicked += borObjCategoryClear_LinkClicked;
            // 
            // borObjNameClear
            // 
            borObjNameClear.ActiveLinkColor = Color.CornflowerBlue;
            borObjNameClear.AutoSize = true;
            borObjNameClear.BackColor = SystemColors.Control;
            borObjNameClear.DisabledLinkColor = SystemColors.Control;
            borObjNameClear.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            borObjNameClear.LinkBehavior = LinkBehavior.NeverUnderline;
            borObjNameClear.LinkColor = Color.Black;
            borObjNameClear.Location = new Point(525, 16);
            borObjNameClear.Name = "borObjNameClear";
            borObjNameClear.Size = new Size(19, 20);
            borObjNameClear.TabIndex = 61;
            borObjNameClear.TabStop = true;
            borObjNameClear.Text = "×";
            borObjNameClear.Visible = false;
            borObjNameClear.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            borObjNameClear.LinkClicked += borObjNameClear_LinkClicked;
            // 
            // borObjCategoryQueryBtn
            // 
            borObjCategoryQueryBtn.Location = new Point(573, 79);
            borObjCategoryQueryBtn.Name = "borObjCategoryQueryBtn";
            borObjCategoryQueryBtn.Size = new Size(115, 29);
            borObjCategoryQueryBtn.TabIndex = 60;
            borObjCategoryQueryBtn.Text = "按种类查询";
            borObjCategoryQueryBtn.UseVisualStyleBackColor = true;
            borObjCategoryQueryBtn.Visible = false;
            borObjCategoryQueryBtn.Click += borObjQueryBtn_Click;
            // 
            // borObjNameQueryBtn
            // 
            borObjNameQueryBtn.Location = new Point(573, 11);
            borObjNameQueryBtn.Name = "borObjNameQueryBtn";
            borObjNameQueryBtn.Size = new Size(115, 29);
            borObjNameQueryBtn.TabIndex = 59;
            borObjNameQueryBtn.Text = "按名称查询";
            borObjNameQueryBtn.UseVisualStyleBackColor = true;
            borObjNameQueryBtn.Visible = false;
            borObjNameQueryBtn.Click += borObjQueryBtn_Click;
            // 
            // borObjCategoryQueryComboBox
            // 
            borObjCategoryQueryComboBox.FormattingEnabled = true;
            borObjCategoryQueryComboBox.Items.AddRange(new object[] { "书", "体育用品", "工具", "电子产品", "乐器", "小玩意", "其他" });
            borObjCategoryQueryComboBox.Location = new Point(328, 79);
            borObjCategoryQueryComboBox.Name = "borObjCategoryQueryComboBox";
            borObjCategoryQueryComboBox.Size = new Size(197, 28);
            borObjCategoryQueryComboBox.TabIndex = 58;
            borObjCategoryQueryComboBox.Visible = false;
            // 
            // borObjNameQueryTextBox
            // 
            borObjNameQueryTextBox.Location = new Point(328, 13);
            borObjNameQueryTextBox.Name = "borObjNameQueryTextBox";
            borObjNameQueryTextBox.Size = new Size(197, 27);
            borObjNameQueryTextBox.TabIndex = 57;
            borObjNameQueryTextBox.Visible = false;
            // 
            // lostKickOffBtn
            // 
            lostKickOffBtn.FlatStyle = FlatStyle.Flat;
            lostKickOffBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lostKickOffBtn.Location = new Point(786, 713);
            lostKickOffBtn.Name = "lostKickOffBtn";
            lostKickOffBtn.Size = new Size(214, 63);
            lostKickOffBtn.TabIndex = 67;
            lostKickOffBtn.Text = "踢出社团";
            lostKickOffBtn.UseVisualStyleBackColor = true;
            lostKickOffBtn.Visible = false;
            lostKickOffBtn.Click += lostKickOffBtn_Click;
            // 
            // LostWarnAndDepriveBtn
            // 
            LostWarnAndDepriveBtn.BackColor = SystemColors.Control;
            LostWarnAndDepriveBtn.FlatStyle = FlatStyle.Flat;
            LostWarnAndDepriveBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LostWarnAndDepriveBtn.Location = new Point(786, 561);
            LostWarnAndDepriveBtn.Name = "LostWarnAndDepriveBtn";
            LostWarnAndDepriveBtn.Size = new Size(214, 63);
            LostWarnAndDepriveBtn.TabIndex = 66;
            LostWarnAndDepriveBtn.Text = "警告并取消借物资格";
            LostWarnAndDepriveBtn.UseVisualStyleBackColor = false;
            LostWarnAndDepriveBtn.Visible = false;
            LostWarnAndDepriveBtn.Click += LostWarnAndDepriveBtn_Click;
            // 
            // lostWarnBtn
            // 
            lostWarnBtn.FlatStyle = FlatStyle.Flat;
            lostWarnBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lostWarnBtn.Location = new Point(786, 406);
            lostWarnBtn.Name = "lostWarnBtn";
            lostWarnBtn.Size = new Size(214, 63);
            lostWarnBtn.TabIndex = 65;
            lostWarnBtn.Text = "发出警告";
            lostWarnBtn.UseVisualStyleBackColor = true;
            lostWarnBtn.Visible = false;
            lostWarnBtn.Click += lostWarnBtn_Click;
            // 
            // lostUserListView
            // 
            lostUserListView.Columns.AddRange(new ColumnHeader[] { columnHeader38, columnHeader30, columnHeader31, columnHeader39 });
            lostUserListView.FullRowSelect = true;
            lostUserListView.Location = new Point(388, 406);
            lostUserListView.Name = "lostUserListView";
            lostUserListView.Size = new Size(314, 370);
            lostUserListView.TabIndex = 64;
            lostUserListView.UseCompatibleStateImageBehavior = false;
            lostUserListView.View = View.Details;
            lostUserListView.Visible = false;
            // 
            // columnHeader38
            // 
            columnHeader38.Text = "UId";
            columnHeader38.Width = 0;
            // 
            // columnHeader30
            // 
            columnHeader30.Text = "用户名";
            columnHeader30.TextAlign = HorizontalAlignment.Center;
            columnHeader30.Width = 100;
            // 
            // columnHeader31
            // 
            columnHeader31.Text = "丢失物品数";
            columnHeader31.TextAlign = HorizontalAlignment.Center;
            columnHeader31.Width = 90;
            // 
            // columnHeader39
            // 
            columnHeader39.Text = "信用";
            columnHeader39.TextAlign = HorizontalAlignment.Center;
            columnHeader39.Width = 100;
            // 
            // lostListView
            // 
            lostListView.Columns.AddRange(new ColumnHeader[] { columnHeader32, columnHeader33, columnHeader34, columnHeader35, columnHeader36, columnHeader37 });
            lostListView.Location = new Point(328, 12);
            lostListView.Name = "lostListView";
            lostListView.Size = new Size(752, 348);
            lostListView.SmallImageList = lostImageList;
            lostListView.TabIndex = 63;
            lostListView.UseCompatibleStateImageBehavior = false;
            lostListView.View = View.Details;
            lostListView.Visible = false;
            // 
            // columnHeader32
            // 
            columnHeader32.Text = "物品图片";
            columnHeader32.Width = 95;
            // 
            // columnHeader33
            // 
            columnHeader33.Text = "物品名称";
            columnHeader33.Width = 130;
            // 
            // columnHeader34
            // 
            columnHeader34.Text = "物品种类";
            columnHeader34.Width = 130;
            // 
            // columnHeader35
            // 
            columnHeader35.Text = "超出时间";
            columnHeader35.Width = 120;
            // 
            // columnHeader36
            // 
            columnHeader36.Text = "所属人";
            columnHeader36.Width = 125;
            // 
            // columnHeader37
            // 
            columnHeader37.Text = "借用人";
            columnHeader37.Width = 125;
            // 
            // lostImageList
            // 
            lostImageList.ColorDepth = ColorDepth.Depth8Bit;
            lostImageList.ImageSize = new Size(90, 90);
            lostImageList.TransparentColor = Color.Transparent;
            // 
            // applyLinkLabel
            // 
            applyLinkLabel.ActiveLinkColor = Color.CornflowerBlue;
            applyLinkLabel.AutoSize = true;
            applyLinkLabel.BackColor = Color.White;
            applyLinkLabel.DisabledLinkColor = Color.White;
            applyLinkLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            applyLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            applyLinkLabel.LinkColor = Color.Black;
            applyLinkLabel.Location = new Point(101, 552);
            applyLinkLabel.Name = "applyLinkLabel";
            applyLinkLabel.Size = new Size(92, 27);
            applyLinkLabel.TabIndex = 68;
            applyLinkLabel.TabStop = true;
            applyLinkLabel.Text = "借还申请";
            applyLinkLabel.VisitedLinkColor = Color.FromArgb(224, 224, 224);
            applyLinkLabel.LinkClicked += applyLinkLabel_LinkClicked;
            // 
            // applyRejectBtn
            // 
            applyRejectBtn.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            applyRejectBtn.Location = new Point(853, 55);
            applyRejectBtn.Name = "applyRejectBtn";
            applyRejectBtn.Size = new Size(128, 54);
            applyRejectBtn.TabIndex = 71;
            applyRejectBtn.Text = "拒绝借用";
            applyRejectBtn.UseVisualStyleBackColor = true;
            applyRejectBtn.Visible = false;
            applyRejectBtn.Click += applyRejectBtn_Click;
            // 
            // applyAgreeBtn
            // 
            applyAgreeBtn.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            applyAgreeBtn.Location = new Point(430, 55);
            applyAgreeBtn.Name = "applyAgreeBtn";
            applyAgreeBtn.Size = new Size(128, 54);
            applyAgreeBtn.TabIndex = 70;
            applyAgreeBtn.Text = "同意借用";
            applyAgreeBtn.UseVisualStyleBackColor = true;
            applyAgreeBtn.Visible = false;
            applyAgreeBtn.Click += applyAgreeBtn_Click;
            // 
            // applyListView
            // 
            applyListView.Columns.AddRange(new ColumnHeader[] { columnHeader40, columnHeader41, columnHeader42, columnHeader43, columnHeader44, columnHeader45, columnHeader46 });
            applyListView.FullRowSelect = true;
            applyListView.Location = new Point(329, 150);
            applyListView.Name = "applyListView";
            applyListView.Size = new Size(751, 626);
            applyListView.TabIndex = 69;
            applyListView.UseCompatibleStateImageBehavior = false;
            applyListView.View = View.Details;
            applyListView.Visible = false;
            // 
            // columnHeader40
            // 
            columnHeader40.Text = "物品名";
            columnHeader40.Width = 140;
            // 
            // columnHeader41
            // 
            columnHeader41.Text = "借用人";
            columnHeader41.Width = 140;
            // 
            // columnHeader42
            // 
            columnHeader42.Text = "归还日期";
            columnHeader42.Width = 140;
            // 
            // columnHeader43
            // 
            columnHeader43.Text = "用户信用";
            columnHeader43.Width = 150;
            // 
            // columnHeader44
            // 
            columnHeader44.Text = "oid";
            columnHeader44.Width = 0;
            // 
            // columnHeader45
            // 
            columnHeader45.Text = "bid";
            columnHeader45.Width = 0;
            // 
            // columnHeader46
            // 
            columnHeader46.Text = "申请状态";
            columnHeader46.Width = 150;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 833);
            Controls.Add(applyLinkLabel);
            Controls.Add(exitLinkLabel);
            Controls.Add(timeLabel);
            Controls.Add(label1);
            Controls.Add(welcomeIdentity);
            Controls.Add(avatar);
            Controls.Add(borLinkLabel);
            Controls.Add(lostLinkLabel);
            Controls.Add(objLinkLabel);
            Controls.Add(homeLinkLabel);
            Controls.Add(welcomeuname);
            Controls.Add(listView1);
            Controls.Add(myObjMore);
            Controls.Add(myObjCountLabel);
            Controls.Add(myObjInfoLabel);
            Controls.Add(myObjInfoListView);
            Controls.Add(myBorMore);
            Controls.Add(myBorInfoLabel);
            Controls.Add(myBorCountLabel);
            Controls.Add(myBorInfoListView);
            Controls.Add(myLostMore);
            Controls.Add(myLostCountLabel);
            Controls.Add(myLostInfoLabel);
            Controls.Add(myLostInfoListView);
            Controls.Add(myLostDataListView);
            Controls.Add(myObjDataListView);
            Controls.Add(myBorDataListView);
            Controls.Add(objCategoryClear);
            Controls.Add(objNameClear);
            Controls.Add(objCategoryQueryBtn);
            Controls.Add(objNameQueryBtn);
            Controls.Add(objCategoryQueryComboBox);
            Controls.Add(objNameQueryTextBox);
            Controls.Add(objAddBtn);
            Controls.Add(objDelBtn);
            Controls.Add(objEditBtn);
            Controls.Add(borBorBtn);
            Controls.Add(borReBtn);
            Controls.Add(borObjCategoryClear);
            Controls.Add(borObjNameClear);
            Controls.Add(borObjCategoryQueryBtn);
            Controls.Add(borObjNameQueryBtn);
            Controls.Add(borObjCategoryQueryComboBox);
            Controls.Add(borObjNameQueryTextBox);
            Controls.Add(lostKickOffBtn);
            Controls.Add(LostWarnAndDepriveBtn);
            Controls.Add(lostUserListView);
            Controls.Add(lostWarnBtn);
            Controls.Add(borProBorBtn);
            Controls.Add(applyRejectBtn);
            Controls.Add(applyAgreeBtn);
            Controls.Add(borObjListView);
            Controls.Add(objListView);
            Controls.Add(lostListView);
            Controls.Add(borReListView);
            Controls.Add(applyListView);
            Name = "FrmMain";
            RightToLeftLayout = true;
            Text = "首页";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeuname;
        private ListView objListView;
        private ListView listView1;
        private LinkLabel homeLinkLabel;
        private LinkLabel objLinkLabel;
        private LinkLabel lostLinkLabel;
        private LinkLabel borLinkLabel;
        private PictureBox avatar;
        private Button objAddBtn;
        private Button objEditBtn;
        private Label welcomeIdentity;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label1;
        private ColumnHeader columnHeader7;
        private ListView myLostDataListView;
        private ListView myBorDataListView;
        private ListView myObjDataListView;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader9;
        private Label myObjInfoLabel;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private Label myBorInfoLabel;
        private ListView myObjInfoListView;
        private Label myObjCountLabel;
        private ListView myBorInfoListView;
        private Label myBorCountLabel;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ListView myLostInfoListView;
        private Label myLostInfoLabel;
        private Label myLostCountLabel;
        private LinkLabel myObjMore;
        private LinkLabel myLostMore;
        private LinkLabel myBorMore;
        private System.Windows.Forms.Timer timer;
        private Label timeLabel;
        private Button objDelBtn;
        private TextBox objNameQueryTextBox;
        private ComboBox objCategoryQueryComboBox;
        private Button objNameQueryBtn;
        private Button objCategoryQueryBtn;
        private LinkLabel objNameClear;
        private LinkLabel objCategoryClear;
        private LinkLabel exitLinkLabel;
        private Button borProBorBtn;
        private ListView borReListView;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private Button borBorBtn;
        private Button borReBtn;
        private ListView borObjListView;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader26;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader28;
        private ColumnHeader columnHeader29;
        private ImageList borImageList;
        private ImageList objImageList;
        private LinkLabel borObjCategoryClear;
        private LinkLabel borObjNameClear;
        private Button borObjCategoryQueryBtn;
        private Button borObjNameQueryBtn;
        private ComboBox borObjCategoryQueryComboBox;
        private TextBox borObjNameQueryTextBox;
        private Button lostKickOffBtn;
        private Button LostWarnAndDepriveBtn;
        private Button lostWarnBtn;
        private ListView lostUserListView;
        private ColumnHeader columnHeader30;
        private ColumnHeader columnHeader31;
        private ListView lostListView;
        private ColumnHeader columnHeader32;
        private ColumnHeader columnHeader33;
        private ColumnHeader columnHeader34;
        private ColumnHeader columnHeader35;
        private ColumnHeader columnHeader36;
        private ColumnHeader columnHeader37;
        private ImageList lostImageList;
        private ColumnHeader columnHeader38;
        private ColumnHeader columnHeader39;
        private LinkLabel applyLinkLabel;
        private Button applyRejectBtn;
        private Button applyAgreeBtn;
        private ListView applyListView;
        private ColumnHeader columnHeader40;
        private ColumnHeader columnHeader41;
        private ColumnHeader columnHeader42;
        private ColumnHeader columnHeader43;
        private ColumnHeader columnHeader44;
        private ColumnHeader columnHeader45;
        private ColumnHeader columnHeader46;
    }
}