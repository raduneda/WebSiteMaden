#region

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using TL;
using TL.Enums;

#endregion

namespace DL
{
    public class DatabaseManager
    {
        private const string PHOTO_TABLE = "Photo";
        private const string PHOTO_PATH_ = "PATH_";
        private const string PHOTO_TYPE_ = "TYPE_";
        private const string PHOTO_NAME_ = "NAME_";
        private const string PHOTO_EXTENSION_ = "EXTENSION_";
        private const string PHOTO_DATE_ = "DATE_";
        private SQLiteConnection _connection;

        public void InsertPhotoDto( PhotoDto photoDto )
        {
            using (
                _connection = CreateConnection() )
            {
                string commandString =
                    string.Format("insert into {0} ({1},{2},{3},{4},{5}) values ('{6}',{7},'{8}','{9}','{10}')",
                        PHOTO_TABLE,
                        PHOTO_PATH_, PHOTO_TYPE_, PHOTO_NAME_, PHOTO_EXTENSION_, PHOTO_DATE_,
                        photoDto.Path, (int) photoDto.Type, photoDto.Name, photoDto.Extension,
                        photoDto.CreationDate);

                SQLiteCommand command = new SQLiteCommand(commandString, _connection);
                _connection.Open();

                //SQLiteDataReader reader = command.ExecuteReader();

                int execution = command.ExecuteNonQuery();

                if ( execution != 1 )
                {
                    throw new Exception(string.Concat("Execution failed for:", commandString));
                }
            }
        }

        public IList<PhotoDto> GetPhotoDtoList()
        {
            using (
                _connection = CreateConnection() )
            {
                string commandString =
                    string.Format("Select * from {0}", PHOTO_TABLE);

                SQLiteCommand command = new SQLiteCommand(commandString, _connection);
                _connection.Open();

                SQLiteDataReader reader = command.ExecuteReader();
                List<PhotoDto> photoDtoList = new List<PhotoDto>();

                while ( reader.Read() )
                {
                    PhotoDto photoDto = new PhotoDto
                    {
                        Name = reader.GetValue(reader.GetOrdinal(PHOTO_NAME_)).ToString(),
                        CreationDate = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal(PHOTO_DATE_))),
                        Extension = reader.GetValue(reader.GetOrdinal(PHOTO_EXTENSION_)).ToString(),
                        Path = reader.GetValue(reader.GetOrdinal(PHOTO_PATH_)).ToString(),
                        Type = (PhotoEnum.PortfolioImageType) Convert.ToInt16(reader.GetValue(reader.GetOrdinal(PHOTO_TYPE_))) 
                    };
                    photoDtoList.Add(photoDto);
                }
                return photoDtoList;
            }
        }

        private static SQLiteConnection CreateConnection()
        {
            return new SQLiteConnection(string.Concat("Data Source=",
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"App_Data\Database.db"), ";Version=3;"));
        }
    }
}