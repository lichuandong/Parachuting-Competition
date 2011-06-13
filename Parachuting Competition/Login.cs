using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parachuting_Competition.control;

namespace Parachuting_Competition
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        //登陆按钮点击事件
        private void button_login_Click(object sender, EventArgs e)
        {
            control.UserEntity cuser = new UserEntity();
            cuser.username = textBox_uname.Text;
            cuser.password = textBox_pword.Text;
            Model.User muser = new Model.User();

            if (muser.selectUser(cuser))
            {

                Main main = new Main();
                main.Show();
            }
            else
            {

                MessageBox.Show("用户名，密码错误");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        //修改密码点击事件
        private void button_change_Click(object sender, EventArgs e)
        {
            ChangeInfo change = new ChangeInfo();
            change.Show();
        }
    }
}
