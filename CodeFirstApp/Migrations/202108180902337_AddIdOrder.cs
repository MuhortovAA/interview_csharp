namespace CodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIdOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personals", "IdOrder", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personals", "IdOrder");
        }
    }
}
