using System.ComponentModel.DataAnnotations;

namespace ServerDNP.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Title { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}