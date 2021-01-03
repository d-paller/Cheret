using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Data.Model.Interfaces
{
    public interface ICheretDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string WebsiteCollectionName { get; set; }
    }
}
