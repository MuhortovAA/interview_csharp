namespace EF_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class list_department2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SprDepartments", "Departament_Id", "dbo.Departaments");
            DropForeignKey("dbo.Users", "Departament_Id", "dbo.Departaments");
            DropIndex("dbo.SprDepartments", new[] { "Departament_Id" });
            DropIndex("dbo.Users", new[] { "Departament_Id" });
            AddColumn("dbo.Departaments", "SprDepartment_Id", c => c.Int());
            AddColumn("dbo.Departaments", "User_Id", c => c.Int());
            CreateIndex("dbo.Departaments", "SprDepartment_Id");
            CreateIndex("dbo.Departaments", "User_Id");
            AddForeignKey("dbo.Departaments", "SprDepartment_Id", "dbo.SprDepartments", "Id");
            AddForeignKey("dbo.Departaments", "User_Id", "dbo.Users", "Id");
            DropColumn("dbo.SprDepartments", "Departament_Id");
            DropColumn("dbo.Users", "Departament_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Departament_Id", c => c.Int());
            AddColumn("dbo.SprDepartments", "Departament_Id", c => c.Int());
            DropForeignKey("dbo.Departaments", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Departaments", "SprDepartment_Id", "dbo.SprDepartments");
            DropIndex("dbo.Departaments", new[] { "User_Id" });
            DropIndex("dbo.Departaments", new[] { "SprDepartment_Id" });
            DropColumn("dbo.Departaments", "User_Id");
            DropColumn("dbo.Departaments", "SprDepartment_Id");
            CreateIndex("dbo.Users", "Departament_Id");
            CreateIndex("dbo.SprDepartments", "Departament_Id");
            AddForeignKey("dbo.Users", "Departament_Id", "dbo.Departaments", "Id");
            AddForeignKey("dbo.SprDepartments", "Departament_Id", "dbo.Departaments", "Id");
        }
    }
}
