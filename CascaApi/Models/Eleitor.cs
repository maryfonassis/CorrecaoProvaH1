using System.ComponentModel.DataAnnotations;
using CascaApi.Models.Validation;

namespace CascaApi.Models
{
    public class Eleitor
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }
        [Required]
        [StringLength(11)]
        public string CPF { get; set; }
        [Required]
        [StringLength(50)]
        public string TituloEleitor { get; set; }
        [Required]
        [UfValidation]
        public string UF { get; set; }
    }
}
