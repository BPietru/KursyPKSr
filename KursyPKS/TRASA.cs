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
    
    public partial class TRASA
    {
        public int M_ID { get; set; }
        public int KU_ID { get; set; }
        public decimal NUMER_PRZYSTANKU { get; set; }
        public System.TimeSpan CZAS_PRZEJAZDU { get; set; }
        public decimal CENA_BILETU { get; set; }
    
        public virtual KURSY KURSY { get; set; }
        public virtual MIEJSCOWOSC MIEJSCOWOSC { get; set; }
    }
}