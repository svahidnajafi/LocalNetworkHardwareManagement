//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocalNetworkHardware.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Printers
    {
        public int PrinterId { get; set; }
        public int SystemId { get; set; }
        public string Name { get; set; }
        public bool IsLocal { get; set; }
        public bool IsNetwork { get; set; }
    
        public virtual Systems Systems { get; set; }
    }
}
