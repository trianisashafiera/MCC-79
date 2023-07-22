﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity.Models
{
    public class History
    {
        public DateTime startDate { get; set; }
        public int employeeId { get; set; }
        public DateTime endDate { get; set; }
        public int departmentId { get; set; }
        public string jobId { get; set; } = string.Empty;


        public List<History> GetAll()
        {
            var conn = Connection.connection;
            List<History> histories = new List<History>();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM histories";

                conn.Open();

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var history = new History();
                        history.startDate = reader.GetDateTime(0);
                        history.employeeId = reader.GetInt32(1);
                        history.endDate = reader.GetDateTime(2);
                        history.departmentId = reader.GetInt32(3);
                        history.jobId = reader.GetString(4);

                        histories.Add(history);
                    }
                }
                else
                {
                    Console.WriteLine("Data not found.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return histories;
        }
    }
}
