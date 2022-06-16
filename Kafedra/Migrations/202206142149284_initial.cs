namespace Kafedra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chairs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 300),
                        Direction_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Directions", t => t.Direction_id)
                .Index(t => t.Direction_id);
            
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
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Shapes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 200),
                        Direction_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Directions", t => t.Direction_id)
                .Index(t => t.Direction_id);
            
            CreateTable(
                "dbo.EmployeeChairs",
                c => new
                    {
                        Employee_id = c.Int(nullable: false),
                        Chair_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_id, t.Chair_id })
                .ForeignKey("dbo.Employees", t => t.Employee_id, cascadeDelete: true)
                .ForeignKey("dbo.Chairs", t => t.Chair_id, cascadeDelete: true)
                .Index(t => t.Employee_id)
                .Index(t => t.Chair_id);
            
            CreateTable(
                "dbo.DirectionSubjects",
                c => new
                    {
                        Direction_id = c.Int(nullable: false),
                        Subject_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Direction_id, t.Subject_id })
                .ForeignKey("dbo.Directions", t => t.Direction_id, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subject_id, cascadeDelete: true)
                .Index(t => t.Direction_id)
                .Index(t => t.Subject_id);
            
            CreateTable(
                "dbo.SubjectEmployees",
                c => new
                    {
                        Subject_id = c.Int(nullable: false),
                        Employee_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_id, t.Employee_id })
                .ForeignKey("dbo.Subjects", t => t.Subject_id, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_id, cascadeDelete: true)
                .Index(t => t.Subject_id)
                .Index(t => t.Employee_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubjectEmployees", "Employee_id", "dbo.Employees");
            DropForeignKey("dbo.SubjectEmployees", "Subject_id", "dbo.Subjects");
            DropForeignKey("dbo.DirectionSubjects", "Subject_id", "dbo.Subjects");
            DropForeignKey("dbo.DirectionSubjects", "Direction_id", "dbo.Directions");
            DropForeignKey("dbo.Shapes", "Direction_id", "dbo.Directions");
            DropForeignKey("dbo.Chairs", "Direction_id", "dbo.Directions");
            DropForeignKey("dbo.EmployeeChairs", "Chair_id", "dbo.Chairs");
            DropForeignKey("dbo.EmployeeChairs", "Employee_id", "dbo.Employees");
            DropIndex("dbo.SubjectEmployees", new[] { "Employee_id" });
            DropIndex("dbo.SubjectEmployees", new[] { "Subject_id" });
            DropIndex("dbo.DirectionSubjects", new[] { "Subject_id" });
            DropIndex("dbo.DirectionSubjects", new[] { "Direction_id" });
            DropIndex("dbo.EmployeeChairs", new[] { "Chair_id" });
            DropIndex("dbo.EmployeeChairs", new[] { "Employee_id" });
            DropIndex("dbo.Shapes", new[] { "Direction_id" });
            DropIndex("dbo.Chairs", new[] { "Direction_id" });
            DropTable("dbo.SubjectEmployees");
            DropTable("dbo.DirectionSubjects");
            DropTable("dbo.EmployeeChairs");
            DropTable("dbo.Shapes");
            DropTable("dbo.Directions");
            DropTable("dbo.Subjects");
            DropTable("dbo.Employees");
            DropTable("dbo.Chairs");
        }
    }
}
