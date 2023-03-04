using Filmography.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmography.Controller
{
    public class Auth
    {
        private readonly Filmography.Model.Filmography _context;
        private readonly Encrypt _encrypt = new Encrypt();

        //singlton start
        public static Auth instance { get => AuthCreate.instance; }
        private Auth()
        {
            _context = new Filmography.Model.Filmography();
        }
        private class AuthCreate
        {
            static AuthCreate() { }
            internal static readonly Auth instance = new Auth();
        }
        //singlton end


        public async Task<Users> CheckUser(string login)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Login == login);

        }

        public async Task<bool> Login(string login, string password)
        {
            var user = await CheckUser(login);
            try
            {
                if (user.Password == await _encrypt.HashPassword(password, user.Salt)) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }



        }
    }
}