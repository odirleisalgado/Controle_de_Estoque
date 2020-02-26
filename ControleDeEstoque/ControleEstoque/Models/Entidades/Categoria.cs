using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Models.Entidades
{
    [Table("Categoria")]
    public class Categoria
    {
        [Display(Description = "Código Categoria")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, insira uma Categoria")]
        [Display(Description = "Nome Categoria")]
        public string NomeCategoria { get; set; }

    }
}
