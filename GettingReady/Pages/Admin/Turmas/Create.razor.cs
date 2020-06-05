using GettingReady.Model;
using GettingReady.ViewModel.Admin;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Turmas
{
    public class CreateBase : ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }

        public Turma turma { get; set; } = new Turma();
        public Turma_Alunos Turma_Alunos { get; set; } = new Turma_Alunos();
        public List<Disciplina> Disciplinas { get; set; }
        public List<Professor> Professores { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Aluno> Disponivel { get; set; }
        public List<Aluno> Incluido { get; set; } = new List<Aluno>();
        public bool isLoading { get; set; } = true;
        public string message { get; set; }
        public int ano { get; set; } = DateTime.Now.Year;
        public int semestre { get; set; } = DateTime.Now.Month < 7 ? 2 : 1;
        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            Disciplinas = await Client.GetJsonAsync<List<Disciplina>>($"api/Disciplinas");
            Professores = await Client.GetJsonAsync<List<Professor>>($"api/Professores");
            Alunos = await Client.GetJsonAsync<List<Aluno>>($"api/Alunos");
            Alunos = Alunos.OrderBy(x => x.GetType().GetProperty("Nome").GetValue(x, null)).ToList();
            Disponivel = Alunos;
            isLoading = false;
        }

        public void IncluiAluno(int matricula)
        {
            Incluido.Add(Alunos.Where(x => x.Matricula == matricula).FirstOrDefault());
            Alunos.Remove(Alunos.Where(x => x.Matricula == matricula).FirstOrDefault());
            StateHasChanged();
        }
        public void RemoveAluno(int matricula)
        {
            Alunos.Add(Incluido.Where(x => x.Matricula == matricula).FirstOrDefault());
            Incluido.Remove(Incluido.Where(x => x.Matricula == matricula).FirstOrDefault());
            StateHasChanged();
        }
        public async void Submit()
        {
            if (Incluido.Count == 0)
            {
                message = "Não se pode criar turma sem alunos";
                StateHasChanged();
            }
            else
            {
                isLoading = true;
                var jsonContent = JsonConvert.SerializeObject(turma);
                Console.WriteLine(jsonContent);
                Turma_Alunos.turma = await Client.PostJsonAsync<Turma>($"api/Turmas", turma);
                Turma_Alunos.alunos = new List<Aluno>();
                Turma_Alunos.semestre = semestre;
                Turma_Alunos.ano = ano;
                Turma_Alunos.alunos = Incluido;
                jsonContent = JsonConvert.SerializeObject(Turma_Alunos);
                Console.WriteLine(jsonContent);
                await Client.PostJsonAsync($"api/Turmas/alunosturma", Turma_Alunos);
                Navigation.NavigateTo("Admin/Turmas/Index");
            }
        }
    }
}
