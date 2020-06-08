using GettingReady.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class UnidadeEnsino : Entidade
    {
        [Required(ErrorMessage = "Campo Nome é obrigatório!")]
        public string Nome { get; set; }
        [DiferenteDeZero (ErrorMessage ="Campo Disciplina é obrigatório!")]
        public int DisciplinaId { get; set; }
        public Disciplina disciplina { get; set; }
    }
}
