using GettingReady.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.ViewModel.Admin
{
    public class ProfessorData
    {
        public Professor ProfessorInfo { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
    }
}
