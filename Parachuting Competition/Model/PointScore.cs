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
        public int addPointMessage(AthleteInfoEntity athlete)
        {
            string sql = "insert into Fixpoint([Number],Teamname,athname) values(@Number,@Teamname,@athname)";
            OleDbParameter[] parms = 
            { 
                new OleDbParameter("Number",OleDbType.VarChar),
                new OleDbParameter("Teamname",OleDbType.VarChar),
                new OleDbParameter("athname",OleDbType.VarChar),

            };
            parms[0].Value = athlete.number;
            parms[1].Value = athlete.team;
            parms[2].Value = athlete.name;
            return DBoperation.ParmsupdateDB(sql, parms);
        }
    }
}
