namespace NETFRAMEWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaNacimiento = c.DateTime(),
                        IdProfesor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlumnoId)
                .ForeignKey("dbo.Docente", t => t.IdProfesor, cascadeDelete: true)
                .Index(t => t.IdProfesor);
            
            CreateTable(
                "dbo.Docente",
                c => new
                    {
                        ProfesorId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Titulo = c.String(nullable: false, maxLength: 50, unicode: false),
                        IdAula = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProfesorId)
                .ForeignKey("dbo.Aula", t => t.ProfesorId)
                .Index(t => t.ProfesorId);
            
            CreateTable(
                "dbo.Aula",
                c => new
                    {
                        AulaId = c.Int(nullable: false),
                        Capacidad = c.Int(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        IdProfesor = c.Int(nullable: false),
                        IdMateria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AulaId);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        MateriaId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Programa = c.String(nullable: false, maxLength: 50, unicode: false),
                        IdProfesor = c.Int(nullable: false),
                        IdAula = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MateriaId)
                .ForeignKey("dbo.Docente", t => t.IdProfesor, cascadeDelete: true)
                .ForeignKey("dbo.Aula", t => t.MateriaId)
                .Index(t => t.MateriaId)
                .Index(t => t.IdProfesor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Docente", "ProfesorId", "dbo.Aula");
            DropForeignKey("dbo.Materia", "MateriaId", "dbo.Aula");
            DropForeignKey("dbo.Materia", "IdProfesor", "dbo.Docente");
            DropForeignKey("dbo.Alumno", "IdProfesor", "dbo.Docente");
            DropIndex("dbo.Materia", new[] { "IdProfesor" });
            DropIndex("dbo.Materia", new[] { "MateriaId" });
            DropIndex("dbo.Docente", new[] { "ProfesorId" });
            DropIndex("dbo.Alumno", new[] { "IdProfesor" });
            DropTable("dbo.Materia");
            DropTable("dbo.Aula");
            DropTable("dbo.Docente");
            DropTable("dbo.Alumno");
        }
    }
}
