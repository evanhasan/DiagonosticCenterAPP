using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using diagnosticCenterAPP.Models;

namespace diagnosticCenterAPP.DAL
{
    public class testGetWay
    {
        private string connectionString =
           WebConfigurationManager.ConnectionStrings["UniversityDBConnectionString"].ConnectionString;

        public bool existCheck(string type)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //connection.ConnectionString = connectionString;
            //2. Qeury
            string query = "SELECT * FROM Test_type WHERE tt_type='" + type + "'";
           
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int saveData(string type)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            //connection.ConnectionString = connectionString;
            //2. Qeury
            string query = "INSERT INTO Test_type Values('" + type + "')";
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            int x = command.ExecuteNonQuery();

            return x;
        }

        public List<testType> GetAllList()
        {

            SqlConnection connection = new SqlConnection(connectionString);
            //connection.ConnectionString = connectionString;
            //2. Qeury
            string query = "SELECT * FROM Test_type";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<testType> aList = new List<testType>();

                    if (reader.HasRows)
                    {
                        int i = 1;
                        while (reader.Read())
                        {
                            testType aTestType = new testType();
                            aTestType.tesType = reader["tt_type"].ToString();
                            aTestType.id = i;
                            aList.Add(aTestType);
                            i++;
                        }
                        reader.Close();

                    }
            connection.Close();
            return aList;

        }

       

    }
}