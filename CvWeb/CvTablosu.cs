//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CvWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class CvTablosu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CvTablosu()
        {
            this.MezunTablosu = new HashSet<MezunTablosu>();
        }
    
        public int CvId { get; set; }
        public int OkulId { get; set; }
        public int FakulteId { get; set; }
        public string Bolum { get; set; }
        public int GenelOrt { get; set; }
        public int SehirId { get; set; }
        public string Cinsiyet { get; set; }
        public int StajId { get; set; }
        public int ReferansId { get; set; }
    
        public virtual FakulteTablosu FakulteTablosu { get; set; }
        public virtual OkulTablosu OkulTablosu { get; set; }
        public virtual ReferansTablosu ReferansTablosu { get; set; }
        public virtual SehirTablosu SehirTablosu { get; set; }
        public virtual StajTablosu StajTablosu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MezunTablosu> MezunTablosu { get; set; }
    }
}
