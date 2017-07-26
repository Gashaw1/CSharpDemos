using DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MVC_Pro.Models
{
    public class Users : DataAccess
    {
        private int UserID { get; set; }
        private string UserName { get; set; }
        private string UserPassword { get; set; }
        private string UserEmail { get; set; }
        private Users user { get; set; }
        private List<Users> users { get; set; }

        public Users()
        { }
        public List<Users> ReturnUsers()
        {
            users = new List<Users>();
            user = new Users();
          

            foreach (DataRow row in user.ReturnData().Rows)
            {
                user = new Users();
                user.UserID = Convert.ToInt32(row["UserID"]);
                user.UserName = row["UserName"].ToString();
                user.UserEmail = row["UserEmail"].ToString();
                users.Add(user);
            }
            return users;
        }
        //user login
        public Users ReturnUser(int id)
        {
            user = new Users();

            foreach (DataRow row in user.ReturnData(id).Rows)
            {
                user.UserID = Convert.ToInt32(row["UserID"]);
                user.UserName = row["UserName"].ToString();
                user.UserEmail = row["UserEmail"].ToString();
                user.UserPassword = row["UserPassword"].ToString();

            }

            return user;
        }
    }
}