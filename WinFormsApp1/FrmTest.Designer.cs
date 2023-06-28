namespace WinFormsApp1
{
    partial class FrmTest
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
            listView1 = new ListView();
            applyListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            applyAgreeBtn = new Button();
            applyRejectBtn = new Button();
            button1 = new Button();
            columnHeader7 = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(214, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(750, 763);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // applyListView
            // 
            applyListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            applyListView.FullRowSelect = true;
            applyListView.Location = new Point(214, 149);
            applyListView.Name = "applyListView";
            applyListView.Size = new Size(750, 626);
            applyListView.TabIndex = 1;
            applyListView.UseCompatibleStateImageBehavior = false;
            applyListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "物品名";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "借用人";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "归还日期";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "用户信用";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "oid";
            columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "bid";
            columnHeader6.Width = 0;
            // 
            // applyAgreeBtn
            // 
            applyAgreeBtn.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            applyAgreeBtn.Location = new Point(315, 53);
            applyAgreeBtn.Name = "applyAgreeBtn";
            applyAgreeBtn.Size = new Size(128, 54);
            applyAgreeBtn.TabIndex = 2;
            applyAgreeBtn.Text = "同意借用";
            applyAgreeBtn.UseVisualStyleBackColor = true;
            applyAgreeBtn.Click += applyAgreeBtn_Click;
            // 
            // applyRejectBtn
            // 
            applyRejectBtn.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            applyRejectBtn.Location = new Point(738, 53);
            applyRejectBtn.Name = "applyRejectBtn";
            applyRejectBtn.Size = new Size(128, 54);
            applyRejectBtn.TabIndex = 3;
            applyRejectBtn.Text = "拒绝借用";
            applyRejectBtn.UseVisualStyleBackColor = true;
            applyRejectBtn.Click += applyRejectBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(87, 141);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "申请状态";
            columnHeader7.Width = 150;
            // 
            // FrmTest
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 805);
            Controls.Add(button1);
            Controls.Add(applyRejectBtn);
            Controls.Add(applyAgreeBtn);
            Controls.Add(applyListView);
            Controls.Add(listView1);
            Name = "FrmTest";
            Text = "FrmTest";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ListView applyListView;
        private Button applyAgreeBtn;
        private Button applyRejectBtn;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}