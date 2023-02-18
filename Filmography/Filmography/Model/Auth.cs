using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmography.Model
{
    public class Auth : IAuth
    {
        private readonly Filmography _context;
        private readonly Encrypt _encrypt = new Encrypt();
        //singlton start
        public static Auth instance { get => AuthCreate.instance; }
        private Auth()
        {
            _context = new Filmography();
        }
        private class AuthCreate
        {
            static AuthCreate() { }
            internal static readonly Auth instance = new Auth();
        }
        //singlton end
        public async Task<User> AddUser(User user)
        {
           

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return _context.Users.Last();
        }

        public async Task<User> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUser(string login)
        {

            throw new NotImplementedException();
        }
    }
}
