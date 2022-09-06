using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Global_Games.Data.Entities
{
    public class Newsletter
    {
        public int Id { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
