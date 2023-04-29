using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace MusicDatabase
{
    internal class DatabaseController
    {
        readonly string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music;";
        public List<Album> getAllAlbums()
        {
            List<Album> albums = new();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `albums`", connection);
            using (MySqlDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Album album = new Album
                    {
                        ID = dataReader.GetInt32(0),
                        Albumname = dataReader.GetString(1),
                        Artistname = dataReader.GetString(2),
                        Year = dataReader.GetInt32(3),
                        ImageURL = dataReader.GetString(4),
                        Description = dataReader.GetString(5)
                    };
                    albums.Add(album);
                }
            }
            connection.Close();
            return albums;
        }
        public bool albumExists(Album album) {
            MySqlConnection connection = new(connectionString);
            connection.Open();
            MySqlCommand command = new();
            command.CommandText = "SELECT COUNT(*) FROM albums WHERE ID = @albumID";
            command.Parameters.AddWithValue("@albumID", album.ID);
            command.Connection = connection;
            int rows = (int)command.ExecuteScalar();
            connection.Close();
            return rows > 0;
        }
        public List<Album> searchTitles(string searchTerm)
        {
            List<Album> albums = new();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string searchWildcardPhrase = "%" + searchTerm + "%";
            MySqlCommand command = new();
            command.CommandText = "SELECT * FROM `albums` WHERE ALBUM_TITLE LIKE @searchTerm";
            command.Parameters.AddWithValue("@searchTerm", searchWildcardPhrase);
            command.Connection = connection;
            using (MySqlDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Album album = new Album
                    {
                        ID = dataReader.GetInt32(0),
                        Albumname = dataReader.GetString(1),
                        Artistname = dataReader.GetString(2),
                        Year = dataReader.GetInt32(3),
                        ImageURL = dataReader.GetString(4),
                        Description = dataReader.GetString(5)
                    };
                    albums.Add(album);
                }
            }
            connection.Close();
            return albums;
        }
        internal int insertAlbum(Album album)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO `albums`(`ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumTitle, @artist, @year, @imageURL, @description)", connection);
            command.Parameters.AddWithValue("@albumTitle", album.Albumname);
            command.Parameters.AddWithValue("@artist", album.Artistname);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return rows;
        }
        internal int updateAlbum(Album album, int albumID) {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("UPDATE `albums` SET `ALBUM_TITLE`=@title,`ARTIST`=@artist,`YEAR`=@year,`IMAGE_NAME`=@imageURL,`DESCRIPTION`=@description WHERE ID = @albumID", connection);
            command.Parameters.AddWithValue("@title", album.Albumname);
            command.Parameters.AddWithValue("@artist", album.Artistname);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);
            command.Parameters.AddWithValue("@albumID", album.ID);
            return -1;
        }
        internal int deleteAlbum(int albumID) {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM albums WHERE ID = @albumID", connection);
            command.Parameters.AddWithValue("@albumID", albumID);
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return rows;
        }
        // uses the Track Model Object
        public List<Track> getTracksForAlbum(int albumID)
        {
            List<Track> tracks = new();
            MySqlConnection connection = new(connectionString);
            connection.Open();
            MySqlCommand command = new();
            command.CommandText = "SELECT * FROM `tracks` WHERE albums_ID = @albumID";
            command.Parameters.AddWithValue("@albumID", albumID);
            command.Connection = connection;
            using (MySqlDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Track track = new()
                    {
                        ID = dataReader.GetInt32(0),
                        Name = dataReader.GetString(1),
                        Number = dataReader.GetInt32(2),
                        VideoURL = dataReader.GetString(3),
                        Lyrics = dataReader.GetString(4)
                    };
                    tracks.Add(track);
                }
            }
            connection.Close();
            return tracks;
        }
        // uses a Json Object, this is very flexible
        public List<JObject> getTracksUsingJoin(int albumID)
        {
            List<JObject> tracks = new();
            MySqlConnection connection = new(connectionString);
            connection.Open();
            MySqlCommand command = new();
            command.CommandText = "SELECT `tracks`.`ID` as `track id`, albums.ALBUM_TITLE as album, `title`, `number`, `video_url`, `lyrics` FROM tracks JOIN albums ON albums_ID = albums.ID WHERE albums_ID = @albumID";
            command.Parameters.AddWithValue("@albumID", albumID);
            command.Connection = connection;
            using (MySqlDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    JObject track = new();
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        track.Add(dataReader.GetName(i).ToString(), dataReader.GetValue(i).ToString());
                    }
                    tracks.Add(track);
                }
            }
            connection.Close();
            return tracks;
        }
        public bool trackExists(Track track) {
            MySqlConnection connection = new(connectionString);
            connection.Open();
            MySqlCommand command = new();
            command.CommandText = "SELECT COUNT(*) FROM tracks WHERE ID = @trackID";
            command.Parameters.AddWithValue("@trackID", track.ID);
            command.Connection = connection;
            int rows = (int)command.ExecuteScalar();
            connection.Close();
            return rows > 0;
        }
        internal int insertTrack(Track track) {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO `tracks`(`title`, `number`, `video_url`, `lyrics`, `albums_ID`) VALUES (@title, @number, @videoURL, @lyrics, @albumID)", connection);
            command.Parameters.AddWithValue("@title", track.Name);
            command.Parameters.AddWithValue("@number", track.Number);
            command.Parameters.AddWithValue("@videoURL", track.VideoURL);
            command.Parameters.AddWithValue("@lyrics", track.Lyrics);
            command.Parameters.AddWithValue("@albumID", track.AlbumID);
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return rows;
        }
        internal int updateTrack(Track track, int trackID) {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new("UPDATE `tracks` SET `title`= @title,`number`= @number,`video_url`= @videoURL,`lyrics`= @lyrics,`albums_ID`= @albumID WHERE tracks.ID = @trackID", connection);
            command.Parameters.AddWithValue("@title", track.Name);
            command.Parameters.AddWithValue("@number", track.Number);
            command.Parameters.AddWithValue("@videoURL", track.VideoURL);
            command.Parameters.AddWithValue("@lyrics", track.Lyrics);
            command.Parameters.AddWithValue("@albumID", track.AlbumID);
            command.Parameters.AddWithValue("@trackID", track.ID);
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return rows;
        }
        internal int deleteTrack(int trackID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM tracks WHERE tracks.ID = @trackID", connection);
            command.Parameters.AddWithValue("@trackID", trackID);
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return rows;
        }
    }
}
