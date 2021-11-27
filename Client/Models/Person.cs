using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string FirstName { get; set; }
        [Required, MaxLength(20)]
        public string LastName { get; set; }
        [Required, MaxLength(20)]
        public string HairColor { get; set; }
        [Required, MaxLength(20)]
        public string EyeColor { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public float Weight { get; set; }
        [Required]
        public int Height { get; set; }
        [Required, MaxLength(20)]
        public string Sex { get; set; }
    }
}