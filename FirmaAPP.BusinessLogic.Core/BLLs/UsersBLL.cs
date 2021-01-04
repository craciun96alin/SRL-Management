using FirmaAPP.BusinessObject;
using FirmaAPP.DataAccess;
using System;
using System.Collections.Generic;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.Core
{
    public class UsersBLL
    {
        private bool VerifyInputData(User User)
        {
            UsersDAL fDAL = new UsersDAL();
            if (User.FirstName == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            if (User.LastName == string.Empty && User.UserRole != Enums.UserRole.Admin)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            if (User.Password == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyPasswordToBeCompleted);

            User u = fDAL.GetUserByName(User.FirstName + " " + User.LastName);
            if (u != null && u.UserID != User.UserID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }
        public List<string> GetAllUsersName ()
        {
            try
            {
                UsersDAL usersDAL = new UsersDAL();
                List<string> names = new List<string>();
                var userList = usersDAL.GetAllUsers();
                foreach (User user in userList)
                {
                    names.Add(user.FirstName + " " + user.LastName);
                }
                return names;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<User> GetAllUsers()
        {
            try
            {
                UsersDAL usersDAL = new UsersDAL();
                List<string> names = new List<string>();
                var userList = usersDAL.GetAllUsers();

                return userList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddUser(User user)
        {
            try
            {
                VerifyInputData(user);

                UsersDAL fDAL = new UsersDAL();
                fDAL.AddUser(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetUserByName(string userName)
        {
            try
            {
                UsersDAL usersDAL = new UsersDAL();
                User currentUser = usersDAL.GetUserByName(userName);
                return currentUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                VerifyInputData(user);

                UsersDAL fDAL = new UsersDAL();
                fDAL.UpdateUser(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteUser(User user)
        {
            try
            {
                VerifyInputData(user);

                UsersDAL fDAL = new UsersDAL();
                fDAL.DeleteUser(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateLastLogin(int userID)
        {
            try
            {
                UsersDAL usersDAL = new UsersDAL();
                usersDAL.UpdateUserLastLogin(userID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetUserById(int UserId)
        {
            try
            {
                UsersDAL usersDAL = new UsersDAL();
                User currentUser = usersDAL.GetUserById(UserId);
                return currentUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
