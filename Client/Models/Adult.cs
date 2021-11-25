using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Adult : Person
    {
        [Required]
        public Job JobTitle { get; set; }
    }
}