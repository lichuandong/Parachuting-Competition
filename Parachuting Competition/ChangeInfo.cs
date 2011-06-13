using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Parachuting_Competition
{
    public partial class ChangeInfo : Form
    {
        public ChangeInfo()
        {
            InitializeComponent();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            control.UserEntity cuser = new control.UserEntity();
            cuser.username = textBox_uname.Text;
            cuser.password = textBox_pword.Text;

            Model.User muser = new Model.User();
            control.UserEntity beforeUser = muser.findUser();

            if (!cuser.username.Equals(beforeUser.username))
            {

                MessageBox.Show("用户名错误");
                return;
            }

            if (!cuser.password.Equals(beforeUser.password))
            {

                MessageBox.Show("密码错误");
                return;
            }

            if (!textBox_newpword.Text.Equals(textBox_pword_suer.Text))
            {

                MessageBox.Show("新密码与确认密码不一致");
                return;
            }

            control.UserEntity newuser = new control.UserEntity();
            newuser.username = textBox_newuname.Text;
            newuser.password = textBox_newpword.Text;

            if (muser.updateUser(newuser) < 0)
            {

                MessageBox.Show("修改失败");
                return;
            }

            MessageBox.Show("修改成功");

        }

        private void ChangeInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
