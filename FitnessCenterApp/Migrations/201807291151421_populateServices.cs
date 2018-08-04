namespace FitnessCenterApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateServices : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Services (Name, Fee, IsSelected) VALUES ('Yoga', 12, 0)");
            Sql("INSERT INTO Services (Name, Fee, IsSelected) VALUES ('Pilates', 12, 0)");
            Sql("INSERT INTO Services (Name, Fee, IsSelected) VALUES ('Zumba', 12, 0)");
            Sql("INSERT INTO Services (Name, Fee, IsSelected) VALUES ('Aerobics', 10, 0)");
            Sql("INSERT INTO Services (Name, Fee, IsSelected) VALUES ('Strength Training', 12, 0)");
            Sql("INSERT INTO Services (Name, Fee, IsSelected) VALUES ('Boxing', 12, 0)");
            Sql("INSERT INTO Services (Name, Fee, IsSelected) VALUES ('Indoor Cycling', 15, 0)");
            Sql("INSERT INTO Services (Name, Fee, IsSelected) VALUES ('Machines and Free Weights', 10, 0)");
            Sql("INSERT INTO Services (Name, Fee, IsSelected) VALUES ('Swimming Pool', 15, 0)");
            Sql("INSERT INTO Services (Name, Fee, IsSelected) VALUES ('Sauna and Steam Room', 10, 0)");
        }
        
        public override void Down()
        {
        }
    }
}
