using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Parachuting_Competition.Model
{
    class User
    {
        //修改用户
        public int updateUser(Entity.UserEntity user)
        {

            string sql = "UPDATE Users set Uname='" + user.username + "',Pword='" + user.password + "' where ID=2";

            return DBoperation.updateDB(sql);
        }

        //查找用户
        public bool selectUser(Entity.UserEntity user)
        {

            string sql = "select * from Users where Uname = @Uname";
            OleDbParameter[] parms = 
            {
            
                new OleDbParameter("@Uname",OleDbType.VarChar,50)
            };
            parms[0].Value = user.username;

            DataSet ds = DBoperation.ParmsQueryDB(sql, parms);
            if (ds.Tables[0].Rows.Count != 0) //如果得到的dataset是空的
            {
                string s = ds.Tables[0].Rows[0][2].ToString();
                if (s.Equals(user.password))
                {

                    return true;
                }
            }
            return false;
        }

        public Entity.UserEntity findUser()
        {
            Entity.UserEntity user = new Entity.UserEntity();
            string sql = "select * from Users";

            DataSet ds = DBoperation.QueryDB(sql);
            user.username = ds.Tables[0].Rows[0][1].ToString();
            user.password = ds.Tables[0].Rows[0][2].ToString();
            return user;
        }

        //展示所有的队员
        public DataSet getallAthletes()
        {
            string sql = "select * from AthleteInfo";
            return DBoperation.QueryDB(sql);
        }
    }
}
