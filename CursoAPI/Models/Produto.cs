using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAPI.Models {
    public class Produto {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        public string Descricao{ get; set; }

        [Range(0, 400, ErrorMessage = "Valor fora da faixa, de 0 até 400.")]
        public int  Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria SuaCategoria { get; set; }

    }
}
