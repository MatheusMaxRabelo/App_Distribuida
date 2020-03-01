using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Professor : Entidade
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public Turma turmaProfessor { get; set; }
        public AreaConhecimento areaConhecimento { get; set; }
        //public Disciplina disciplinaProfessor { get; set; }
    }
}
