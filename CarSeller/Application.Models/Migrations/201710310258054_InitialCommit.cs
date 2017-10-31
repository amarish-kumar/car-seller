namespace Application.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "DriveTrains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Engines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Trims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        EngineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Engines", t => t.EngineId, cascadeDelete: true)
                .Index(t => t.EngineId);
            
            CreateTable(
                "Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        MakeId = c.Int(nullable: false),
                        FuelTypeId = c.Int(nullable: false),
                        TrimId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("FuelTypes", t => t.FuelTypeId, cascadeDelete: true)
                .ForeignKey("Makes", t => t.MakeId, cascadeDelete: true)
                .ForeignKey("Trims", t => t.TrimId, cascadeDelete: true)
                .Index(t => t.MakeId)
                .Index(t => t.FuelTypeId)
                .Index(t => t.TrimId);
            
            CreateTable(
                "FuelTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Makes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Features",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Transmissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Trims", "EngineId", "Engines");
            DropForeignKey("Models", "TrimId", "Trims");
            DropForeignKey("Models", "MakeId", "Makes");
            DropForeignKey("Models", "FuelTypeId", "FuelTypes");
            DropIndex("Models", new[] { "TrimId" });
            DropIndex("Models", new[] { "FuelTypeId" });
            DropIndex("Models", new[] { "MakeId" });
            DropIndex("Trims", new[] { "EngineId" });
            DropTable("Transmissions");
            DropTable("Features");
            DropTable("Makes");
            DropTable("FuelTypes");
            DropTable("Models");
            DropTable("Trims");
            DropTable("Engines");
            DropTable("DriveTrains");
        }
    }
}
