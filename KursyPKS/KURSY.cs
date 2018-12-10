//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KursyPKS
{
    using System;
    using System.Collections.Generic;
    
    public partial class KURSY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KURSY()
        {
            this.TRASAs = new HashSet<TRASA>();
        }
    
        public int KU_ID { get; set; }
        public int POCZATEK_ID { get; set; }
        public int A_ID { get; set; }
        public int KONIEC_ID { get; set; }
        public int ID_KIERUNKU { get; set; }
        public System.DateTime DATA { get; set; }
        public System.TimeSpan CZAS_WYJAZDU { get; set; }
        public int PASAZEROWIE { get; set; }
        public string SYGNATURA_KURSU { get; set; }
    
        public virtual AUTOKARY AUTOKARY { get; set; }
        public virtual KIERUNEK KIERUNEK { get; set; }
        public virtual MIEJSCOWOSC MIEJSCOWOSC { get; set; }
        public virtual MIEJSCOWOSC MIEJSCOWOSC1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRASA> TRASAs { get; set; }
    }
}
