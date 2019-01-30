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
    [Table("Form.Answers")]
    public class Answers
    {
        public Answers() {
            EvaluationResult = new HashSet<EvaluationResult>();
            Questions = new HashSet<Questions>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string EnAnswer { get; set; }

        [Required]
        [StringLength(100)]
        public string ArAnswer { get; set; }


        public virtual ICollection<EvaluationResult> EvaluationResult { get; set; }
        public virtual ICollection<Questions> Questions { get; set; }
    }
}
