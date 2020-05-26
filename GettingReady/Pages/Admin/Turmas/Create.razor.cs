using GettingReady.Model;
using Microsoft.AspNetCore.Components;
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
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
        public List<Professor> Professores { get; set; } = new List<Professor>();
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
        public string DisciplinaId { get; set; }
        public string MonitorId { get; set; }
        public string ProfessorId { get; set; }
        public string detalhes { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
            turma.Disciplina = new Disciplina();
            turma.professor = new Professor();
            turma.Monitor = new Aluno();
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            Disciplinas = await Client.GetJsonAsync<List<Disciplina>>($"api/Disciplinas");
            Professores = await Client.GetJsonAsync<List<Professor>>($"api/Professores");
            Alunos = await  Client.GetJsonAsync<List<Aluno>>($"api/Alunos");
            Alunos = Alunos.OrderBy(x => x.GetType().GetProperty("Nome").GetValue(x, null)).ToList();
        }
        public async void Submit()
        {
            turma.DisciplinaId = int.Parse(DisciplinaId);
            turma.monitorMatricula = int.Parse(MonitorId);
            turma.ProfessorId = int.Parse(ProfessorId);
            turma.Disciplina = Disciplinas.Where(x => x.Id == turma.DisciplinaId).FirstOrDefault();
            turma.Monitor = Alunos.Where(x => x.Matricula == turma.monitorMatricula).FirstOrDefault();
            turma.professor = Professores.Where(x => x.Id == turma.ProfessorId).FirstOrDefault();
            Console.WriteLine(turma.Disciplina.Nome);
            turma.Id = 0;
            await Client.PostJsonAsync<Turma>("api/Turmas", turma);
            Navigation.NavigateTo("Admin/Turmas/Index");
        }
    }
}
