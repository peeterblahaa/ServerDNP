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
        [Required, Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0 for Age")]
        public int Age { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0 for Age")]
        public float Weight { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0 for Age")]
        public int Height { get; set; }
        [Required, MaxLength(20)]
        public string Sex { get; set; }
    }
}