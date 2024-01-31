using System.ComponentModel.DataAnnotations;

namespace Mohmed.Models.Entity
{
    public class Cusmors
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
