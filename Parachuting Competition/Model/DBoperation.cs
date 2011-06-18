using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
namespace Parachuting_Competition.Model
{
    class DBoperation
    {

        //从配置文件中读取连接access 数据信息
        public static OleDbConnection connectionString = new OleDbConnection(ConfigurationManager.ConnectionStrings["MyDataConnectionString"].ConnectionString);



        static private void PrepareCommand(OleDbCommand cmd, OleDbParameter[] cmdParms)
        {

            foreach (OleDbParameter parameter in cmdParms)
            {

                cmd.Parameters.Add(parameter);
            }
        }

        //带参数的更新数据库（增加、删除、更新）
        public static int ParmsupdateDB(string cmdText, OleDbParameter[] cmdParms)
        {

            connectionString.Close();
            connectionString.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connectionString;
            cmd.CommandText = cmdText;
            PrepareCommand(cmd, cmdParms);
            //cmd.Parameters.Clear();
            return cmd.ExecuteNonQuery();
        }

        //不带参数的更新数据库（增加、删除、更新）
        public static int updateDB(string cmdText)
        {
            connectionString.Close();
            connectionString.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connectionString;
            cmd.CommandText = cmdText;

            return cmd.ExecuteNonQuery();

        }

        //查询数据库（sql带参数）
        static public DataSet ParmsQueryDB(string cmdText, OleDbParameter[] cmdParms)
        {

            connectionString.Close();
            connectionString.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connectionString;
            cmd.CommandText = cmdText;

            PrepareCommand(cmd, cmdParms);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        //查询数据库（sql不带参数）
        static public DataSet QueryDB(string cmdText)
        {

            connectionString.Close();
            connectionString.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connectionString;
            cmd.CommandText = cmdText;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        //将datagridview中更改的数据同步到数据库
        public static int updateTable(DataSet ds,string sql)
        {
           
            connectionString.Close();
            connectionString.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connectionString;
            cmd.CommandText = sql;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
  
            OleDbCommandBuilder com = new OleDbCommandBuilder(da);//自动生成跟新语句



           //这种更新必须用到原来datagrideview的datasource的数据源dataset，
            //因为在datagrideview中更改数据时同时更改了其datasource数据源的dataset，
            //在此就是利用更改后的dataset，更新数据库
            return da.Update(ds);

            
        }
    }
}
