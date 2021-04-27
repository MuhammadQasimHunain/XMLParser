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
            string connectionString = @"Server=104.219.233.61;Initial Catalog=xmlParser;User ID=QasimHunain;Password=Ncu5l0$8;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"SELECT [Id],[FileName],[Status],[CreatedTime] FROM [xmlParser].[QasimHunain].[tbl_FileInfoRecord]";

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
            string connectionString = @"Server=104.219.233.61;Initial Catalog=xmlParser;User ID=QasimHunain;Password=Ncu5l0$8;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"SELECT [Id],[FileName],[Status],[CreatedTime] FROM [xmlParser].[QasimHunain].[tbl_FileInfoRecord]";
            
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = CommandType.Text;

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
            string connectionString = @"Server=104.219.233.61;Initial Catalog=xmlParser;User ID=QasimHunain;Password=Ncu5l0$8;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = string.Format(@"INSERT INTO [QasimHunain].[tbl_FileInfoRecord]([FileName],[Status],[CreatedTime]) VALUES (@FileName,@Status,@CreatedTime); select SCOPE_IDENTITY()");

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
        public bool UpdateInDatabase()
        {
            int reader = 0;
            string connectionString = @"Server=104.219.233.61;Initial Catalog=xmlParser;User ID=QasimHunain;Password=Ncu5l0$8;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = string.Format(@"UPDATE [QasimHunain].[tbl_FileInfoRecord] SET [FileName] = @FileName ,[Status] = @Status ,[CreatedTime] = @CreatedTime  WHERE Id = @Id");

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
            return reader != 0;
        }

        public bool Delete()
        {
            int reader = 0;
            string connectionString = @"Server=104.219.233.61;Initial Catalog=xmlParser;User ID=QasimHunain;Password=Ncu5l0$8;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = string.Format(@"Delete [QasimHunain].[tbl_FileInfoRecord] WHERE Id = @Id");

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
