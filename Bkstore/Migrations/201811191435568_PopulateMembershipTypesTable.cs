namespace Bkstore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths) VALUES (1, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths) VALUES (2, 5, 1)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths) VALUES (3, 10, 3)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths) VALUES (4, 30, 12)");
        }
        
        public override void Down()
        {
        }
    }
}
