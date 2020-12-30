using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class UsersDAL
    {
        DBContext context = new DBContext();

        public List<User> GetAllUsers()
        {
            var list = context.Users.ToList();
            return list;
        }

        public User GetUserByName(string userName)
        {
            User currentUser = context.Users.
                Where(name => name.FirstName == userName)
                .FirstOrDefault();
            return currentUser;
        }

        public void UpdateUserLastLogin(int userID)
        {
            var user = context.Users.Where(u => u.UserID == userID)
                .FirstOrDefault();
            user.LastLogin = DateTime.Now;
            context.SaveChanges();
        }

        public User GetUserById(int userID)
        {
            var user = context.Users.Where(n => n.UserID == userID).FirstOrDefault();
            return user;
        }
    }
}
