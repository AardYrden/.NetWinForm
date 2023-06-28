namespace WinFormsApp1
{
    partial class FrmRegister
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textUNo = new TextBox();
            textUPwd = new TextBox();
            textUName = new TextBox();
            textUTele = new TextBox();
            registerbtn = new Button();
            cancelbtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            label10 = new Label();
            adminText = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(210, 32);
            label1.Name = "label1";
            label1.Size = new Size(64, 32);
            label1.TabIndex = 0;
            label1.Text = "账号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(210, 105);
            label2.Name = "label2";
            label2.Size = new Size(64, 32);
            label2.TabIndex = 1;
            label2.Text = "密码";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(210, 245);
            label3.Name = "label3";
            label3.Size = new Size(64, 32);
            label3.TabIndex = 2;
            label3.Text = "性别";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(210, 314);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 3;
            label4.Text = "生日";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(210, 172);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 4;
            label5.Text = "用户名";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(210, 388);
            label6.Name = "label6";
            label6.Size = new Size(64, 32);
            label6.TabIndex = 5;
            label6.Text = "电话";
            // 
            // textUNo
            // 
            textUNo.ForeColor = Color.Red;
            textUNo.Location = new Point(417, 32);
            textUNo.Multiline = true;
            textUNo.Name = "textUNo";
            textUNo.Size = new Size(226, 32);
            textUNo.TabIndex = 6;
            textUNo.Text = "账号 3 - 10 位";
            textUNo.MouseClick += textUNo_MouseClick;
            textUNo.TextChanged += textUNo_TextChanged;
            textUNo.Leave += textUNo_Leave;
            // 
            // textUPwd
            // 
            textUPwd.ForeColor = Color.Red;
            textUPwd.Location = new Point(417, 105);
            textUPwd.Multiline = true;
            textUPwd.Name = "textUPwd";
            textUPwd.Size = new Size(226, 32);
            textUPwd.TabIndex = 7;
            textUPwd.Text = "密码 3 - 15 位, 包含字母数字";
            textUPwd.MouseClick += textUPwd_MouseClick;
            textUPwd.TextChanged += textUPwd_TextChanged;
            textUPwd.Leave += textUPwd_Leave;
            // 
            // textUName
            // 
            textUName.ForeColor = Color.Red;
            textUName.Location = new Point(417, 172);
            textUName.Multiline = true;
            textUName.Name = "textUName";
            textUName.Size = new Size(226, 32);
            textUName.TabIndex = 8;
            textUName.Text = "用户名 1 - 15 位";
            textUName.MouseClick += textUName_MouseClick;
            textUName.TextChanged += textUName_TextChanged;
            textUName.Leave += textUName_Leave;
            // 
            // textUTele
            // 
            textUTele.Location = new Point(417, 388);
            textUTele.Multiline = true;
            textUTele.Name = "textUTele";
            textUTele.Size = new Size(226, 32);
            textUTele.TabIndex = 9;
            // 
            // registerbtn
            // 
            registerbtn.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            registerbtn.Location = new Point(267, 642);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(94, 43);
            registerbtn.TabIndex = 10;
            registerbtn.Text = "注册";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cancelbtn.Location = new Point(444, 642);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(94, 43);
            cancelbtn.TabIndex = 11;
            cancelbtn.Text = "取消";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(417, 319);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(226, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(417, 245);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(45, 24);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(518, 245);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 24);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(649, 32);
            label7.Name = "label7";
            label7.Size = new Size(16, 20);
            label7.TabIndex = 17;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(649, 105);
            label8.Name = "label8";
            label8.Size = new Size(16, 20);
            label8.TabIndex = 18;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(649, 172);
            label9.Name = "label9";
            label9.Size = new Size(16, 20);
            label9.TabIndex = 19;
            label9.Text = "*";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(557, 450);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 78);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(421, 474);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 21;
            button3.Text = "选择图片";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(210, 474);
            label10.Name = "label10";
            label10.Size = new Size(114, 32);
            label10.TabIndex = 20;
            label10.Text = "选择头像";
            // 
            // adminText
            // 
            adminText.Location = new Point(417, 562);
            adminText.Multiline = true;
            adminText.Name = "adminText";
            adminText.Size = new Size(226, 32);
            adminText.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(210, 562);
            label11.Name = "label11";
            label11.Size = new Size(89, 32);
            label11.TabIndex = 23;
            label11.Text = "内测码";
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 716);
            Controls.Add(adminText);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dateTimePicker1);
            Controls.Add(cancelbtn);
            Controls.Add(registerbtn);
            Controls.Add(textUTele);
            Controls.Add(textUName);
            Controls.Add(textUPwd);
            Controls.Add(textUNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            Text = "请注册";
            Load += FrmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textUNo;
        private TextBox textUPwd;
        private TextBox textUName;
        private TextBox textUTele;
        private Button registerbtn;
        private Button cancelbtn;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label10;
        private TextBox adminText;
        private Label label11;
    }
}