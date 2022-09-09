using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Global_Games.Data.Entities
{
    public class Newsletter : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
