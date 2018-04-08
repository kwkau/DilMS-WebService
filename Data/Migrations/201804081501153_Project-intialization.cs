namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Projectintialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "DilMSDB.Deliveries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("DilMSDB.Deliveries");
        }
    }
}
