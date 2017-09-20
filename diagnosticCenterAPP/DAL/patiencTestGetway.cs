using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using diagnosticCenterAPP.BLL;
using diagnosticCenterAPP.Models;

namespace diagnosticCenterAPP.DAL
{
    public class patiencTestGetway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["UniversityDBConnectionString"].ConnectionString;

        public int saveTestDetail(string testname, int fee, int testUniqueID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO patient_test_list  Values('" + testname + "','" + fee + "', '" + testUniqueID + "')";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            int x = command.ExecuteNonQuery();

            return x;
        }

        public List<IndividualTestList> GetIndividualTestList(int billId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //connection.ConnectionString = connectionString;
            //2. Qeury
            string query = "SELECT * FROM patient_test_list WHERE test_no='" + billId + "'";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<IndividualTestList> aList = new List<IndividualTestList>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    IndividualTestList aIndividualTestList = new IndividualTestList();
                    aIndividualTestList.testName = reader["test_name"].ToString();
                    aIndividualTestList.testFee = Convert.ToInt32(reader["test_fee"]);
                    aList.Add(aIndividualTestList);
                }
                reader.Close();

            }
            connection.Close();
            return aList;

        }

        public payment GetPayDetail(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //connection.ConnectionString = connectionString;
            //2. Qeury
            string query = "SELECT * FROM patient_test_id WHERE id='" + id + "'";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            payment aPayment = new payment();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    aPayment.total = (int)reader["total"];
                    aPayment.paid = (int)reader["paid"];
                    aPayment.due = (int)reader["due"];
                    aPayment.billDate = reader["date"].ToString();
                }

                reader.Close();
            }
            connection.Close();
            return aPayment;

        }

        public void UpdateTotalDB(int id, int pay)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "UPDATE patient_test_id SET paid='"+pay+"' WHERE id='"+id+"' ";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

    }
}




