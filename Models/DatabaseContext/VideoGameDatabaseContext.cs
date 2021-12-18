using System.Xml.Serialization;
using Models.VideoGameRepositoryModel;
using System.IO;

namespace Models.DatabaseContext
{
    public class VideoGameDatabaseContext
    {
        private const string _connectionString = "data/database.xml";
        private readonly XmlSerializer _serializer;

        internal static string Path => _connectionString;

        internal VideoGameDatabaseContext() => _serializer = new XmlSerializer(typeof(VideoGameRepository));

        internal void Serialize(VideoGameRepository repository)
        {
            if (!Directory.Exists("/data")) Directory.CreateDirectory("data");
            
            File.WriteAllText(Path, string.Empty);
            using (var fs = new FileStream(Path, FileMode.Open))
            {
                _serializer.Serialize(fs, repository);
            }
        }

        internal VideoGameRepository Deserialize()
        {
            using (var fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                return (VideoGameRepository)_serializer.Deserialize(fs);
            }
        }
    }
}
