namespace CodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaxLengt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personals", "CustomerName", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personals", "CustomerName");
        }
    }
}
