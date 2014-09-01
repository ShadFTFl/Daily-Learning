using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAppDesktopVersion
{
    class EmployeeDbGateway : DbGateway
    {
        public void AddDesignation(Designation aDesignation)
        {
            string sqlQuery = string.Format("INSERT INTO Desginations ([Title], [Responsibility]) VALUES ('{0}', '{1}')", aDesignation.Title, aDesignation.Responsibility);
            SqlCommand.CommandText = sqlQuery;
            SqlConnection.Open();
            SqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
        }

        public List<Designation> GetDesginations()
        {
            List<Designation> designations = new List<Designation>();

            string sqlQuery = "SELECT Desginations.Title, Desginations.Responsibility FROM Desginations";
            SqlCommand.CommandText = sqlQuery;
            
            SqlConnection.Open();
            SqlDataReader reader = SqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Designation aDesignation = new Designation();
                aDesignation.Title = reader["Title"].ToString();
                aDesignation.Responsibility = reader["Responsibility"].ToString();
                designations.Add(aDesignation);
            }
            SqlConnection.Close();
            return designations;
        }
    }
}
