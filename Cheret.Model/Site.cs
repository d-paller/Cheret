using System;
using System.Collections.Generic;
using System.Text;

namespace Cheret.Model
{
    public class Site
    {
        public int SiteId { get; set; }

        public int AdminId { get; set; }

        public string SiteAddress { get; set; }

        public string ServerUserName { get; set; }

        public string ServerPassword { get; set; }

    }
}
