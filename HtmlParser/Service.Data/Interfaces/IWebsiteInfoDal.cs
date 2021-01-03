using Service.Data.Model.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Data.Interfaces
{
    public interface IWebsiteInfoDal
    {
        WebsiteInformation GetWebsiteInfoBySiteName(string siteName);
    }
}
