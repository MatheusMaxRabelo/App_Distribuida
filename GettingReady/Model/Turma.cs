﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Turma
    {
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
        public int turmaId { get; set; }        
        public Aluno Monitor { get; set; }
        public int AlunoId { get; set; }
    }
}