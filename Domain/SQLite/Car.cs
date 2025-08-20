using Domain.SQLite.Bases;
using System.ComponentModel.DataAnnotations;

namespace Domain.SQLite
{
    public class Car : Base
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

    }
}
