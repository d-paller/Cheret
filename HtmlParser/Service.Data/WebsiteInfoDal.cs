using MongoDB.Driver;
using Service.Data.Interfaces;
using Service.Data.Model.Collections;
using Service.Data.Model.Interfaces;
using System;
using System.Collections;

namespace Service.Data
{
    internal class WebsiteInfoDal : BaseDal, IWebsiteInfoDal
    {
        public WebsiteInfoDal(ICheretDatabaseSettings databaseSettings) : base(databaseSettings) { }

        public WebsiteInformation GetWebsiteInfoBySiteName(string siteName)
        {
            return _websiteInfo.Find(site => site.Name == siteName)
                .FirstOrDefault();
        }
    }
}
