namespace FitnessCenterApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Membershiptypes (Name, DiscountRate, DurationInMonths) VALUES ('Pay As You Go', 0, 0)");
            Sql("INSERT INTO Membershiptypes (Name, DiscountRate, DurationInMonths) VALUES ('One-Month Membership', 5, 1)");
            Sql("INSERT INTO Membershiptypes (Name, DiscountRate, DurationInMonths) VALUES ('Three-Month Membership', 15, 3)");
            Sql("INSERT INTO Membershiptypes (Name, DiscountRate, DurationInMonths) VALUES ('Six-Month Membership', 25, 6)");
            Sql("INSERT INTO Membershiptypes (Name, DiscountRate, DurationInMonths) VALUES ('One-Year Membership', 50, 12)");
        }
        
        public override void Down()
        {
        }
    }
}
