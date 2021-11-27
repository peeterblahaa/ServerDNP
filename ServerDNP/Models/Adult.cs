using System.ComponentModel.DataAnnotations;

namespace ServerDNP.Models
{
    
    public class Adult : Person {
        
        public Job JobTitle { get; set; }
    }
}