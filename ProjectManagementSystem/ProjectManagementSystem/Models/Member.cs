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
    
    public partial class Member
    {
        public int MemberID { get; set; }
        public int ProjectID { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Phone_ { get; set; }
    
        public virtual Project Project { get; set; }
    }
}
