//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class roli
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte CodeARM { get; set; }
        public byte LevelAccess { get; set; }
        public string PoliticAccess { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }
}
