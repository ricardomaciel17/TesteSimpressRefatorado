using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteSimpressRefatorado.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(250, MinimumLength = 1)]
        public String Nome { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        [StringLength(250, MinimumLength = 1)]
        public String Descricao { get; set; }
        public Boolean Ativo { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
