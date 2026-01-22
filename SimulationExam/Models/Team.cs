using SimulationExam.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SimulationExam.Models
{
   public class Team:BaseEntity
    {
        [MaxLength(30,ErrorMessage ="Name cannot contain more than 30 symbols")]
        [MinLength(2, ErrorMessage ="Name cannot contain less than 2 symbols")]
        public string Name { get; set; }
        [MaxLength(100, ErrorMessage = "Specialty cannot contain more than 100 symbols")]
        public string Specialty { get; set; }
        [MaxLength(500, ErrorMessage = "Bio cannot contain more than 500 symbols")]
        public string Bio { get; set; }
        public string Image { get; set; }
    }
}
