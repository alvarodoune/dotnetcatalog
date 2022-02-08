using System;
namespace Catalog.Settings
{
    public class MongoDbSettings
    {
        // docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=Pass#word1 mongo
        public string Host { get; set; }

        public string Port { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public string ConnectionString {
            get {
                return $"mongodb://{User}:{Password}@{Host}:{Port}";
            }
        }
    }
}
