namespace EF_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_data : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departaments", "SprDepartment_Id", "dbo.SprDepartments");
            DropForeignKey("dbo.Departaments", "User_Id", "dbo.Users");
            DropIndex("dbo.Departaments", new[] { "SprDepartment_Id" });
            DropIndex("dbo.Departaments", new[] { "User_Id" });
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Age = c.Int(nullable: false),
                        Photo = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Description = c.String(),
                        Quantity = c.Int(nullable: false),
                        PurchaseDate = c.DateTime(nullable: false),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .Index(t => t.Customer_CustomerId);
            
            DropTable("dbo.Departaments");
            DropTable("dbo.SprDepartments");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SprDepartments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SprDepartment_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Orders", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Customer_CustomerId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            CreateIndex("dbo.Departaments", "User_Id");
            CreateIndex("dbo.Departaments", "SprDepartment_Id");
            AddForeignKey("dbo.Departaments", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Departaments", "SprDepartment_Id", "dbo.SprDepartments", "Id");
        }
    }
}
