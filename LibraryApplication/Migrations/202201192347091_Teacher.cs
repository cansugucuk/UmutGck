namespace LibraryApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CommentText = c.String(),
                        StatuId = c.Int(nullable: false),
                        IsVisible = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.StatuId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.StatuId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        GradeNumber = c.Int(nullable: false),
                        Documents = c.String(),
                        Photo = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        CountryId = c.Int(),
                        IsBlocked = c.Boolean(nullable: false),
                        ReasonBlocked = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.DateTime(nullable: false),
                        UserTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.UserTypes", t => t.UserTypeId, cascadeDelete: true)
                .Index(t => t.CountryId)
                .Index(t => t.UserTypeId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentComplaints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        ComplaintReason = c.String(),
                        StatuId = c.Int(nullable: false),
                        CreatorTeacherId = c.Int(nullable: false),
                        IsVisible = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.CreatorTeacherId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatuId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.StatuId)
                .Index(t => t.CreatorTeacherId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        OtherInformations = c.String(),
                        IBAN = c.String(),
                        ExperienceYear = c.Int(nullable: false),
                        Documents = c.String(),
                        Photo = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        University = c.String(),
                        WhatTeacher = c.String(),
                        About = c.String(),
                        YoutubeUrl = c.String(),
                        UserTypeId = c.Int(nullable: false),
                        CountryId = c.Int(),
                        WorkTypeId = c.Int(),
                        IsBlocked = c.Boolean(nullable: false),
                        ReasonBlocked = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.WorkTypes", t => t.WorkTypeId)
                .Index(t => t.CountryId)
                .Index(t => t.WorkTypeId);
            
            CreateTable(
                "dbo.StudentLikes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        LikeReason = c.String(),
                        StatuId = c.Int(nullable: false),
                        CreatorTeacherId = c.Int(nullable: false),
                        IsVisible = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.CreatorTeacherId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatuId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.StatuId)
                .Index(t => t.CreatorTeacherId);
            
            CreateTable(
                "dbo.TeacherComplaints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeacherId = c.Int(nullable: false),
                        ComplaintReason = c.String(),
                        StatuId = c.Int(nullable: false),
                        CreatorStudentId = c.Int(nullable: false),
                        IsVisible = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.CreatorStudentId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatuId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.StatuId)
                .Index(t => t.CreatorStudentId);
            
            CreateTable(
                "dbo.TeacherLessons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeacherId = c.Int(nullable: false),
                        LessonId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lessons", t => t.LessonId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.LessonId);
            
            CreateTable(
                "dbo.TeacherLikes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeacherId = c.Int(nullable: false),
                        LikeReason = c.String(),
                        StatuId = c.Int(),
                        CreatorStudentId = c.Int(nullable: false),
                        IsVisible = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.CreatorStudentId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatuId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.StatuId)
                .Index(t => t.CreatorStudentId);
            
            CreateTable(
                "dbo.StudentLessons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        LessonId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lessons", t => t.LessonId, cascadeDelete: true)
                .Index(t => t.LessonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentLessons", "LessonId", "dbo.Lessons");
            DropForeignKey("dbo.Students", "UserTypeId", "dbo.UserTypes");
            DropForeignKey("dbo.StudentComplaints", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentComplaints", "StatuId", "dbo.Status");
            DropForeignKey("dbo.Teachers", "WorkTypeId", "dbo.WorkTypes");
            DropForeignKey("dbo.TeacherLikes", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.TeacherLikes", "StatuId", "dbo.Status");
            DropForeignKey("dbo.TeacherLikes", "CreatorStudentId", "dbo.Students");
            DropForeignKey("dbo.TeacherLessons", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.TeacherLessons", "LessonId", "dbo.Lessons");
            DropForeignKey("dbo.TeacherComplaints", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.TeacherComplaints", "StatuId", "dbo.Status");
            DropForeignKey("dbo.TeacherComplaints", "CreatorStudentId", "dbo.Students");
            DropForeignKey("dbo.StudentLikes", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentLikes", "StatuId", "dbo.Status");
            DropForeignKey("dbo.StudentLikes", "CreatorTeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentComplaints", "CreatorTeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Students", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Comments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Comments", "StatuId", "dbo.Status");
            DropIndex("dbo.StudentLessons", new[] { "LessonId" });
            DropIndex("dbo.TeacherLikes", new[] { "CreatorStudentId" });
            DropIndex("dbo.TeacherLikes", new[] { "StatuId" });
            DropIndex("dbo.TeacherLikes", new[] { "TeacherId" });
            DropIndex("dbo.TeacherLessons", new[] { "LessonId" });
            DropIndex("dbo.TeacherLessons", new[] { "TeacherId" });
            DropIndex("dbo.TeacherComplaints", new[] { "CreatorStudentId" });
            DropIndex("dbo.TeacherComplaints", new[] { "StatuId" });
            DropIndex("dbo.TeacherComplaints", new[] { "TeacherId" });
            DropIndex("dbo.StudentLikes", new[] { "CreatorTeacherId" });
            DropIndex("dbo.StudentLikes", new[] { "StatuId" });
            DropIndex("dbo.StudentLikes", new[] { "StudentId" });
            DropIndex("dbo.Teachers", new[] { "WorkTypeId" });
            DropIndex("dbo.Teachers", new[] { "CountryId" });
            DropIndex("dbo.StudentComplaints", new[] { "CreatorTeacherId" });
            DropIndex("dbo.StudentComplaints", new[] { "StatuId" });
            DropIndex("dbo.StudentComplaints", new[] { "StudentId" });
            DropIndex("dbo.Students", new[] { "UserTypeId" });
            DropIndex("dbo.Students", new[] { "CountryId" });
            DropIndex("dbo.Comments", new[] { "StatuId" });
            DropIndex("dbo.Comments", new[] { "StudentId" });
            DropTable("dbo.StudentLessons");
            DropTable("dbo.TeacherLikes");
            DropTable("dbo.TeacherLessons");
            DropTable("dbo.TeacherComplaints");
            DropTable("dbo.StudentLikes");
            DropTable("dbo.Teachers");
            DropTable("dbo.StudentComplaints");
            DropTable("dbo.Countries");
            DropTable("dbo.Students");
            DropTable("dbo.Comments");
        }
    }
}
