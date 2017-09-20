using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using diagnosticCenterAPP.Models;

namespace diagnosticCenterAPP.DAL
{
    public class testNameGetway
    {

        private string connectionString =
           WebConfigurationManager.ConnectionStrings["UniversityDBConnectionString"].ConnectionString;

        public bool checkTestnameDB(string testname)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Test_name WHERE test_name='" + testname + "'";

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

        public int saveTestNameDB(string testName, int fee, string testType)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO test_name VALUES('" + testName + "','" + fee + "','" + testType + "')";

            SqlCommand command = new SqlCommand(query, connection);

            int x = command.ExecuteNonQuery();
            return x;
        }


        public List<TestName> GetTestNames()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //connection.ConnectionString = connectionString;
            //2. Qeury
            string query = "SELECT * FROM Test_name";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<TestName> aList = new List<TestName>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    {
                        TestName aTestName = new TestName();
                        aTestName.testName = reader["test_name"].ToString();
                        aTestName.fee = Convert.ToInt32(reader["test_fee"].ToString());
                        aTestName.testType = reader["test_type"].ToString();

                        aList.Add(aTestName);
                    }
                    
                   
                }
                reader.Close();
            }
            
            return aList;
            connection.Close();
        }
    }
}