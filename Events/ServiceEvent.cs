//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Events
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceEvent
    {
        public int id { get; set; }
        public int EventId { get; set; }
        public int ServiceId { get; set; }
    
        public virtual EventDetail EventDetail { get; set; }
        public virtual Service Service { get; set; }
    }
}
