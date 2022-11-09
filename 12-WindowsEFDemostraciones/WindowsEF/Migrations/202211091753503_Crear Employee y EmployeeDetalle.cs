namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearEmployeeyEmployeeDetalle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeDetalles",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        Gender = c.String(maxLength: 10),
                        EmailAddress = c.String(maxLength: 255),
                        PhoneNumber = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeDetalles", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.EmployeeDetalles", new[] { "EmployeeId" });
            DropTable("dbo.Employees");
            DropTable("dbo.EmployeeDetalles");
        }
    }
}
