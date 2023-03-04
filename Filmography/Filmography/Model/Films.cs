//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Films
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Films()
        {
            this.Display = new HashSet<Display>();
            this.Translations = new HashSet<Translations>();
            this.Workers = new HashSet<Workers>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public Nullable<int> YearRelease { get; set; }
        public Nullable<int> Genres_FK { get; set; }
        public Nullable<int> Country_FK { get; set; }
        public Nullable<int> Viewers { get; set; }
        public Nullable<double> Rating { get; set; }
        public Nullable<decimal> Cost { get; set; }
    
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Display> Display { get; set; }
        public virtual Genres Genres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Translations> Translations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Workers> Workers { get; set; }

        public override string ToString()
        {
            return $"{Name} - {YearRelease} - {Genres.Genre} - {Country.CountryManufacture} - {Viewers} - {Rating} - {Cost}";
        }
    }
}