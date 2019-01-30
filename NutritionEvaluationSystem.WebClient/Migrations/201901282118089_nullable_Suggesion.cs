namespace NutritionEvaluationSystem.WebClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullable_Suggesion : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Form.Evaluation", "Suggestions", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("Form.Evaluation", "Suggestions", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
