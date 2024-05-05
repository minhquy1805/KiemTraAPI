using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Models
{
    public class Department
    {
        [Key]
        public int DId { get; set; }
        public string? DName { get; set; }
        public string? DAddress { get; set; }
    }
}
