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
    public partial class userForm : Form
    {
        public userForm(string userName,string pwd)
        {
            InitializeComponent();
            label2.Text = "用户名：" + userName;
            label3.Text = "密  码：" + pwd;
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
