using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Disciplina : Entidade
    {
        public string Nome { get; set; }
        public List<Curso> Cursos { get; set; }
        public IList<Aluno> Alunos { get; set; }

    }
}
