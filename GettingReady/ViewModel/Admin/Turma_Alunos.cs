using GettingReady.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.ViewModel.Admin
{
    public class Turma_Alunos
    {
        public Turma turma { get; set; }
        public List<Aluno> alunos { get; set; }
        public int ano { get; set; }
        public int semestre { get; set; }
    }
}
