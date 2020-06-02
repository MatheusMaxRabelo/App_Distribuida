using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Turma:Entidade
    {
        [Required(ErrorMessage ="Campo Disciplina é obrigatório")]
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; } 
        public Aluno Monitor { get; set; }
        [Required(ErrorMessage = "Campo Monitor é obrigatório")]
        public int monitorMatricula { get; set; }
        [Required(ErrorMessage = "Campo Professor é obrigatório")]
        public int ProfessorId { get; set; }
        public Professor professor { get; set; }
        [Required(ErrorMessage = "Campo Detalhes é obrigatório")]
        public string detalhesMonitoria { get; set; }
    }
}
