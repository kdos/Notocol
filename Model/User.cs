//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Sources = new HashSet<Source>();
            this.Tags = new HashSet<Tag>();
        }
    
        public long ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Identifier { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
    
        public virtual ICollection<Source> Sources { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
