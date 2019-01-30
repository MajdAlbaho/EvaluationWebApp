using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionEvaluationSystem.WebClient.Models
{
    [Table("Facility.Facilities")]
    public class Facilities
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string EnName { get; set; }

        [Required]
        [StringLength(200)]
        public string ArName { get; set; }
    }
}
