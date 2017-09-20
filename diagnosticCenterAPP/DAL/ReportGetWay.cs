using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using diagnosticCenterAPP.Models;

namespace diagnosticCenterAPP.DAL
{
    public class ReportGetWay
    {
        private string connectionString =WebConfigurationManager.ConnectionStrings["UniversityDBConnectionString"].ConnectionString;
     
        public List<testWReport> TestWiseResultDB(string F, string T)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT test_name, test_fee, COUNT(patient_test_list.test_name) FROM patient_test_list " +
                           "INNER JOIN patient_test_id ON patient_test_list.test_no=patient_test_id.id " +
                           "WHERE patient_test_id.date BETWEEN '" + F + "' AND '" + T + "' GROUP BY patient_test_list.test_name";
           
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
           
               List<testWReport> aList = new List<testWReport>();
            if (reader.HasRows)
            {
                
                while (reader.Read())
                {   
                    testWReport aReport=new testWReport();
                    aReport.testName = reader["test_name"].ToString();
                    aReport.testCount = Convert.ToInt32(reader["test_fee"]);
                   
                   
                    aList.Add(aReport);
          
                }
                reader.Close();
            }

            return aList;
            connection.Close();
        }
        } 

    }
