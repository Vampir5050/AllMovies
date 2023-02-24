using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmography.Model
{
    public class Reg
    {
        private readonly Filmography _context;
        private readonly Encrypt _encrypt = new Encrypt();
        
        
        //singlton start
        public static Reg instance { get => RegCreate.instance; }
        private Reg()
        {
            _context = new Filmography();
        }
        private class RegCreate
        {
            static RegCreate() { }
            internal static readonly Reg instance = new Reg();
        }
        //singlton end


        public async Task<User> AddUser(User user)
        {
            user.Salt = Guid.NewGuid().ToString();
           user.Password = await _encrypt.HashPassword(user.Password, user.Salt);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> CheckUser(string login)
        {
            return await _context.Users.FirstOrDefaultAsync(u=>u.Login==login);
            
        }

        public async Task<User> CheckEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.E_mail == email);
        }

      
    }
}
