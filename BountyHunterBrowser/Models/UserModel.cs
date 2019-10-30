using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BountyHunterBrowser.Models
{
    public class UserModel
    {
        public ApplicationUser user { get; set; }
        public List<string> roles { get; set; }
    }
}