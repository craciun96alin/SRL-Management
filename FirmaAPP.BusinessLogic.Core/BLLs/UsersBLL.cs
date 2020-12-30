using FirmaAPP.BusinessObject;
using FirmaAPP.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.Core
{
    public class UsersBLL
    {
        public List<string> GetAllUsersName ()
        {
            UsersDAL usersDAL = new UsersDAL();
            List<string> names = new List<string>();

            var userList = usersDAL.GetAllUsers();
            foreach(User user in userList)
            {
                names.Add(user.FirstName + " " + user.LastName);
            }

            return names;
        }

        public User GetUserByName(string userName)
        {
            UsersDAL usersDAL = new UsersDAL();
            string[] name = userName.Split(' ');
            User currentUser = usersDAL.GetUserByName(name[0]);
            return currentUser;
        }

        public void UpdateLastLogin(int userID)
        {
            UsersDAL usersDAL = new UsersDAL();
            usersDAL.UpdateUserLastLogin(userID);
        }
    }
}
