namespace NutritionEvaluationSystem.WebClient.Migrations
{
    using NutritionEvaluationSystem.WebClient.Models;
    using NutritionEvaluationSystem.WebClient.Models.Form;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NutritionEvaluationSystem.WebClient.Models.ApplicationDbContext>
    {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }
    }
}
