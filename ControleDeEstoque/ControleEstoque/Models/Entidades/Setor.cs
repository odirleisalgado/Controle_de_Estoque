using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Models.Entidades
{   [Table("Setor")]
    public class Setor
    {
        [Display(Description = "Código Setor")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, insira o nome do Setor")]
        [Display(Description = "Nome Setor")]
        public string NomeSetor { get; set; }
    }
}
