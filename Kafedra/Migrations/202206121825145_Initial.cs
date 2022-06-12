namespace Kafedra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chair_Employee",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        chair_id_id = c.Int(),
                        employee_id_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Chairs", t => t.chair_id_id)
                .ForeignKey("dbo.Employees", t => t.employee_id_id)
                .Index(t => t.chair_id_id)
                .Index(t => t.employee_id_id);
            
            CreateTable(
                "dbo.Chairs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        first_name = c.String(maxLength: 30),
                        last_name = c.String(maxLength: 50),
                        middle_name = c.String(maxLength: 50),
                        gender = c.Boolean(nullable: false),
                        birthday = c.DateTime(nullable: false),
                        address = c.String(maxLength: 500),
                        phone = c.String(maxLength: 13),
                        degree = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Direction_Subject",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        direction_id_id = c.Int(),
                        Subject_id_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Directions", t => t.direction_id_id)
                .ForeignKey("dbo.Subjects", t => t.Subject_id_id)
                .Index(t => t.direction_id_id)
                .Index(t => t.Subject_id_id);
            
            CreateTable(
                "dbo.Directions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 300),
                        code = c.String(maxLength: 200),
                        language = c.String(maxLength: 50),
                        type = c.String(maxLength: 500),
                        course = c.Int(nullable: false),
                        semistir = c.Int(nullable: false),
                        chair_id_id = c.Int(),
                        shape_id_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Chairs", t => t.chair_id_id)
                .ForeignKey("dbo.Shapes", t => t.shape_id_id)
                .Index(t => t.chair_id_id)
                .Index(t => t.shape_id_id);
            
            CreateTable(
                "dbo.Shapes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 200),
                        all_hour = c.Int(nullable: false),
                        lecture = c.Int(nullable: false),
                        practice = c.Int(nullable: false),
                        mustaqil_hour = c.Int(nullable: false),
                        labor_mash = c.Int(nullable: false),
                        seminar = c.Int(nullable: false),
                        course_work = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Subject_Employee",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employee_id_id = c.Int(),
                        subject_id_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Employees", t => t.employee_id_id)
                .ForeignKey("dbo.Subjects", t => t.subject_id_id)
                .Index(t => t.employee_id_id)
                .Index(t => t.subject_id_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subject_Employee", "subject_id_id", "dbo.Subjects");
            DropForeignKey("dbo.Subject_Employee", "employee_id_id", "dbo.Employees");
            DropForeignKey("dbo.Direction_Subject", "Subject_id_id", "dbo.Subjects");
            DropForeignKey("dbo.Direction_Subject", "direction_id_id", "dbo.Directions");
            DropForeignKey("dbo.Directions", "shape_id_id", "dbo.Shapes");
            DropForeignKey("dbo.Directions", "chair_id_id", "dbo.Chairs");
            DropForeignKey("dbo.Chair_Employee", "employee_id_id", "dbo.Employees");
            DropForeignKey("dbo.Chair_Employee", "chair_id_id", "dbo.Chairs");
            DropIndex("dbo.Subject_Employee", new[] { "subject_id_id" });
            DropIndex("dbo.Subject_Employee", new[] { "employee_id_id" });
            DropIndex("dbo.Directions", new[] { "shape_id_id" });
            DropIndex("dbo.Directions", new[] { "chair_id_id" });
            DropIndex("dbo.Direction_Subject", new[] { "Subject_id_id" });
            DropIndex("dbo.Direction_Subject", new[] { "direction_id_id" });
            DropIndex("dbo.Chair_Employee", new[] { "employee_id_id" });
            DropIndex("dbo.Chair_Employee", new[] { "chair_id_id" });
            DropTable("dbo.Subject_Employee");
            DropTable("dbo.Subjects");
            DropTable("dbo.Shapes");
            DropTable("dbo.Directions");
            DropTable("dbo.Direction_Subject");
            DropTable("dbo.Employees");
            DropTable("dbo.Chairs");
            DropTable("dbo.Chair_Employee");
        }
    }
}
