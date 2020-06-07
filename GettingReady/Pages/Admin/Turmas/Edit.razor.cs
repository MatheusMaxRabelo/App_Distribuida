using GettingReady.Model;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Turmas
{
    public class EditBase:ComponentBase
    {
        [Parameter]
        public int TurmaId { get; set; }

        [Inject]
        public HttpClient Client { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }

        public Turma turma { get; set; } = new Turma();
        public List<Professor> Professores { get; set; }
        public List<Aluno> Alunos { get; set; }
        public bool isLoading { get; set; } = true;
        public string message { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            turma = await Client.GetJsonAsync<Turma>($"api/Turmas/{TurmaId}");
            Professores = await Client.GetJsonAsync<List<Professor>>($"api/Professores");
            Alunos = await Client.GetJsonAsync<List<Aluno>>($"api/Alunos");
            Alunos = Alunos.OrderBy(x => x.GetType().GetProperty("Nome").GetValue(x, null)).ToList();
            isLoading = false;
        }
        public async void Submit()
        {
            isLoading = true;
            var jsonContent = JsonConvert.SerializeObject(turma);
            Console.WriteLine(jsonContent);
            await Client.PutJsonAsync($"api/Turmas/{TurmaId}", turma);
            Navigation.NavigateTo("Admin/Turmas/Index");
        }
    }
}
