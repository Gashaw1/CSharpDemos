using DataAccessLayerPro;
using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayerPro
{
    public class UserBusinessLayer
    {
        Users user { get; set; }
        List<Users> users { get; set; }
        DataTable dt { get; set; }
        DataAccess da { get; set; }
        public IEnumerable<Users> userss
        {
            get
            {
                return GetUsers();
            }

        }
        //from database
        public List<Users> GetUsers()
        {
            users = new List<Users>();
            da = new DataAccess();

            dt = new DataTable();
            //stor data table
            dt = da.ReturnData().Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                user = new Users();

                user.UserID = Convert.ToInt32(row["UserID"]);

                user.UserName = row["UserName"].ToString();

                user.UserEmail = row["UserEmail"].ToString();

                users.Add(user);

            }
            return users;
        }
        //from dataset
        public List<Users> GetUsersDataset()
        {
            users = new List<Users>();
            da = new DataAccess();

            dt = new DataTable();
            //stor data table 
            dt = da.ReturnCachedDatq().Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                user = new Users();
                user.UserID = Convert.ToInt32(row["UserID"]);
                user.UserName = row["UserName"].ToString();
                user.UserEmail = row["UserEmail"].ToString();
                users.Add(user);

            }
            return users;
        }
        //Update cached data
        public void UpdateUserInCach(Users user)
        {
            da = new DataAccess();
            user = new Users();
            da.UpdateCachedData(user.UserID, user.UserName, user.UserEmail, user.UserPassword);
        }
        //Update Database from cached data
        protected void UpdateDataBaseFromCached()
        {
            da = new DataAccess();
            da.UpdateDataBase();
        }
        //get use by id
        public Users GetUsers(int id)
        {
            da = new DataAccess();
            dt = new DataTable();
            //stor data table       q
            dt = da.ReturnData(id).Tables[0];
            user = new Users();
            foreach (DataRow row in dt.Rows)
            {
                user.UserID = Convert.ToInt32(row["UserID"]);
                user.UserName = row["UserName"].ToString();
                user.UserEmail = row["UserEmail"].ToString();
            }
            return user;
        }
        //adding new user
        public bool AddUser(Users newUser)
        {
            da = new DataAccess();
            user = new Users();
            user = newUser;
            bool insertResult = da.InsertData(user.UserName, user.UserEmail, user.UserPassword);

            if (insertResult == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool UpdateUser(Users user)
        {
            bool updaeResult = false;
            da = new DataAccess();
            this.user = new Users();
            this.user = user;
            updaeResult = da.UpdatDataBase(this.user.UserID, this.user.UserName, this.user.UserEmail, this.user.UserPassword);
            if (updaeResult == true)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
