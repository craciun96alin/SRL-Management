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
            string[] name = userName.Split(' ');
            User currentUser = context.Users.
                Where(u => u.FirstName == name[0] &&( u.LastName == name[1] || u.LastName == null))
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

        public void AddUser(User user)
        {
            context.Add<User>(user);
            context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            context.Update<User>(user);
            context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            context.Remove<User>(user);
            context.SaveChanges();
        }
    }
}
