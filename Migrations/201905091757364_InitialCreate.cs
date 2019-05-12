namespace WebDictionary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        EngineLiter = c.Single(nullable: false),
                        Power = c.Int(nullable: false),
                        Transmission = c.String(),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        ExperienceDriveYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "Id", "dbo.Drivers");
            DropIndex("dbo.Cars", new[] { "Id" });
            DropTable("dbo.Drivers");
            DropTable("dbo.Cars");
        }
    }
}
