//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Class1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urun
    {
        public int UrunID { get; set; }
        public string GeldigiYer { get; set; }
        public string GidecegiYer { get; set; }
        public string TeslimatAdresi { get; set; }
        public Nullable<double> Ucret { get; set; }
        public Nullable<double> Desi { get; set; }
        public Nullable<int> KaydedenPersonelID { get; set; }
    
        public virtual Personel Personel { get; set; }
    }
}