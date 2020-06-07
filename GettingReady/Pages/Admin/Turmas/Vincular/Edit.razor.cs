using GettingReady.Model;
using GettingReady.ViewModel.Admin;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Turmas.Vincular
{
    public class EditBase : ComponentBase
    {
        [Parameter]
        public int TurmaId { get; set; }
        [Parameter]
        public int ano { get; set; }
        [Parameter]
        public int semestre { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }
        public Turma_Alunos turma { get; set; }
        public List<Aluno> Alunos { get; set; }
        public string message { get; set; }
        public bool isLoading { get; set; } = true;

        protected async override Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            if (ano == 0)
            {
                var turmas = await Client.GetJsonAsync<List<Turma_Alunos>>($"api/Turmas/turmaAlunos/{TurmaId}");
                turma = turmas[0];
            }
            else
            {
                turma = await Client.GetJsonAsync<Turma_Alunos>($"api/Turmas/turmaAlunos/{TurmaId}?ano={ano}&semestre={semestre}");
            }
            Alunos = await Client.GetJsonAsync<List<Aluno>>($"api/Alunos");
            Alunos = Alunos.OrderBy(x => x.GetType().GetProperty("Nome").GetValue(x, null)).ToList();
            RemoveExistingAlunos();
            var jsonContent = JsonConvert.SerializeObject(turma);
            Console.WriteLine(jsonContent);
            isLoading = false;
        }
        protected void RemoveExistingAlunos()
        {
            foreach (var aluno in turma.alunos)
            {
                Alunos.Remove(Alunos.Where(x => x.Matricula == aluno.Matricula).FirstOrDefault());
            }
        }
        public void IncluiAluno(int matricula)
        {
            turma.alunos.Add(Alunos.Where(x => x.Matricula == matricula).FirstOrDefault());
            Alunos.Remove(Alunos.Where(x => x.Matricula == matricula).FirstOrDefault());
            StateHasChanged();
        }
        public void RemoveAluno(int matricula)
        {
            Alunos.Add(turma.alunos.Where(x => x.Matricula == matricula).FirstOrDefault());
            turma.alunos.Remove(turma.alunos.Where(x => x.Matricula == matricula).FirstOrDefault());
            StateHasChanged();
        }
        public async void Submit()
        {
            if (turma.ano == 0 || turma.semestre == 0)
            {
                message = "Ano e semestre deve ser diferente de 0";
                StateHasChanged();
            }
            else if (turma.alunos.Count == 0)
            {
                message = "A turma precisa ter no mínimo 1 aluno matriculado";
                StateHasChanged();
            }
            else
            {
                if (ano==0||semestre==0)
                {
                    isLoading = true;
                    message = string.Empty;
                    await Client.PostJsonAsync($"api/Turmas/alunosturma", turma);
                    Navigation.NavigateTo($"Admin/Turmas/all/{TurmaId}");
                }
                else
                {
                    isLoading = true;
                    message = string.Empty;
                    var jsonContent = JsonConvert.SerializeObject(turma);
                    Console.WriteLine(jsonContent);
                    await Client.PutJsonAsync($"api/Turmas/turmaAlunos", turma);
                    Navigation.NavigateTo($"Admin/Turmas/all/{TurmaId}");
                }

            }

        }
    }
}
