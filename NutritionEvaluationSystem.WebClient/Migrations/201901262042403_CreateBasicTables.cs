namespace NutritionEvaluationSystem.WebClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBasicTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Form.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnAnswer = c.String(nullable: false, maxLength: 100, unicode: false),
                        ArAnswer = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Form.EvaluationResult",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EvaluationId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        AnswerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Form.Evaluation", t => t.EvaluationId, cascadeDelete: true)
                .ForeignKey("Form.Questions", t => t.QuestionId)
                .ForeignKey("Form.Answers", t => t.AnswerId)
                .Index(t => t.EvaluationId)
                .Index(t => t.QuestionId)
                .Index(t => t.AnswerId);
            
            CreateTable(
                "Form.Evaluation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        EvaluateYear = c.Int(nullable: false),
                        EvaluateMonth = c.Int(nullable: false),
                        Suggestions = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "Facility.Facilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnName = c.String(nullable: false, maxLength: 200),
                        ArName = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Form.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnQuestion = c.String(nullable: false, maxLength: 200, unicode: false),
                        ArQuestion = c.String(nullable: false, maxLength: 200),
                        Index = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Common.Months",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnName = c.String(nullable: false, maxLength: 100),
                        ArName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Form.QuestionAnswers",
                c => new
                    {
                        AnswerId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AnswerId, t.QuestionId })
                .ForeignKey("Form.Answers", t => t.AnswerId, cascadeDelete: true)
                .ForeignKey("Form.Questions", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.AnswerId)
                .Index(t => t.QuestionId);
            
            AddColumn("dbo.AspNetUsers", "FacilityId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "FacilityId");
            AddForeignKey("dbo.AspNetUsers", "FacilityId", "Facility.Facilities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Form.QuestionAnswers", "QuestionId", "Form.Questions");
            DropForeignKey("Form.QuestionAnswers", "AnswerId", "Form.Answers");
            DropForeignKey("Form.EvaluationResult", "AnswerId", "Form.Answers");
            DropForeignKey("Form.EvaluationResult", "QuestionId", "Form.Questions");
            DropForeignKey("Form.Evaluation", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "FacilityId", "Facility.Facilities");
            DropForeignKey("Form.EvaluationResult", "EvaluationId", "Form.Evaluation");
            DropIndex("Form.QuestionAnswers", new[] { "QuestionId" });
            DropIndex("Form.QuestionAnswers", new[] { "AnswerId" });
            DropIndex("dbo.AspNetUsers", new[] { "FacilityId" });
            DropIndex("Form.Evaluation", new[] { "UserId" });
            DropIndex("Form.EvaluationResult", new[] { "AnswerId" });
            DropIndex("Form.EvaluationResult", new[] { "QuestionId" });
            DropIndex("Form.EvaluationResult", new[] { "EvaluationId" });
            DropColumn("dbo.AspNetUsers", "FacilityId");
            DropTable("Form.QuestionAnswers");
            DropTable("Common.Months");
            DropTable("Form.Questions");
            DropTable("Facility.Facilities");
            DropTable("Form.Evaluation");
            DropTable("Form.EvaluationResult");
            DropTable("Form.Answers");
        }
    }
}
