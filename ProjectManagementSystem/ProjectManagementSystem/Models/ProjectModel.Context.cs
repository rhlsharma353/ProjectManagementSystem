﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbProjectMSEntities : DbContext
    {
        public dbProjectMSEntities()
            : base("name=dbProjectMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<PerformPerRequirement> PerformPerRequirements { get; set; }
        public virtual DbSet<Phase> Phases { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Requirement> Requirements { get; set; }
        public virtual DbSet<Risk> Risks { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
