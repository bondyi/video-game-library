using System.Xml.Serialization;
using Models.VideoGameDatabaseModel;
using System.IO;

namespace Models.RepositoryModel
{
    public class VideoGameDatabaseRepository
    {
        private const string _connectionString = "data/database.xml";
        private readonly XmlSerializer _serializer;

        internal static string Path => _connectionString;

        internal VideoGameDatabaseRepository() => _serializer = new XmlSerializer(typeof(VideoGameDatabase));

        internal void Serialize(VideoGameDatabase database)
        {
            if (!Directory.Exists("/data")) Directory.CreateDirectory("data");
            
            File.WriteAllText(Path, string.Empty);
            using (var fs = new FileStream(Path, FileMode.Open))
            {
                _serializer.Serialize(fs, database);
            }
        }

        internal VideoGameDatabase Deserialize()
        {
            using (var fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                return (VideoGameDatabase)_serializer.Deserialize(fs);
            }
        }
    }
}
