using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Global_Games.Data.Entities
{
    public class Orcamento
    {
        

        public int Id { get; set; }


        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
