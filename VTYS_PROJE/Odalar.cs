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
    
    public partial class Odalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Odalar()
        {
            this.OdaKayitlari = new HashSet<OdaKayitlari>();
            this.Rezervasyonlar = new HashSet<Rezervasyonlar>();
        }
    
        public int id { get; set; }
        public string OdaNo { get; set; }
        public Nullable<int> OdaKisiSayisi { get; set; }
        public string OdaDurumu { get; set; }
        public string OdaTipi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OdaKayitlari> OdaKayitlari { get; set; }
        public virtual PremiumOda PremiumOda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervasyonlar> Rezervasyonlar { get; set; }
        public virtual StandartOda StandartOda { get; set; }
        public virtual VipOda VipOda { get; set; }
    }
}