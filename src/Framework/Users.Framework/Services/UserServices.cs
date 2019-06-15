using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Identity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Users.Framework.Services.Interface;
using System.Linq;


namespace Users.Framework.Services
{
    public class UserServices : IUserServices
    {
        IdentityContext _identityContext;
        private readonly DbSet<Password> _password;
        private readonly DbSet<User> _user;
        private readonly DbSet<LoginAttempt> _loginAttempt;

        public UserServices(IdentityContext identityContext)
        {
           
            _identityContext = identityContext;
            _password = _identityContext.Set<Password>();
            _user = _identityContext.Set<User>();
            _loginAttempt = _identityContext.Set<LoginAttempt>();
        }
        public  List<Password> GetPasswords(int UserID)
        {
            return  _password.Where(x => x.UserId == UserID).ToList();
        }

        public User GetUser(string username)
        {
            return _user.Where(x => x.AccountName == username).FirstOrDefault();
        }

        public async Task Create(LoginAttempt _loginAttempt)
        {
            this._loginAttempt.Add(_loginAttempt);
            bool isSaved = false;

            while (!isSaved)
            {
                try
                {
                    await _identityContext.SaveChangesAsync();
                    isSaved = true;
                }
                catch(DbUpdateConcurrencyException ex)
                {
                    foreach (var entry in ex.Entries)
                    {
                        if (entry.Entity is LoginAttempt)
                        {
                            var databaseValues = entry.GetDatabaseValues();
                            if (databaseValues != null)
                            {
                                entry.OriginalValues.SetValues(databaseValues);
                                CalculateNewBalance();
                                void CalculateNewBalance()
                                {
                                   
                                }
                            }
                            else
                            {
                                throw new NotSupportedException();
                            }
                        }

                    }
                }
            }
        }


    }
}
