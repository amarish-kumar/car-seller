namespace Application.Models.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedMakeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Makes (Name) VALUES ('Acura')");
            Sql("INSERT INTO Makes (Name) VALUES ('Audi')");
            Sql("INSERT INTO Makes (Name) VALUES ('BMW')");
            Sql("INSERT INTO Makes (Name) VALUES ('Cadillac')");
            Sql("INSERT INTO Makes (Name) VALUES ('Chevrolet')");
            Sql("INSERT INTO Makes (Name) VALUES ('Dodge')");
            Sql("INSERT INTO Makes (Name) VALUES ('Ford')");
            Sql("INSERT INTO Makes (Name) VALUES ('Honda')");
            Sql("INSERT INTO Makes (Name) VALUES ('Hyundai')");
            Sql("INSERT INTO Makes (Name) VALUES ('Infiniti')");
            Sql("INSERT INTO Makes (Name) VALUES ('Jaguar')");
            Sql("INSERT INTO Makes (Name) VALUES ('Lexus')");
            Sql("INSERT INTO Makes (Name) VALUES ('Maserati')");
            Sql("INSERT INTO Makes (Name) VALUES ('Mercedez Benz')");
            Sql("INSERT INTO Makes (Name) VALUES ('Nissan')");
            Sql("INSERT INTO Makes (Name) VALUES ('Toyota')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Makes WHERE Name IN ('Acura', 'Audi', 'BMW', 'Cadillac', 'Chevrolet', 'Dodge', 'Ford', 'Honda', 'Hyundai', 'Infiniti', 'Jaguar', 'Lexus', 'Maserati', 'Mercedez Benz', 'Nissan', 'Toyota')");
        }
    }
}
