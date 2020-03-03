using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int areaId { get; set; }
        public Curso Curso { get; set; }
        public IList<Disciplina> Disciplinas { get; set; }
    }
}
