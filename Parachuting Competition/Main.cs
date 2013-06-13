using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parachuting_Competition.Model;
using Parachuting_Competition.control;

namespace Parachuting_Competition
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
       //创建运动员对象
        private void Form1_Load(object sender, EventArgs e)
        {
            User user=new User();
            dataGridView_Athlete.DataSource = user.getallAthletes().Tables[0];
        }

        private Rectangle tabArea;
        private RectangleF tabTextArea;
       
        #region 重绘TabControl
        private void tabControl_Main_DrawItem(object sender, DrawItemEventArgs e)
        {
            tabArea = tabControl_Main.GetTabRect(e.Index);
            tabTextArea = tabArea;
            Graphics g = e.Graphics;
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            Font font = this.tabControl_Main.Font;
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawString(((TabControl)(sender)).TabPages[e.Index].Text, font, brush, tabTextArea, sf); 
        }

        

        #endregion

       
        private void button_Add_Click(object sender, EventArgs e)
        {
            // 点击添加，传一个空字符串
            AddAthlete addAthlete = new AddAthlete("");
            addAthlete.Text = "添加选手";
            addAthlete.Show();
        }

        private void delectbtn_Click(object sender, EventArgs e)
        {
            //得到被选中的行的集合
              DataGridViewSelectedRowCollection selectRows = dataGridView_Athlete.SelectedRows;
              if (selectRows.Count == 0)
              {
                  MessageBox.Show("请选择要删除的数据行！","注意");
                  return;
              }
              else
              {
                  AthleteInfo athlete = new AthleteInfo();
                  DialogResult result = MessageBox.Show("确定删除吗？", "注意", MessageBoxButtons.OKCancel);
                  if (result == DialogResult.OK)
                  {
                      foreach (DataGridViewRow row in selectRows)
                      {

                          string number = row.Cells[1].Value.ToString();//得到队员的编号
                          athlete.deletAthlete(number);// 通过队员的编号进行数据库的删除
                          dataGridView_Athlete.Rows.Remove(row);

                      }
                  }
                  else
                  {
                      return;
                  }
                  
              }
        }

        private void updatabtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectRows = dataGridView_Athlete.SelectedRows;
            if (selectRows.Count == 0)
            {
                MessageBox.Show("请选择要修改的数据！");
            }
            else
            {
                AthleteInfo athlete = new AthleteInfo();
                string number = dataGridView_Athlete.SelectedCells[1].Value.ToString();//得到队员的编号
                AddAthlete addAthlete = new AddAthlete(number);// 修改队员信息，传一个队员编号过去，然后好通过编号找到该队员信息，并展示出来
                addAthlete.Text = "修改选手信息";
                addAthlete.Show();
            }
        }

        private void textBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtlimit(textBox_number, e);
        }
        //文本框限制输入数字的规则
        private void txtlimit(Control c, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string teamname = textBox_team.Text.Trim();
            string number=textBox_number.Text.Trim();
            if (teamname == "" && number == "")
            {
                MessageBox.Show("请至少输入一个查询条件！");
                return;
            }
            else
            {
                int athleteid = Int32.Parse(number);

            }
        }

        private void Pointdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string name = Pointdgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show(name);
        }



       

  
    }
}
