namespace WinFormsApp1
{
    partial class FrmAddObj
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            tUserBindingSource1 = new BindingSource(components);
            tUserBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tUserBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tUserBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 51);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 0;
            label1.Text = "物品名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(150, 130);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 1;
            label2.Text = "物品种类";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(150, 300);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 2;
            label3.Text = "借用时长";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(150, 390);
            label4.Name = "label4";
            label4.Size = new Size(114, 32);
            label4.TabIndex = 3;
            label4.Text = "物品状态";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(406, 51);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 32);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "书", "体育用品", "工具", "电子产品", "乐器", "小玩意", "其他" });
            comboBox1.Location = new Point(406, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 28);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "书";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "15天", "30天", "45天", "60天", "90天", "120天", "365天" });
            comboBox2.Location = new Point(406, 300);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(222, 28);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "15天";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(354, 390);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 27);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "可借用";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Enabled = false;
            radioButton2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(471, 390);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(99, 27);
            radioButton2.TabIndex = 8;
            radioButton2.Text = "已被借用";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Enabled = false;
            radioButton3.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(588, 390);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(133, 27);
            radioButton3.TabIndex = 9;
            radioButton3.Text = "超出归还日期";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(265, 501);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 10;
            button1.Text = "添加";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(471, 501);
            button2.Name = "button2";
            button2.Size = new Size(94, 42);
            button2.TabIndex = 11;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(150, 215);
            label5.Name = "label5";
            label5.Size = new Size(114, 32);
            label5.TabIndex = 12;
            label5.Text = "物品图片";
            // 
            // button3
            // 
            button3.Location = new Point(406, 215);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "选择图片";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(542, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 78);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // tUserBindingSource1
            // 
            tUserBindingSource1.DataSource = typeof(Models.TUser);
            // 
            // tUserBindingSource
            // 
            tUserBindingSource.DataSource = typeof(Models.TUser);
            // 
            // FrmAddObj
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 578);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddObj";
            Text = "FrmAddObj";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tUserBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tUserBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
        private Button button2;
        private Label label5;
        private Button button3;
        private PictureBox pictureBox1;
        private BindingSource tUserBindingSource1;
        private BindingSource tUserBindingSource;
    }
}