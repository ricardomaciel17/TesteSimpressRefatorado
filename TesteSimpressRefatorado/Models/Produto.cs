using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteSimpressRefatorado.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(250, MinimumLength = 1)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        [StringLength(250, MinimumLength = 1)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "É necessário informar se o produto está ativo")]

        public bool Ativo { get; set; }

        [Required(ErrorMessage = "É necessário informar se o produto é perecível")]

        public bool Perecivel { get; set; }

        [Required(ErrorMessage = "É necessário informar a categoria do produto")]

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}
