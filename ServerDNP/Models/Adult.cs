using System.ComponentModel.DataAnnotations;

namespace ServerDNP.Models
{
    
    public class Adult : Person {
        [Required]
        public Job JobTitle { get; set; }
    }
}