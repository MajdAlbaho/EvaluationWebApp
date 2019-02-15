namespace NutritionEvaluationSystem.WebClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMonthId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Form.Evaluation", "MonthId", "Common.Months");
            DropIndex("Form.Evaluation", new[] { "MonthId" });
            DropColumn("Form.Evaluation", "MonthId");
            DropTable("Common.Months");
        }
        
        public override void Down()
        {
            CreateTable(
                "Common.Months",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnName = c.String(nullable: false, maxLength: 100),
                        ArName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Form.Evaluation", "MonthId", c => c.Int(nullable: false));
            CreateIndex("Form.Evaluation", "MonthId");
            AddForeignKey("Form.Evaluation", "MonthId", "Common.Months", "Id", cascadeDelete: true);
        }
    }
}
