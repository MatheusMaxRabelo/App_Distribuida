using GettingReady.Model;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Alunos
{
    public class EditPage:ComponentBase
    {
        [Parameter]
        public int AlunoId { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        public bool isLoading { get; set; } = true;
        public Aluno aluno { get; set; }
        public List<Curso> Cursos { get; set; }
        public string cursoid { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            aluno = await Client.GetJsonAsync<Aluno>($"api/Alunos/{AlunoId}");
            Cursos = await Client.GetJsonAsync<List<Curso>>($"api/Cursos");
            StateHasChanged();
        }
        public async void Submit()
        {
            aluno.CursoId = int.Parse(cursoid);
            var jsonContent = JsonConvert.SerializeObject(aluno);
            Console.WriteLine(jsonContent);
            await Client.PutJsonAsync($"api/Alunos/{AlunoId}",aluno);
            Navigation.NavigateTo("/Admin/Alunos/List");
        }
    }
}
