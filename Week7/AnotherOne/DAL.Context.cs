﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnotherOne
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class NewDataBaseEntities : DbContext
    {
        public NewDataBaseEntities()
            : base("name=NewDataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Lab> Labs { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Picture> Pictures { get; set; }
    
        public virtual ObjectResult<ProfGrade_Result> ProfGrade()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProfGrade_Result>("ProfGrade");
        }
    }
}