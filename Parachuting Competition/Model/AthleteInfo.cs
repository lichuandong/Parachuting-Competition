using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Parachuting_Competition.Entity;
namespace Parachuting_Competition.Model
{
    class AthleteInfo
    {
        //增加队员信息
        public int addAthlete(Entity.AthleteInfoEntity athlete)
        {
            //number一定要加[]
            string sql = "insert into AthleteInfo([number],team,athname,sex,age,country,bearer)values(@number,@team,@athname,@sex,@age,@country,@bearer)";
            OleDbParameter[] parms =
            {
                new OleDbParameter("number",OleDbType.VarChar),
                new OleDbParameter("team",OleDbType.VarChar),
                new OleDbParameter("athname",OleDbType.VarChar),
                new OleDbParameter("sex",OleDbType.VarChar),
                new OleDbParameter("age",OleDbType.Integer),
                new OleDbParameter("country",OleDbType.VarChar),
                new OleDbParameter("bearer",OleDbType.VarChar)
            };

            parms[0].Value = athlete.number;
            parms[1].Value = athlete.team;
            parms[2].Value = athlete.name;
            parms[3].Value = athlete.sex;
            parms[4].Value = athlete.age;
            parms[5].Value = athlete.country;
            parms[6].Value = athlete.bearer;

            return DBoperation.ParmsupdateDB(sql, parms);
        }

        //通过队员的编号删除队员
        public int deletAthlete(string athnumber)
        {
            string sql = "delete from AthleteInfo where [number]=@number";
            OleDbParameter[] parm = { new OleDbParameter("number", OleDbType.VarChar) };
            parm[0].Value = athnumber;

            return DBoperation.ParmsupdateDB(sql, parm);
        }
        //通过队员编号找到队员信息
        public DataSet findAthletes(string number)
        {
            string sql = "select * from AthleteInfo where [number]=@number";
            OleDbParameter[] parm = { new OleDbParameter("number", OleDbType.VarChar) };
            parm[0].Value = number;
            return DBoperation.ParmsQueryDB(sql, parm);
        }
        // 通过队员编号修改对应队员的信息
        public int updataAthlete(Entity.AthleteInfoEntity athlete)
        {
            string sql = "update AthleteInfo set team=@team,athname=@athname,sex=@sex,age=@age,country=@country,bearer=@bearer where [number]=@number";
            OleDbParameter[] parms = 
            { 
             //一定要注意传参的顺序
            new OleDbParameter("team", OleDbType.VarChar) ,
            new OleDbParameter("athname", OleDbType.VarChar) ,
            new OleDbParameter("sex", OleDbType.VarChar) ,
            new OleDbParameter("age", OleDbType.Integer) ,
            new OleDbParameter("country", OleDbType.VarChar) ,
            new OleDbParameter("bearer", OleDbType.VarChar) ,
            new OleDbParameter("number", OleDbType.VarChar) 
         };

            parms[0].Value = athlete.team;
            parms[1].Value = athlete.name;
            parms[2].Value = athlete.sex;
            parms[3].Value = athlete.age;
            parms[4].Value = athlete.country;
            parms[5].Value = athlete.bearer;
            parms[6].Value = athlete.number;
            return DBoperation.ParmsupdateDB(sql, parms);
        }
    }
}
