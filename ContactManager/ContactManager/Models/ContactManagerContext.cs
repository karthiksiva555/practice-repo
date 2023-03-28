using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class ContactManagerContext:DbContext
    {
        public ContactManagerContext() : base("name=ContactManagerContext")
        {

        }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}