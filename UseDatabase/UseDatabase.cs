using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace UseDatabase
{
    public class UseDatabase : MarshalByRefObject
    {
        public SqlConnection conn;
        public SqlDataAdapter dba;
        DataSet ds;

        #region Constructor

        public UseDatabase()
        {
        }

        #endregion

        #region Methods

        public void ConnectToDB()
        {
            conn = new SqlConnection(@"Integrated Security=SSPI;
                                       Initial Catalog=GlobalHyper;
                                       Data Source=localhost");
            conn.Open();
        }

        public void DisconnectToDB()
        {
            conn.Close();
        }

        public bool ExecuteCommand(string query)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public SqlDataReader ExecuteQuery(string query)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                return cmd.ExecuteReader();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public DataSet getData()
        {
            ds = new DataSet();
            dba = new SqlDataAdapter("getAllTables", conn);
            dba.Fill(ds);
            return ds;
        }

        public void updateDB()
        {
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(dba);
            dba.Update(ds, "getAllTables");
        }

        public DataSet getProduct()
        {
            ds = new DataSet();
            dba = new SqlDataAdapter("SELECT * FROM PRODUCTS", conn);
            dba.Fill(ds);
            return ds;
        }

        public DataSet viewProduct()
        {
            ds = new DataSet();
            dba = new SqlDataAdapter("SELECT * FROM productInfo", conn);
            dba.Fill(ds);
            return ds;
        }

        public DataSet getWorker()
        {
            ds = new DataSet();
            dba = new SqlDataAdapter("SELECT * FROM WORKER", conn);
            dba.Fill(ds);
            return ds;
        }

        #endregion
    }
}
