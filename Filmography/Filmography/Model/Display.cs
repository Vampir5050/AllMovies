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
    
    public partial class Display
    {
        public int id { get; set; }
        public string Showing { get; set; }
        public Nullable<int> Films_FK { get; set; }
    
        public virtual Film Film { get; set; }
    }
}