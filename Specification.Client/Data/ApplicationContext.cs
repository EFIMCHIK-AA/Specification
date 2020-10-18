namespace Specification.Client.Data
{
    using Specification.Client.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationContext : DbContext
    {        
        public ApplicationContext() : base("ApplicationContext") 
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Model> Models { get; set; }
    }
}