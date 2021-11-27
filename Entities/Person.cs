using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [NotNull]
        public string FirstName { get; set; }
        [NotNull]
        public string LastName { get; set; }
       
        public string HairColor { get; set; }
       
        public string EyeColor { get; set; }
        
        
        public int Age { get; set; }
        public float Weight { get; set; } 
        public int Height { get; set; }
        public string Sex { get; set; }
    }
}