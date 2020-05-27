using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using RentThings.Context;
using RentThings.Interfaces;
using RentThings.Models;
using RentThings.Models.Tag;

namespace RentThings.Services
{
    public class EntityAccountService : IAccountService
    {
        public User[] GetAllUsers()
        {
            using (var db = new RentThingsContext())
            {
                return db.Users.Where(m => m.IsDeleted == false).ToArray();
            }
        }

        public User GetUserById(int id)
        {
            using (var db = new RentThingsContext())
            {
                return db.Users.FirstOrDefault(m => m.Id == id);
            }
        }

        public bool RemoveUserById(int id)
        {
            using (var db = new RentThingsContext())
            {
                var user = GetUserById(id);
                if (user == null) return false;
                user.IsDeleted = true;
                db.Users.AddOrUpdate(user);
                db.SaveChanges();
                return true;
            }
        }

        public bool updateUser(User updateUser)
        {
            using (var db = new RentThingsContext())
            {
                db.Users.AddOrUpdate(updateUser);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateUserById(int id)
        {
            throw new NotImplementedException();
        }

        public bool VerifyUserByLoginAndPassword(LoginTag loginModel)
        {
            using (var db=new RentThingsContext())
            {
                var user=db.Users.FirstOrDefault(m=>m.Login==loginModel.Login && m.Password == loginModel.Password);
                if (user != null)
                {
                    return true;
                }

                return false;
            }
        }
    }
}