using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Demo.UserDBContext
{
    public class UserDBContext : DbContext
    {
        public DbSet<Users> users { get; set; }
    }
}