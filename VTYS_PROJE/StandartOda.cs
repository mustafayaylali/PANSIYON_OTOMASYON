//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VTYS_PROJE
{
    using System;
    using System.Collections.Generic;
    
    public partial class StandartOda
    {
        public int OdaId { get; set; }
        public string OdaUcret { get; set; }
        public string OzellikTv { get; set; }
        public string OzellikBuzdolabi { get; set; }
        public string OzellikOzelServis { get; set; }
        public string OzellikBilgisayar { get; set; }
        public string OzellikCamasirMakinesi { get; set; }
        public string OzellikBulasikMakinesi { get; set; }
        public string OzellikFirin { get; set; }
    
        public virtual Odalar Odalar { get; set; }
    }
}