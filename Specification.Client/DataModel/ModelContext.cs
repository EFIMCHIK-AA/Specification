namespace Specification.Client.DataModel
{
    using BusinessModel;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {        
        public ModelContext()

            : base("name=ModelContext")
        {
        }
        public DbSet<Model> Models { get; set; }
    }
}