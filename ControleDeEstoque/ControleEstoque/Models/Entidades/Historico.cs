using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Models.Entidades
{
    [Table("Historico")]
    public class Historico
    {
        [Display(Description = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, insira um Setor")]
        [Display(Description = "Setor")]
        public int SetorId { get; set; }

        [Required(ErrorMessage = "Por favor, insira um Produto")]
        [Display(Description = "Produto")]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Por favor, insira uma Quantidade")]
        [Display(Description = "Quantidade")]
        public int Qtd { get; set; }

        public virtual Produto Produto { get; set; }

        public virtual Setor Setor { get; set; }


    }
}
