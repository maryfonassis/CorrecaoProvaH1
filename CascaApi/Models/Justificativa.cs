using System.ComponentModel.DataAnnotations;

namespace CascaApi.Models
{
    public class Justificativa
    {
        [Required]
        public string Texto { get; set; }
        [Required]
        public int Turno { get; set; }

        [Required]
        public string Cpf { get; set; }


    }
}
