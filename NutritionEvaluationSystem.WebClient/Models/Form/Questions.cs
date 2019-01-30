using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionEvaluationSystem.WebClient.Models.Form
{
    [Table("Form.Questions")]
    public partial class Questions
    {
        public Questions() {
            EvaluationResult = new HashSet<EvaluationResult>();
            Answers = new HashSet<Answers>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string EnQuestion { get; set; }

        [Required]
        [StringLength(200)]
        public string ArQuestion { get; set; }

        [Required]
        public int Index { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual ICollection<EvaluationResult> EvaluationResult { get; set; }
        public virtual ICollection<Answers> Answers { get; set; }
    }
}
