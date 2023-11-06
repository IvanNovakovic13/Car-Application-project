using System;
using System.Data.SqlClient;

namespace Car_Management_System
{
    class dbconnect
    {
        private SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-GAG747M\SQLEXPRESS;Initial Catalog=AutomobiliSystemDatabase;Integrated Security=True; Connect Timeout=30");

        public SqlConnection connect()
        {
            return cn;
        }

        public void open()
        {
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
        }

        public void close()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }
    }
}
