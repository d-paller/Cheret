using System;

namespace Cheret.Model
{
    public class User
    {
        public int UserId { get; set; }

        public int SiteId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
