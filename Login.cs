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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userStr = textBox1.Text;
            string passwordStr = textBox2.Text;
            if ("18581386296".Equals(userStr) && "123456".Equals(passwordStr))
            {
                DialogResult dr = MessageBox.Show("登陆成功！正在进入用户界面......", "欢迎",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    userForm userForm = new userForm(userStr,passwordStr);
                    userForm.Show();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("登陆失败！请检查用户名和密码是否正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_BackColorChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void label2_BackColorChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            RegFrom regFrom = new RegFrom();
            regFrom.Show();
        }
    }
}
