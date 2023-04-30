using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase
{
    internal class Settings
    {
        public string connectionString { get; set; }
        public void Read() {
            try
            {
                using (StreamReader reader = new StreamReader("MusicDatabase.txt"))
                {
                    connectionString = reader.ReadLine();
                }
                if (connectionString == null || connectionString == "")
                    connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music;";
            }
            catch (Exception)
            {
                // ignore
            }
        }
        public void Write() {
            using (StreamWriter writer = new StreamWriter("MusicDatabase.txt"))
            {
                writer.WriteLine(connectionString);
            }
        }
    }
}