using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentThings.Models;
using RentThings.Models.Tag;

namespace RentThings.Interfaces
{
    interface IAccountService
    {
        User[] GetAllUsers();
        User GetUserById(int id);
        bool UpdateUserById(int id);
        bool updateUser(User updateUser);

        bool VerifyUserByLoginAndPassword(LoginTag loginModel);
    }
}
