﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Filmography.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Filmography : DbContext
    {
        public Filmography()
            : base("name=Filmography")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmStudio> FilmStudios { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Human> Humans { get; set; }
        public virtual DbSet<Display> Displays { get; set; }
        public virtual DbSet<Translation> Translations { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}