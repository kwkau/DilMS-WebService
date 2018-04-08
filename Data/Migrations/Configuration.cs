using System.Data.Entity.Migrations;
using Data.Models;

namespace Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DilMsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DilMsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Delivery.AddOrUpdate(d => d.Name, 
                new Delivery{ Name = "Kwaku" }, 
                new Delivery{ Name = "Naski" }, 
                new Delivery{ Name = "Kay" });
            //
        }
    }
}
