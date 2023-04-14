using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DesignPatternASP.DesignPattern.Observer
{
    public class Notification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        public DateTime ReceivedOn { get; set; }
    }
}
