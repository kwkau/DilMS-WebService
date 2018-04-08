using Data.Models;

namespace Data
{
    using System.Data.Entity;

    public class DilMsContext : DbContext
    {
        // Your context has been configured to use a 'DilMSContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Data.Models.DilMSContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DilMSContext' 
        // connection string in the application configuration file.
        public DilMsContext()
            : base("name=DilMSContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Delivery> Delivery { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("DilMSDB");
        }
    }

    
}