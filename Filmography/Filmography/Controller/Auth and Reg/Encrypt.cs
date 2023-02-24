using Filmography.Controller.Auth_and_Reg;
using Pbkdf2;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmography.Model
{
    public class Encrypt:IEncrypt
    {

        public async Task<string> HashPassword(string password, string salt)
        {
            string res = "";
            await Task.Run(() =>
            {
                res = Convert.ToBase64String(Pbkdf2.Pbkdf2.HashData("SHA512", Encoding.ASCII.GetBytes(password), Encoding.ASCII.GetBytes(salt), 350000, 64));
            });
            return res;
        }
    }
}
