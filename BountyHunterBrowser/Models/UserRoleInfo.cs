﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BountyHunterBrowser.Models
{
    public class UserRoleInfo
    {
        public ApplicationUser User { set; get; }
        public List<string> Roles { set; get; }
    }
}