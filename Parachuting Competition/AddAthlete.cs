using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parachuting_Competition.Model;
namespace Parachuting_Competition
{
    public partial class AddAthlete : Form
    {
       string athleteid="";
        public AddAthlete(string id)
        {  
            InitializeComponent();// 系统初始化构件
            athleteid = id;
            if (athleteid != "")
            {
                AthleteInfo ath = new AthleteInfo();
                DataSet ds = ath.findAthletes(athleteid);
                textBox_Number.Text = ds.Tables[0].Rows[0]["number"].ToString();
                textBox_Name.Text = ds.Tables[0].Rows[0]["athname"].ToString();
                textBox_Age.Text = ds.Tables[0].Rows[0]["age"].ToString();
                textBox_Country.Text = ds.Tables[0].Rows[0]["country"].ToString();
                textBox_Team.Text = ds.Tables[0].Rows[0]["team"].ToString();
                if ("男".Equals(ds.Tables[0].Rows[0]["sex"].ToString()))
                {
                    comboBox_Sex.SelectedIndex = 0;
                }
                else
                {
                    comboBox_Sex.SelectedIndex = 1;
                }
                if ("是".Equals(ds.Tables[0].Rows[0]["bearer"].ToString()))
                {
                    comboBox_Bearer.SelectedIndex = 0;
                }
                else
                {
                    comboBox_Bearer.SelectedIndex = 1;
                }

            }
            else
            {
                comboBox_Bearer.SelectedIndex = 0;
                comboBox_Sex.SelectedIndex = 0;
            }
          
        }

        private void label_Name_Click(object sender, EventArgs e)
        {

        }

     

        private void button_Add_Click(object sender, EventArgs e)
        {
            control.AthleteInfoEntity Cathlete = new control.AthleteInfoEntity();
            string s = textBox_Name.Text.Trim();

            //判空
            if (textBox_Number.Text.Trim() == "" || textBox_Team.Text.Trim() == "" || textBox_Name.Text.Trim() == "" 
                || textBox_Country.Text.Trim() == "" || textBox_Age.Text.Trim() == "")
            {

                MessageBox.Show("请将信息填写完整");
                return;
            }

            Cathlete.number = textBox_Number.Text;
            Cathlete.team = textBox_Team.Text;
            Cathlete.name = textBox_Name.Text;
            Cathlete.sex = comboBox_Sex.Text;
            Cathlete.age = Int32.Parse(textBox_Age.Text);
            Cathlete.country = textBox_Country.Text;
            Cathlete.bearer = comboBox_Bearer.Text;

            Model.AthleteInfo Mathlete = new Model.AthleteInfo();
            if (athleteid == "")  // 这是增加的运动员
            {
                if (Mathlete.addAthlete(Cathlete) < 0)
                {

                    MessageBox.Show("添加失败");
                }
            }
            else  // 这是修改后的
            {
                if (Mathlete.updataAthlete(Cathlete) > 0)
                {
                    MessageBox.Show("修改成功！");

                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }

            textBox_Age.Clear();
            textBox_Country.Clear();
            textBox_Name.Clear();
            textBox_Number.Clear();
            textBox_Team.Clear();
            
        }

        #region 只能输入数字处理
        private void textBox_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtlimit(textBox_Age, e);
        }
        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtlimit(textBox_Number, e);
        }
        //文本框限制输入数字的规则
        private void txtlimit(Control c, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;

        }

        #endregion

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
