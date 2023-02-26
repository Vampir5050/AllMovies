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

        public async Task<List<Film>> GetFilms()
        {
            return await _context.Films.ToListAsync();
        }
        public async Task<Film> GetFilms(string film)
        {
            return await _context.Films.FirstOrDefaultAsync(x=>x.Name == film);
        }
        public async Task<List<Genre>> GetGenres()
        {
            return await _context.Genres.ToListAsync();
        }
        public async Task<List<Country>>GetCountries()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<Film> Request1(int index)
        {
            Film film = new Film();
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

        public async Task<List<Film>> Request2(string genre, string film, string country)
        {
            var filmm = await GetFilms(film);
            var films = await GetFilms();
            films = (from x in films
                     where x.Genre.Genre1 == genre
                     && x.Country.CountryManufacture == country
                     && x.Cost < filmm.Cost
                     select x).ToList();
            return films;
                        
        }

        public async Task<List<Film>> Request3(string year, string country, decimal min, decimal max)
        {
            var films = await GetFilms();
            films = (from x in films
                     where x.YearRelease.ToString() == year
                     && x.Country.CountryManufacture == country
                     && x.Cost>=min && x.Cost<=max 
                     select x).ToList();
            return films;
        }

            




    }
}