using Filmography.Model;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Filmography.Controller
{
    public class RequestClass
    {
        private readonly Filmography.Model.Filmography _context;
        public static RequestClass instance { get => RequestClassCreate.instance; }

        private RequestClass()
        {
            _context = new Filmography.Model.Filmography();
        }
        private class RequestClassCreate
        {
            static RequestClassCreate() { }
            internal static readonly RequestClass instance = new RequestClass();
        }

        public async Task<List<Films>> GetFilms()
        {
            return await _context.Films.ToListAsync();
        }
        public async Task<Films> GetFilms(string film)
        {
            return await _context.Films.FirstOrDefaultAsync(x=>x.Name == film);
        }
        public async Task<List<Genres>> GetGenres()
        {
            return await _context.Genres.ToListAsync();
        }
        public async Task<List<Country>>GetCountries()
        {
            return await _context.Country.ToListAsync();
        }
        public async Task<List<Humans>>GetHumans()
        {
            return await _context.Humans.ToListAsync();
        }
        public async Task<List<Workers>> GetPresident()
        {
            var president = await _context.Workers.Include(x => x.Humans).ToListAsync();
            president = (from x in president
                         where x.Post == "Президент"
                         select x).ToList();
            return president;
        }

        public async Task<Films> Request1(int index)
        {
            Films film = new Films();
            await Task.Run(() =>
            {
                switch (index)
                {
                    case 0:
                        film = _context.Films.MaxBy((x) => x.Cost);
                        break;
                    case 1:
                        film = _context.Films.MaxBy((x) => x.Viewers);
                        break;
                    case 2:
                        film = _context.Films.MinBy((x) => x.YearRelease);
                        break;
                }
            });
            return film;
        }

        public async Task<List<Films>> Request2(string genre, string film, string country)
        {
            var filmm = await GetFilms(film);
            var films = await GetFilms();
            films = (from x in films
                     where x.Genres.Genre == genre
                     && x.Country.CountryManufacture == country
                     && x.Cost < filmm.Cost
                     select x).ToList();
            return films;
                        
        }

        public async Task<List<Films>> Request3(string year, string country, decimal min, decimal max)
        {
            var films = await GetFilms();
            films = (from x in films
                     where x.YearRelease.ToString() == year
                     && x.Country.CountryManufacture == country
                     && x.Cost>=min && x.Cost<=max 
                     select x).ToList();
            return films;
        }

        public async Task<List<Workers>> Request6()
        {
            var humans = await _context.Workers.Include(x=>x.Humans).ToListAsync();
            humans = (from x in humans
                          where x.Humans.Gender.StartsWith("м") && x.Post.StartsWith("Актер") || x.Humans.Address.StartsWith("г. Париж") && x.Post.StartsWith("Актер")
                          select x).ToList();
                return humans;
        }
        public async Task<List<Workers>> Request7()
        {
            var humans = await _context.Workers.Include(x => x.Humans).ToListAsync();
            humans = (from x in humans
                      where x.Humans.Gender.StartsWith("ж") && x.Post == "Актер" &&  x.Humans.Income > 100000
                      || x.Humans.Gender.StartsWith("ж") && x.Post == "Президент"  &&  x.Humans.Income > 100000
                      || x.Humans.Gender.StartsWith("ж") && x.Post == "Продюсер" && x.Humans.Income > 100000
                      select x).ToList();

            return humans;
        }
        public async Task<List<Workers>> Request8(string film)
        {
            var humans = await _context.Workers.ToListAsync();
            humans = (from x in humans
                      where (x.Films_FK != null && x.Films.Name == film) && x.Humans.Gender.StartsWith("м") && x.Post == "Актер"
                      select x).ToList();
            return humans; 
        }

        public async Task<List<Workers>> Request9(string firstName, string lastName, string year)
        {
            var films = await _context.Workers.Include(x => x.Humans).Include(x => x.Films).ToListAsync();
            films = (from x in films
                     where x.Post == "Актер" && x.Humans.FirstName == firstName  && x.Humans.LastName == lastName && x.Films.YearRelease.ToString() == year
                     select x).ToList();

            return films;
        }

        public async Task<List<Workers>> Request10(string firstName, string lastName)
        {
            var humans = await _context.Workers.Include(x => x.Humans).ToListAsync();
            var income = humans.Where(x => x.Humans.FirstName == firstName).Where(x => x.Humans.LastName == lastName).FirstOrDefault();
            humans = (from x in humans
                      where x.Humans.Income > income.Humans.Income && x.Humans.FirstName != income.Humans.FirstName && x.Humans.LastName != income.Humans.LastName && x.Post == "Актер"
                      select x).ToList();
            return humans;
        }







    }
}