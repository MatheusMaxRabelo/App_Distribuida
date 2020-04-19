using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class PerguntasFrequentes:Entidade
    {
        public string Duvida { get; set; }
        public Assunto Assunto { get; set; }
        public int AssuntoId { get; set; }
        public string Resposta { get; set; }
        public int Util { get; set; }
        public int naoUtil { get; set; }
    }
}
