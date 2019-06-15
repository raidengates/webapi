using Identity.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Users.Framework.Services.Interface
{
    public interface IUserServices
    {
        User GetUser(string username);
        List<Password> GetPasswords(int UserID);
        Task Create(LoginAttempt _loginAttempt);
    }
}
