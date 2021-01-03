using MongoDB.Driver;
using Service.Data.Model.Collections;
using Service.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Data
{
    internal class BaseDal
    {
        protected readonly IMongoCollection<WebsiteInformation> _websiteInfo;

        public BaseDal(ICheretDatabaseSettings dbSettings)
        {
            var client = new MongoClient(dbSettings.ConnectionString);
            var database = client.GetDatabase(dbSettings.DatabaseName);

            _websiteInfo = database.GetCollection<WebsiteInformation>(dbSettings.WebsiteCollectionName);
        }
    }
}
