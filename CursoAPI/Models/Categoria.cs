using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAPI.Models {
    public class Categoria {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        public string Descricao { get; set; }

        //para evitar referência circular na API -- public List<Produto> Produtos { get; set; }
    }
}
