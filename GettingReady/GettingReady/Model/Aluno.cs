using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Aluno:Entidade
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int areaId { get; set; }
        public AreaConhecimento areaConhecimento { get; set; }
    }
}
