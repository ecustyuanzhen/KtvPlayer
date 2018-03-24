using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BUS;
namespace FACE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (text_username.Text == "")
            { MessageBox.Show("用户名不能为空！！"); return; }//用户名不能为空
            if (text_password.Text== "")
            { MessageBox.Show("密码不能为空！！"); return; }//密码不能为空
            AdminListService list = new AdminListService();
            int i = list.Validate(text_username.Text.Trim(), text_password.Text.Trim());
            switch (i)
            {
                case 0: ManageForm form = new ManageForm(); form.ShowDialog(); this.Hide(); break;
                case 1: MessageBox.Show("用户不存在！"); break;
                case 2: MessageBox.Show("密码有误！"); break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
