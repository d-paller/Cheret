using Service.Data.Model.Interfaces;
using System;

namespace Service.Data.Model
{
    public class CheretDatabaseSettings : ICheretDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string WebsiteCollectionName { get; set; }
    }
}
