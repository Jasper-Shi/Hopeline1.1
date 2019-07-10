using Hopeline.DataAccess.Entities.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hopeline.DataAccess.Entities
{
    enum AccountType
    {
        Admin,
        Mentor,
        User,
        Guest
    }
    public class HopelineUser : IdentityUser
    {
        public HopelineUser()
        {
            dataAdded = System.DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }
        string dataAdded { get; set; }

        AccountType accountType { get; set; }

    }
}
