using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Global_Games.Data.Entities
{
    public interface IEntity
    {
        [Key]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
