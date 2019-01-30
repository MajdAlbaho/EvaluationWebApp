namespace NutritionEvaluationSystem.WebClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsActiveQuestion : DbMigration
    {
        public override void Up()
        {
            AddColumn("Form.Questions", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Form.Questions", "IsActive");
        }
    }
}
