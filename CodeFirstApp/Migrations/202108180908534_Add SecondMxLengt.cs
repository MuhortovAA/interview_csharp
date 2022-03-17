namespace CodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSecondMxLengt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personals", "FIO", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personals", "FIO", c => c.String());
        }
    }
}
