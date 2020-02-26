using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Models.Entidades
{
    [Table("Produto")]
    public class Produto
    {
        [Display(Description= "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, insira o nome do Produto")]
        [Display(Description = "Nome do Produto")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "Por favor, insira uma Categoria")]
        [Display(Description = "Categoria")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Por favor, insira uma Quantidade")]
        [Display(Description = "Quantidade")]
        public int Quantidade { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
