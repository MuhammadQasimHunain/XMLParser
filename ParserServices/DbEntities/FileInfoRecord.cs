using ParserServices.DbEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace XMLParserService.DbEntities
{
    public class FileInfoRecord
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedTime { get; set; }



        public static List<FileInfoRecord> GetFileInfoRecords() 
        {
            List<FileInfoRecord> lst = new List<FileInfoRecord>();
            string connectionString = DbConstants.ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = DbConstants.SelectFileInfoQuery;

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = CommandType.Text;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lst.Add(new FileInfoRecord {
                        Id = int.Parse(reader.GetValue(0).ToString()),
                        FileName = reader.GetValue(1).ToString(),
                        Status = bool.Parse(reader.GetValue(2).ToString()),
                        CreatedTime = DateTime.Parse(reader.GetValue(3).ToString())
                    });
                }
                connection.Close();
            }
            return lst;
        }

        public static FileInfoRecord GetFileInfoRecord(int id)
        {
            FileInfoRecord fileInfoRecord = new FileInfoRecord();
            string connectionString = DbConstants.ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = DbConstants.SelectFileInfoById;
            
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    fileInfoRecord = new FileInfoRecord
                    {
                        Id = int.Parse(reader.GetValue(0).ToString()),
                        FileName = reader.GetValue(1).ToString(),
                        Status = bool.Parse(reader.GetValue(2).ToString()),
                        CreatedTime = DateTime.Parse(reader.GetValue(3).ToString())
                    };
                }
                connection.Close();
            }
            return fileInfoRecord;
        }
        public int AddToDatabase()
        {
            int readerValue = 0;
            string connectionString = DbConstants.ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = DbConstants.InsertFileInfo;

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@FileName", FileName);
                command.Parameters.AddWithValue("@Status", Status.ToString());
                command.Parameters.AddWithValue("@CreatedTime", CreatedTime);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    readerValue = int.Parse(reader.GetValue(0).ToString());
                }
                connection.Close();
            }
            return readerValue;
        }
        public FileInfoRecord UpdateInDatabase()
        {
            int reader = 0;
            string connectionString = DbConstants.ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = DbConstants.UpdateFileInfo;

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@FileName", FileName);
                command.Parameters.AddWithValue("@Status", Status.ToString());
                command.Parameters.AddWithValue("@CreatedTime", CreatedTime);
                command.Parameters.AddWithValue("@Id", Id);
                connection.Open();
                reader = command.ExecuteNonQuery();
                connection.Close();
            }
            return this;
        }

        public bool Delete()
        {
            int reader = 0;
            string connectionString = DbConstants.ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = DbConstants.DeleteFileInfo;

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Id", Id);
                connection.Open();
                reader = command.ExecuteNonQuery();
                connection.Close();
            }
            return reader != 0;
        }
    }
}
