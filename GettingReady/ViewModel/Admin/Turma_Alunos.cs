using GettingReady.Model;
using GettingReady.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.ViewModel.Admin
{
    public class Turma_Alunos
    { 
        [Required(ErrorMessage = "Campo turma é obrigatório!")]
        public Turma turma { get; set; }
        public List<Aluno> alunos { get; set; }
        [DiferenteDeZero(ErrorMessage ="Campo ano é obrigatório!")]
        public int ano { get; set; }
        [DiferenteDeZero(ErrorMessage = "Campo semestre é obrigatório!")]
        public int semestre { get; set; }
    }
}
