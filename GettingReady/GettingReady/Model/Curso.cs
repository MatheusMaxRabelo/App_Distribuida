using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IList<Disciplina> Disciplinas { get; set; }
        public IList<Aluno> Alunos { get; set; }
    }
}
