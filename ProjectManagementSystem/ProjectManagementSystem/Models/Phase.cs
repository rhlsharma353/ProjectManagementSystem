//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phase
    {
        public Phase()
        {
            this.PerformPerRequirements = new HashSet<PerformPerRequirement>();
        }
    
        public int PhaseID { get; set; }
        public string PhaseName { get; set; }
    
        public virtual ICollection<PerformPerRequirement> PerformPerRequirements { get; set; }
    }
}
