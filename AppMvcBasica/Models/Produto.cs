﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Produto : Entity
    {
        //Chave estrangeira de Fornecedor
        [DisplayName("Fornecedores")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "o campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "o campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "o campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "o campo {0} é obrigatório")]
        public decimal Valor { get; set; }
        [DisplayName("Data de cadastro")]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        //EF Relations
        public Fornecedor Fornecedor { get; set; }

    }
}
