using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Monitor : Entidade
    {
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }

        public Aluno Aluno { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
