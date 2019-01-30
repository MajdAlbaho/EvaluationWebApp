namespace NutritionEvaluationSystem.WebClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpgradeEvaluation : DbMigration
    {
        public override void Up()
        {
            AddColumn("Form.Evaluation", "MonthId", c => c.Int(nullable: false));
            AlterColumn("Form.Evaluation", "EvaluateYear", c => c.String());
            CreateIndex("Form.Evaluation", "MonthId");
            AddForeignKey("Form.Evaluation", "MonthId", "Common.Months", "Id", cascadeDelete: true);
            DropColumn("Form.Evaluation", "EvaluateMonth");
        }
        
        public override void Down()
        {
            AddColumn("Form.Evaluation", "EvaluateMonth", c => c.Int(nullable: false));
            DropForeignKey("Form.Evaluation", "MonthId", "Common.Months");
            DropIndex("Form.Evaluation", new[] { "MonthId" });
            AlterColumn("Form.Evaluation", "EvaluateYear", c => c.Int(nullable: false));
            DropColumn("Form.Evaluation", "MonthId");
        }
    }
}
