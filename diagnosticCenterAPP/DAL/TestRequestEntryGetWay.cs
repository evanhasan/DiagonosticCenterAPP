using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using diagnosticCenterAPP.Models;

namespace diagnosticCenterAPP.DAL
{
    public class TestRequestEntryGetWay
    {

        private string connectionString =
            WebConfigurationManager.ConnectionStrings["UniversityDBConnectionString"].ConnectionString;

        public List<string> GetTestNameList()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //connection.ConnectionString = connectionString;
            //2. Qeury
            string query = "SELECT test_name FROM Test_name";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<string> aList = new List<string>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    {
                        string nameList = reader["test_name"].ToString();

                        aList.Add(nameList);
                    }


                }
                reader.Close();
            }

            return aList;
            connection.Close();
        }

        public int SaveuserDB(string name, string mobile, string dateofbirth, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO patient_tb VALUES('" + name + "','" + mobile + "','" + dateofbirth + "','" +
                           address + "')";
            SqlCommand command = new SqlCommand(query, connection);

            int x = command.ExecuteNonQuery();
            return x;
        }

        public int GetFeeFromDB(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //connection.ConnectionString = connectionString;
            //2. Qeury
            string query = "SELECT test_fee FROM test_name WHERE test_name='" + name + "'";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            int testFee = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    testFee = Convert.ToInt32(reader["test_fee"]);
                }
            }
            return testFee;
        }

        public int GetUserID(string name, string mobile)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //connection.ConnectionString = connectionString;
            //2. Qeury
            string query = "SELECT user_id FROM patient_tb WHERE name='" + name + "'AND mobile='" + mobile + "' ";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            int id = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["user_id"]);
                }
            }
            return id;
        }


        public int SaveUserIDOthertableDB(int userID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string DT = DateTime.Today.ToString("yyyy-MM-dd");

            string query = "INSERT INTO patient_test_id (user_id, date,total,paid,due) VALUES('" + userID + "','" + DT + "',0,0,0)";
            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
            string query1 = "SELECT id FROM patient_test_id WHERE user_id='" + userID + "'";
            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlDataReader reader = command1.ExecuteReader();
            int id = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                }
            }

            return id;
        }

        public bool CheckUserDB(string mobile)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM patient_tb WHERE mobile='" + mobile + "'";

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

        public void SaveTotalDB(int id, int total)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string DT = DateTime.Today.ToString("dd-MM-yyyy");
            string query = "UPDATE patient_test_id SET total='" + total + "' WHERE id='" + id + "'";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

    }
}
