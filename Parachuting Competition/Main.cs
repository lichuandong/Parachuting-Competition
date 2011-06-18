using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parachuting_Competition.Model;
using Parachuting_Competition.Entity;

namespace Parachuting_Competition
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //创建运动员对象
        User user = new User();
        string athnumber = "";
        string teamname = "";
        private void Main_Load(object sender, EventArgs e)
        {

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

        #region 添加，删除，修改按钮
        //添加按钮
        private void button_Add_Click(object sender, EventArgs e)
        {
            // 点击添加，传一个空字符串
            AddAthlete addAthlete = new AddAthlete("");

            addAthlete.Text = "添加选手";

            //将刷新dataGridView的方法加到addAthlete对象的委托事件中
            addAthlete.myevent += new AddAthlete.myEvent(updateData);

            addAthlete.Show();
        }
        //修改按钮
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
                addAthlete.myevent += new AddAthlete.myEvent(updateData);
                addAthlete.Show();
            }
        }
        //定义刷新dataGridView的方法
        private void updateData()
        {

            dataGridView_Athlete.DataSource = user.getallAthletes().Tables[0];
        }
        //删除按钮
        private void delectbtn_Click(object sender, EventArgs e)
        {
            //得到被选中的行的集合
            DataGridViewSelectedRowCollection selectRows = dataGridView_Athlete.SelectedRows;
            if (selectRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的数据行！", "注意");
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
        #endregion



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

        public bool checkdata() // 判断是否输入查询条件
        {
            teamname = textBox_team.Text.Trim();
            athnumber = textBox_number.Text.Trim();
            if (teamname == "" && athnumber == "")
            {
                MessageBox.Show("请至少输入一个查询条件！");
                return false;
            }
            return true;
        }

        private PointScore point = new PointScore();
        private PointScroeEntity pointscroe = new PointScroeEntity();
        private DataSet ds;//更新的时候必须用到datagridview的数据源dataset
        private void searchbtn_Click(object sender, EventArgs e)
        {
          
            if (checkdata() == true)
            {

                pointscroe.Teamname1 = teamname;
                pointscroe.Number1 = athnumber;
              
                 ds = point.findathletes(pointscroe);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    Pointdgv.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("没找到数据！");
                    return;
                }
            }

       }
        
            
    
          
        

        private void savebtn_Click(object sender, EventArgs e)
        {
          
             
               int i= point.updataTable(ds);
               if (i > 0)
               {
                   MessageBox.Show("更新成功！");
               }
               else
               {
                   MessageBox.Show("更新失败！");
                   return;
               }
            
        }

      

        private void Pointdgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex != 1 && e.ColumnIndex != 2 && e.ColumnIndex != 3)
                try
                {
                    if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                    }
                    else
                    {
                        decimal val = decimal.Parse(e.FormattedValue.ToString());
                    }
                }
                catch (Exception ex)
                {
                  //  Pointdgv.Rows[e.RowIndex].ErrorText = "必须输入数字";
                    MessageBox.Show("请输入数字 ");
                    e.Cancel = true;
                }
            
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            //就是重新绑定之前的DataTable,然后清除DataTable中的数据，如下：

            DataTable dt = (DataTable)Pointdgv.DataSource;
            dt.Rows.Clear();
            Pointdgv.DataSource = dt; 
        }

       







    }
}
