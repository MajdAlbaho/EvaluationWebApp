namespace NutritionEvaluationSystem.WebClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialQuestionAnswer : DbMigration
    {
        public override void Up() {
            Sql("INSERT INTO Form.QuestionAnswers (QuestionId,AnswerId) VALUES (0, 0),(0, 1),(1, 3),(1, 4),(1, 5),(1, 6),(1, 7),(1, 8),(2, 9),(2, 10),(2, 11)," +
                            "(2, 12),(2, 13),(4, 0),(4, 1),(4, 14),(5, 0),(5, 1),(5, 15),(6, 0),(6, 1),(7, 16),(7, 17),(7, 18)");
        }

        public override void Down() {
            Sql("delete from Form.QuestionAnswers");
        }
    }
}
