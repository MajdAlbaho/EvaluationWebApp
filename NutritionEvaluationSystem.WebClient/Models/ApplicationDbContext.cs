using Microsoft.AspNet.Identity.EntityFramework;
using NutritionEvaluationSystem.WebClient.Models.Common;
using NutritionEvaluationSystem.WebClient.Models.Form;
using System.Configuration;
using System.Data.Entity;

namespace NutritionEvaluationSystem.WebClient.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<Facilities> Facilities { get; set; }
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<Evaluation> Evaluation { get; set; }
        public virtual DbSet<EvaluationResult> EvaluationResult { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Answers>()
                .Property(e => e.EnAnswer)
                .IsUnicode(false);

            modelBuilder.Entity<Answers>()
                .HasMany(e => e.EvaluationResult)
                .WithRequired(e => e.Answers)
                .HasForeignKey(e => e.AnswerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Answers>()
                .HasMany(e => e.Questions)
                .WithMany(e => e.Answers)
                .Map(m => m.ToTable("QuestionAnswers", "Form").MapLeftKey("AnswerId").MapRightKey("QuestionId"));

            modelBuilder.Entity<Evaluation>()
                .HasMany(e => e.EvaluationResult)
                .WithRequired(e => e.Evaluation)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Questions>()
                .Property(e => e.EnQuestion)
                .IsUnicode(false);

            modelBuilder.Entity<Questions>()
                .HasMany(e => e.EvaluationResult)
                .WithRequired(e => e.Questions)
                .HasForeignKey(e => e.QuestionId)
                .WillCascadeOnDelete(false);
        }
    }
}