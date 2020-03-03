using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Questao : Entidade
    {
        public string Pergunta { get; set; }
        public int AssuntoId { get; set; }
        public IList<Questao> Questoes { get; set; }
    }
}
