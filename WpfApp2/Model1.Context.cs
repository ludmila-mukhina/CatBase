﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class testBaseEntities : DbContext
    {
        public testBaseEntities()
            : base("name=testBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BreedTable> BreedTable { get; set; }
        public virtual DbSet<CatTable> CatTable { get; set; }
        public virtual DbSet<FeedCatTable> FeedCatTable { get; set; }
        public virtual DbSet<FeedTable> FeedTable { get; set; }
        public virtual DbSet<GenderTable> GenderTable { get; set; }
        public virtual DbSet<PassportTable> PassportTable { get; set; }
        public virtual DbSet<RoleTable> RoleTable { get; set; }
        public virtual DbSet<TraitCat> TraitCat { get; set; }
        public virtual DbSet<TraitTable> TraitTable { get; set; }
        public virtual DbSet<UserTable> UserTable { get; set; }
    }
}
