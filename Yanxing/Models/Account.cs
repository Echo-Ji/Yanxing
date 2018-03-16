using SQLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yanxing.Models
{
    [SQLinqTable("Account")]
    public class Account
    {
        [SQLinqColumn("UserID")]
        public Guid UserID { get; set; }

        [SQLinqColumn("Username")]
        public string Username { get; set; }

        [SQLinqColumn("Password")]
        public string Password { get; set; }

    }
}