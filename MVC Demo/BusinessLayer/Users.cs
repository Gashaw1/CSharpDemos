using DataAccessLayers;

using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayer
{
    public class Users : DataAccess
    {
        protected int UserID { get; set; }
        public string UserName { get; set; }
        protected string UserPassword { get; set; }
        public string UserEmail { get; set; }
        protected Users user { get; set; }
        protected List<Users> users { get; set; }

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
