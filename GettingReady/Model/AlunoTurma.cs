using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class AlunoTurma
    {
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int Ano { get; set; }
        public int Semestre { get; set; }
    }
}
