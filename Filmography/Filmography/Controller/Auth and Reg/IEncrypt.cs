using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmography.Controller.Auth_and_Reg
{
    public interface IEncrypt
    {
        Task<string> HashPassword(string password, string salt);
    }
}
