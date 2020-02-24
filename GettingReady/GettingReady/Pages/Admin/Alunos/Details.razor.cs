using GettingReady.Model;
using GettingReady.ViewModel.Admin;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Alunos
{
    public class DetailsPage : ComponentBase
    {
        [Parameter]
        public int AlunoId { get; set; }
        public AlunoData Aluno { get; set; }


        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {

            List<Disciplina>  disc = new List<Disciplina>();
            disc.Add(new Disciplina
            {
                Id=123,
                Nome = "AED",
                areaConhecimento = new AreaConhecimento { Nome="Sistemas de Informação"}
            });
            disc.Add(new Disciplina
            {
                Id = 234,
                Nome = "ATP",
                areaConhecimento = new AreaConhecimento { Nome = "Sistemas de Informação" }
            });
            disc.Add(new Disciplina
            {
                Id = 345,
                Nome = "POO",
                areaConhecimento = new AreaConhecimento { Nome = "Sistemas de Informação" }
            });
            disc.Add(new Disciplina
            {
                Id = 543,
                Nome = "AED",
                areaConhecimento = new AreaConhecimento { Nome = "Engenharia da Computação" }
            });
            disc.Add(new Disciplina
            {
                Id = 253,
                Nome = "ATP",
                areaConhecimento = new AreaConhecimento { Nome = "Ciências da Computação" }
            });
            disc.Add(new Disciplina
            {
                Id = 652,
                Nome = "POO",
                areaConhecimento = new AreaConhecimento { Nome = "Ciências da Computação" }
            });

            Aluno = new AlunoData
            {
                AlunoInfo = new Model.Aluno
                {
                    Matricula=599950,
                    Nome = "Matheus Maximiano",
                    areaId = 333,
                    areaConhecimento = new AreaConhecimento
                    {
                        Id=333,
                        Nome = "Sistemas de Informação"
                    }
                },
                Disciplinas = disc
            };
        }
    }
}
