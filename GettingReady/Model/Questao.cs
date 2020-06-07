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
        public Assunto Assunto { get; set; }
        public string opcao_0 { get; set; }
        public string opcao_1 { get; set; }
        public string opcao_2 { get; set; }
        public string opcao_3 { get; set; }
        public string resposta { get; set; }
        public Professor professor { get; set; }
    }
}
