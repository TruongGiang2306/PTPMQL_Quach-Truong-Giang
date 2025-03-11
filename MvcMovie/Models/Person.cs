using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Person")]
    public class Person 
    {
        [Key]
        public String PersonID { get; set;}
        [Required]
        public String FullName { get;set;}
        [Required]
        public String Address { get; set;}
    }
}