//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoTheyKnow
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class kom
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string name { get; set; }
    
        public virtual sub sub { get; set; }
    }
}
