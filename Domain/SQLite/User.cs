using Domain.SQLite.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.SQLite
{
    public class User : Base
    {
        public string Name { get; set; }
        public string Username { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthdate { get; set; }
        public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
