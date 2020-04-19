using GettingReady.Model;
using GettingReady.ViewModel.Admin;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Professores
{
    public class DetailsProfessor : ComponentBase
    {
        [Parameter]
        public int ProfessorId { get; set; }
        public ProfessorData Professor { get; set; }


        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {

            List<Disciplina> disc = new List<Disciplina>();
            disc.Add(new Disciplina
            {
                Id = 4001,
                Nome = "Algoritmo e Estrutura de Dados"
            });
            disc.Add(new Disciplina
            {
                Id = 4002,
                Nome = "Aplicações Distribuídas"
            });
            disc.Add(new Disciplina
            {
                Id = 4003,
                Nome = "Tecnologias Web"
            });
            disc.Add(new Disciplina
            {
                Id = 4004,
                Nome = "Cálculo 1"
            });
            Professor = new ProfessorData
            {
                ProfessorInfo = new Model.Professor
                {
                    Id = 111111,
                    Nome = "Kleber Jacques Ferreira de Souza"
                },
                Disciplinas = disc
            };
        }
    }
}
