﻿using System;
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

        public DataSet findathletes(PointScroeEntity pointentity)
        {
            string sql = "select * from Fixpoint where Teamname=@Teamname or [Number]=@Number";
            OleDbParameter[] parms = 
            { 
               new OleDbParameter("Teamname",OleDbType.VarChar),
                new OleDbParameter("Number",OleDbType.VarChar)
            };
            parms[0].Value = pointentity.Teamname1;
            parms[1].Value = pointentity.Number1;
            return DBoperation.ParmsQueryDB(sql, parms);
        }
    }
}
