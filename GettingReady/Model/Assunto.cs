using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Assunto : Entidade
    {
        public string Nome { get; set; }
        public int UnidadeId { get; set; }
        public UnidadeEnsino UnidadeEnsino { get; set; }
    }
}
