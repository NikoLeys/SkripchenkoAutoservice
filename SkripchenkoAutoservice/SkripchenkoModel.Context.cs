﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkripchenkoAutoservice
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Skripchenko_AutoserviceEntities : DbContext
    {
        private static Skripchenko_AutoserviceEntities _context;

        public static Skripchenko_AutoserviceEntities GetContext()
        {
            if (_context == null)
                _context = new Skripchenko_AutoserviceEntities();

            return _context;
        }

        public Skripchenko_AutoserviceEntities()
            : base("name=Skripchenko_AutoserviceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientService> ClientService { get; set; }
        public virtual DbSet<DocumentByService> DocumentByService { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }
        public virtual DbSet<ProductSale> ProductSale { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServicePhoto> ServicePhoto { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
    }
}
