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
    public class CreateBase : ComponentBase
    {
        [Parameter]
        public int TurmaId { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        public Turma_Alunos turma { get; set; } = new Turma_Alunos();
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
            turma.turma = await Client.GetJsonAsync<Turma>($"/api/Turmas/{TurmaId}");
            turma.alunos = new List<Aluno>();
            Alunos = await Client.GetJsonAsync<List<Aluno>>("/api/Alunos");
            StateHasChanged();
            Console.WriteLine("Cheguei aqui");
            isLoading = false;
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
        protected async void Submit()
        {
            if (turma.alunos.Count==0)
            {
                message = "Cadastre pelo menos um aluno!";
                StateHasChanged();
            }
            else
            {
                isLoading = true;
                await Client.PostJsonAsync("/api/Turmas/alunosTurma", turma);
                Navigation.NavigateTo($"Admin/Turmas/all/{TurmaId}");
                isLoading = false;
            }
        }
    }
}
