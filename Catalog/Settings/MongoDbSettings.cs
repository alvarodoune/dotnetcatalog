using System;
namespace Catalog.Settings
{
    public class MongoDbSettings
    {
        // docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo
        public string Host { get; set; }

        public string Port { get; set; }

        public string ConnectionString {
            get {
                return $"mongodb://{Host}:{Port}";
            }
        }
    }
}
