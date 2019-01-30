using NutritionEvaluationSystem.WebClient.Models.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionEvaluationSystem.WebClient.Models
{
    [Table("Form.EvaluationResult")]
    public class EvaluationResult
    {
        public int Id { get; set; }

        [Required]
        public int EvaluationId { get; set; }

        [Required]
        public int QuestionId { get; set; }

        [Required]
        public int AnswerId { get; set; }


        public virtual Answers Answers { get; set; }

        public virtual Evaluation Evaluation { get; set; }

        public virtual Questions Questions { get; set; }
    }
}
