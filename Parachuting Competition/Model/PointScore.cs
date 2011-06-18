using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Parachuting_Competition.Entity;

namespace Parachuting_Competition.Model
{
    class PointScore
    {
        public int addPointMessage(AthleteInfoEntity athlete) //在增加队员的时候就将一些数据插入到定点成绩表中
        {
            string sql = "insert into Fixpoint([Number],Teamname,athname) values(@Number,@Teamname,@athname)";
            OleDbParameter[] parms = 
            { 
                new OleDbParameter("Number",OleDbType.VarChar),
                new OleDbParameter("Teamname",OleDbType.VarChar),
                new OleDbParameter("athname",OleDbType.VarChar)

            };
            parms[0].Value = athlete.number;
            parms[1].Value = athlete.team;
            parms[2].Value = athlete.name;
            return DBoperation.ParmsupdateDB(sql, parms);
        }

        public string sql;
        public DataSet findathletes(PointScroeEntity pointentity)
        {
            sql = "select * from Fixpoint where Teamname=@Teamname and [Number]=@Number";
            if (pointentity.Teamname1 == "" || pointentity.Number1 == "")
            {

                sql = "select * from Fixpoint where Teamname=@Teamname or [Number]=@Number";
            }
            
            OleDbParameter[] parms = 
            { 
               new OleDbParameter("Teamname",OleDbType.VarChar),
               new OleDbParameter("Number",OleDbType.VarChar)
            };
            parms[0].Value = pointentity.Teamname1;
            parms[1].Value = pointentity.Number1;
            return DBoperation.ParmsQueryDB(sql, parms);
        }

        //将datagridview中更改的数据同步到数据库
        public int updataTable(DataSet ds)
        {
            sql = "select * from Fixpoint ";//主要用来确定更新那张数据表，比如这里是Fixpoint这张表
           
            return DBoperation.updateTable(ds,sql);

        }
    }
}
