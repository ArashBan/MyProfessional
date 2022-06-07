namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsDeletedToPasswordAndMillion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Millions", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Passwords", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Passwords", "IsDeleted");
            DropColumn("dbo.Millions", "IsDeleted");
        }
    }
}
