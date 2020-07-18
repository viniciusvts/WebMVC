using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Descricao { get; set; }
        [Range(1, 100, ErrorMessage = "Valor deve ser entre 1 e 100")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
