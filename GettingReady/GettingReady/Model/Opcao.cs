using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Opcao : Entidade
    {
        public string Texto { get; set; }
        public bool Correta { get; set; }
        public Questao Questao { get; set; }
    }
}
