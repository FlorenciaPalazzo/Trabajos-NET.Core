namespace NETFRAMEWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agregoclasemateriayaula : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aula",
                c => new
                    {
                        AulaId = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.AulaId);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        MateriaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Programa = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MateriaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Materia");
            DropTable("dbo.Aula");
        }
    }
}
