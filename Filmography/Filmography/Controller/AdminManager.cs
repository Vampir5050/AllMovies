using Filmography.Model;
using Filmography.View.AdminView.AddView;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Filmography.Controller
{
    public class AdminManager
    {
        private readonly Filmography.Model.Filmography _context;
        public static AdminManager instance { get => AdminManagerCreate.instance; }

        private AdminManager()
        {
            _context = new Filmography.Model.Filmography();
        }
        private class AdminManagerCreate
        {
            static AdminManagerCreate() { }
            internal static readonly AdminManager instance = new AdminManager();
        }

        //методы добавления start
        public async Task<Genres> AddGanres(Genres genres)
        {
            var check = await _context.Genres.FirstOrDefaultAsync(x => x.Genre == genres.Genre);
            if (check != null) return null;
            _context.Genres.Add(genres);
            await _context.SaveChangesAsync();
            return genres;
        }
        public async Task<Country> AddCountry(Country country)
        {
            var check = await _context.Country.FirstOrDefaultAsync(x => x.CountryManufacture == country.CountryManufacture);
            if (check != null) return null;
            _context.Country.Add(country);
            await _context.SaveChangesAsync();
            return country;
        }
        public async Task<Films> AddFilms(Films films)
        {
            var filmsCol = await GetFilms();
            filmsCol = (from x in _context.Films
                        where x.Name == films.Name && x.YearRelease == films.YearRelease
                        select x).ToList();
            if (filmsCol.Count > 0) return null;
            _context.Films.Add(films);
            await _context.SaveChangesAsync();
            return films;




        }
        public async Task<Translations>AddTransleyt(Translations translations)
        {
            _context.Translations.Add(translations);
            await _context.SaveChangesAsync();
            return translations;
        }
        public async Task<Humans> AddHumans(Humans human)
        {
            var humanCol = await GetHumans();
            humanCol = (from x in humanCol
                        where x.FirstName == human.FirstName && x.LastName == human.LastName && x.Address == human.Address
                        select x).ToList();
            if (humanCol.Count != 0) return null;
            _context.Humans.Add(human);
            await _context.SaveChangesAsync();
            return human;
        }
        public async Task<Display>AddDisplay(Display displays)
        {
            _context.Display.Add(displays);
            await _context.SaveChangesAsync();
            return displays;
        }
        //методы добавления end


        //методы проверок start
        public async Task<Films> ChangeFilms(Films filmsChange)
        {
            var film = await ReturnFilms(filmsChange.Name);
            film = filmsChange;
            await _context.SaveChangesAsync();
            return film;
        }
        public async Task<Films> CheckFilmsTrancleyt(string name)
        {
            var films = await _context.Films.FirstOrDefaultAsync(x => x.Name == name);
            var transleyt = await _context.Translations.Include(x => x.Films).ToListAsync();
            transleyt = (from x in transleyt
                         where x.Films_FK == films.id
                         select x).ToList();
            if (transleyt.Count != 0) return null;
            else return films;
        }
        public async Task<Films>CheckFilmsDisplay(string name)
        {
            var films = await _context.Films.FirstOrDefaultAsync(x => x.Name == name);
            var display = await _context.Display.Include(x => x.Films).ToListAsync();
            display = (from x in display
                       where x.Films_FK == films.id
                         select x).ToList();
            if (display.Count != 0) return null;
            else return films;
        }
        //методы проверок end


        //методы удаления start
        public async Task<bool> RemoveTransleytFilms(string name)
        {
            var films = await _context.Films.FirstOrDefaultAsync(x => x.Name == name);
            var transleyt = await _context.Translations.FirstOrDefaultAsync(x => x.Films_FK == films.id);
            if (transleyt == null) return false;
            _context.Translations.Remove(transleyt);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool>RemoveFilms(string name)
        {
            var films = await ReturnFilms(name);
            if (films == null) return false;
            await RemoveTransleytFilms(films.Name);
            await RemoveDisplayFilms(films.Name);
            _context.Films.Remove(films);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool>RemoveDisplayFilms(string name)
        {
            var films = await _context.Films.FirstOrDefaultAsync(x => x.Name == name);
            var dispaly = await _context.Display.FirstOrDefaultAsync(x => x.Films_FK == films.id);
            if (dispaly == null) return false;
            _context.Display.Remove(dispaly);
            await _context.SaveChangesAsync();
            return true;
        }
        //методы удаления end

        //методы получения коллекции с базы start
        public async Task<List<Country>> GetCountry()
        {
            return await _context.Country.ToListAsync();
        }
        public async Task<List<Genres>> GetGenres()
        {
            return await _context.Genres.ToListAsync();
        }
        public async Task<List<Films>> GetFilms()
        {
            return await _context.Films.ToListAsync();
        }
        public async Task<List<Humans>>GetHumans()
        {
            return await _context.Humans.ToListAsync();
        }
        public async Task<Films> ReturnFilms(string name)
        {
            return await _context.Films.FirstOrDefaultAsync(x => x.Name == name);
        }
        //методы получения коллекции с базы end





    }
}
