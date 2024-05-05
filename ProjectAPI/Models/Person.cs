using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
