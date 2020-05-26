using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Turma:Entidade
    {
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; } 
        public Aluno Monitor { get; set; }
        public int monitorMatricula { get; set; }
        public int ProfessorId { get; set; }
        public Professor professor { get; set; }
        public string detalhesMonitoria { get; set; }
    }
}
