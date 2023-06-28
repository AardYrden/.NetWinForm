using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class FrmLogin : Form
    {
        private NetContext netContext = new NetContext();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string no = textBox1.Text;
            string pwd = textBox2.Text;
            var user = netContext.TUser.Where(o => o.Uno == no && o.Upwd == pwd).FirstOrDefault();
            if (user != null)
            {
                new FrmMain(user).ShowDialog();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或密码错误!", "error");
            }
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            new FrmRegister().Show();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbtn_Click(sender, e);
                textBox2.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }
    }
}