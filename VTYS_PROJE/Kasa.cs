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
    
    public partial class Kasa
    {
        public int id { get; set; }
        public Nullable<int> OdaKayitId { get; set; }
        public string Gelir { get; set; }
    
        public virtual OdaKayitlari OdaKayitlari { get; set; }
    }
}
