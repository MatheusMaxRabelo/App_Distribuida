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
        public AreaConhecimento areaConhecimento { get; set; }
        public Turma Turmas { get; set; }
        public Turma turmaProfessor { get; internal set; }
    }
}
