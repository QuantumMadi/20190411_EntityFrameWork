namespace MIgrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersAddCreationDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "CreationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "CreationDate");
        }
    }
}
