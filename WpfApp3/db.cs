using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;

namespace db
{
    
    
        public class dB
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-M21S13G; Initial Catalog=proekt; Integrated Security=True");
            public void openConnection()
            {

                if (sqlConnection.State == System.Data.ConnectionState.Closed)

                {
                    sqlConnection.Open();
                }
            }
            public void closeConnection()
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            public SqlConnection getConnection()
            {
                return sqlConnection;
            }
        }
    }

    

    

