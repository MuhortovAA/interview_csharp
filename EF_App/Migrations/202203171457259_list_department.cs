namespace EF_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class list_department : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SprDepartments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Departament_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departaments", t => t.Departament_Id)
                .Index(t => t.Departament_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Departament_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departaments", t => t.Departament_Id)
                .Index(t => t.Departament_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Departament_Id", "dbo.Departaments");
            DropForeignKey("dbo.SprDepartments", "Departament_Id", "dbo.Departaments");
            DropIndex("dbo.Users", new[] { "Departament_Id" });
            DropIndex("dbo.SprDepartments", new[] { "Departament_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.SprDepartments");
            DropTable("dbo.Departaments");
        }
    }
}
