using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class RegFrom : Form
    {
        public RegFrom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string pwd = textBox2.Text;
            string rePwd = textBox3.Text;
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            else if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            else if (!rePwd.Equals(pwd))
            {
                MessageBox.Show("两次输入密码不一样！");
                return;
            }

            //将注册信息显示到user界面
            userForm userForm = new userForm(userName, pwd);
            userForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
