using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Global_Games.Data.Entities
{
    public class Budget : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Name { get; set; }

        public string Email { get; set; }

        [Display(Name = "Message")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Message { get; set; }
        
    }
}
