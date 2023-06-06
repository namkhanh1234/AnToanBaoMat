using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PhanHe1.DAO
{  
    public class DataProvider
    {
        string host;
        int port;
        string sid;
        string user ;
        string password;
        public static string connectionSTR;
        public DataProvider() {
            host = "192.168.57.1";
            port = 1521;
            sid = "xe";
            user = "admin";
            password = "s123";
            connectionSTR = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;
    }

        public DataProvider(string username,string userpassword)
        {
            host = "192.168.57.1";
            port = 1521;
            sid = "xe";
            connectionSTR = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + userpassword + ";User ID=" + username;
        }
        public DataTable ExecuteQuery(string query, object[] paramenter = null)
        {
            DataTable data = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

             

                OracleCommand command = new OracleCommand(query, connection);

                if (paramenter != null)
                {
                    String[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.Add(item, paramenter[i]);
                            i++;
                        }
                    }
                }

                OracleDataAdapter adapter = new OracleDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] paramenter = null)
        {
            int data = 0;

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(query, connection);
                command.CommandType = CommandType.Text;

                if (paramenter != null)
                {
                    String[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.Add(item, paramenter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }
        public int ExecuteNonQuery_Procedure(string procedure,string query, object[] paramenter = null)
        {
            int data = 0;

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                String[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                   command.Parameters.Add(item, OracleDbType.Varchar2).Value= paramenter[i];
                   i++;
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] paramenter = null)
        {
            object data = 0;

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(query, connection);

                if (paramenter != null)
                {
                    String[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.Add(item, paramenter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}

