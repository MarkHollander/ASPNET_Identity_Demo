namespace WebApplication_MVC2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MealOfUsers",
                c => new
                    {
                        Meal_Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(nullable: false),
                        Ca1 = c.Int(nullable: false),
                        Ca2 = c.Int(nullable: false),
                        Ca3 = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Meal_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Role_Id = c.Int(nullable: false, identity: true),
                        Role_Name = c.String(),
                    })
                .PrimaryKey(t => t.Role_Id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Unit_Id = c.Int(nullable: false, identity: true),
                        Unit_Name = c.String(),
                        Unit_Description = c.String(),
                    })
                .PrimaryKey(t => t.Unit_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        User_Id = c.Int(nullable: false, identity: true),
                        User_Name = c.String(nullable: false),
                        Password = c.String(),
                        Unit_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.User_Id)
                .ForeignKey("dbo.Units", t => t.Unit_Id, cascadeDelete: true)
                .Index(t => t.Unit_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Unit_Id", "dbo.Units");
            DropIndex("dbo.Users", new[] { "Unit_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Units");
            DropTable("dbo.Roles");
            DropTable("dbo.MealOfUsers");
        }
    }
}
