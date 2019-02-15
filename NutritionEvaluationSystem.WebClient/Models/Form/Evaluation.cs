using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionEvaluationSystem.WebClient.Models.Form
{
    [Table("Form.Evaluation")]
    public partial class Evaluation
    {
        public Evaluation() {
            EvaluationResult = new HashSet<EvaluationResult>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        public string EvaluateYear { get; set; }

        [StringLength(200)]
        public string Suggestions { get; set; }

        public virtual ICollection<EvaluationResult> EvaluationResult { get; set; }
        public ApplicationUser User { get; set; }

    }
}
