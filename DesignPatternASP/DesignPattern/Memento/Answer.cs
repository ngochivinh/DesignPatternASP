using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DesignPatternASP.DesignPattern.Memento
{
    public class Answer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnswerId { get; set; }
        [Required]
        public int QuestionId { get; set; }
        [Required]
        [StringLength(100)]
        public string AnswerText { get; set; }
        [Required]
        public DateTime SubmittedOn { get; set; }
    }
}
