using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Cliente : Entity
    {
        [Required(ErrorMessage = "o campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "o campo {0} é obrigatório")]
        [StringLength(9, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 8)]
        public string Telefone { get; set; }

        public EnderecoCliente EnderecoCliente { get; set; }
    }
}
