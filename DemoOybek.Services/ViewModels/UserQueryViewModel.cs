using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOybek.Services.ViewModels
{
    public class UserQueryViewModel
    {
        public long? UserId { get; set; }
        
        public string OrderBy { get; set; }

        public int? Offset { get; set; }
        public int? Limit { get; set; }
        public int? PageNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string EmailDomain { get; set; }
    }
}
