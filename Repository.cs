//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HackerRank1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repository
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string RepositoryName { get; set; }
        public string ModuleName { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime LastUpdatedOn { get; set; }
    
        public virtual Project Project { get; set; }
    }
}
