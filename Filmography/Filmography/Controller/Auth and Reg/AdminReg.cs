using Filmography.Controller.Auth_and_Reg;
using Filmography.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmography.Controller
{
    public class AdminReg
    {
        private protected Filmography.Model.Filmography _context;
        private readonly Encrypt _encrypt = new Encrypt();

        //singlton start
        public static AdminReg instance { get => AdminRegCreate.instance; }
        private AdminReg()
        {
            _context = new Filmography.Model.Filmography();
        }
        private class AdminRegCreate
        {
            static AdminRegCreate() { }
            internal static readonly AdminReg instance = new AdminReg();
        }
        //singlton end

        public async Task<Users> AddUser(Users user)
        {
            user.Salt = Guid.NewGuid().ToString();
            user.Password = await _encrypt.HashPassword(user.Password, user.Salt);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<Users> CheckUser(string login)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Login == login);

        }

        public async Task<Users> CheckEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.E_mail == email);
        }


    }
}
