using GettingReady.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.ViewModel.Admin
{
    public class QuestaoData
    {
        public Questao QuestaoInfo { get; set; }
        public Assunto Assuntos { get; set; }
        public Professor Professores { get; set; }
    }
}
