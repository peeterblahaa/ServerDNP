using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string JobTitle { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}