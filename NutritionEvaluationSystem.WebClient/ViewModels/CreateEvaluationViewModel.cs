using NutritionEvaluationSystem.WebClient.Models.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionEvaluationSystem.WebClient.ViewModels
{
    public class CreateEvaluationViewModel
    {
        public List<Questions> Questions { get; set; }

        public List<int> QuestionsIds { get; set; }

        [Required]
        public List<string> AnswersIds { get; set; }

        public string FacilityName { get; set; }
        public string LoggedUserName { get; set; }
        public string Suggestions { get; set; }

        [Required]
        public string Year { get; set; }
    }
}
