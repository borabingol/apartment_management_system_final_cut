//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Site_Yönetim_Sistemi
{
    using System;
    using System.Collections.Generic;
    
    public partial class anketSonuclari
    {
        public int id { get; set; }
        public Nullable<int> s1 { get; set; }
        public Nullable<int> s2 { get; set; }
        public Nullable<int> s3 { get; set; }
        public Nullable<int> s4 { get; set; }
        public Nullable<int> s5 { get; set; }
        public Nullable<int> kisiSayisi { get; set; }
    
        public virtual anket anket { get; set; }
    }
}
