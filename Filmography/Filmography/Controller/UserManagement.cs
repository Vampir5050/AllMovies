using Filmography.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Filmography.Controller
{
    public class UserManagement
    {
        private readonly Filmography.Model.Filmography _context;


        
        //singlton start
        public static UserManagement instance { get => UserManagementCreate.instance; }
        private UserManagement()
        {
            _context = new Filmography.Model.Filmography();
        }
        private class UserManagementCreate
        {
            static UserManagementCreate() { }
            internal static readonly UserManagement instance = new UserManagement();
        }
        //singlton end

        public async Task<List<Films>> LoadFim()
        {
           return await _context.Films.ToListAsync();
        }

        public List<Films> Sortdescending(List<Films> films, int index)
        {
            
            switch (index)
            {
                case 1:
                    films = (from x in films
                             orderby x.YearRelease descending
                             select x).ToList();
                    break;
                case 2:
                    films = (from x in films
                             orderby x.Name descending
                             select x).ToList();
                    break;
                case 3:
                    films = (from x in films
                             orderby x.Cost descending
                             select x).ToList();
                    break;
                case 4:
                    films = (from x in films
                             orderby x.Country?.CountryManufacture descending
                             select x).ToList();
                    break;

            }
            return films;
           
        }
        public List<Films> SortAscending(List<Films> films, int index)
        {
            switch (index)
            {
                case 1:
                    films = (from x in films
                             orderby x.YearRelease 
                             select x).ToList();
                    break;
                case 2:
                    films = (from x in films
                             orderby x.Name 
                             select x).ToList();
                    break;
                case 3:
                    films = (from x in films
                             orderby x.Cost 
                             select x).ToList();
                    break;
                case 4:
                    films = (from x in films
                             orderby x.Country?.CountryManufacture 
                             select x).ToList();
                    break;

            }
            return films;
        }



    }
}