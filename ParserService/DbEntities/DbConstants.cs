using System;
using System.Collections.Generic;
using System.Text;

namespace ParserServices.DbEntities
{
    public class DbConstants
    {
        public static string ConnectionString { get { return @"Server=104.219.233.61;Initial Catalog=xmlParser;User ID=QasimHunain;Password=Ncu5l0$8;Connection Timeout=30;";} }
        public static string SelectFileInfoQuery { get { return @"SELECT [Id],[FileName],[Status],[CreatedTime] FROM [xmlParser].[QasimHunain].[tbl_FileInfoRecord]"; } }
        public static string SelectFileInfoById { get { return @"SELECT [Id],[FileName],[Status],[CreatedTime] FROM [xmlParser].[QasimHunain].[tbl_FileInfoRecord] where Id =@Id"; } }
        public static string InsertFileInfo { get { return @"INSERT INTO [QasimHunain].[tbl_FileInfoRecord]([FileName],[Status],[CreatedTime]) VALUES (@FileName,@Status,@CreatedTime); select SCOPE_IDENTITY()"; } }
        public static string UpdateFileInfo { get { return @"UPDATE [QasimHunain].[tbl_FileInfoRecord] SET [FileName] = @FileName ,[Status] = @Status ,[CreatedTime] = @CreatedTime  WHERE Id = @Id"; } }
        public static string DeleteFileInfo { get { return @"Delete [QasimHunain].[tbl_FileInfoRecord] WHERE Id = @Id"; } }
    }
}
