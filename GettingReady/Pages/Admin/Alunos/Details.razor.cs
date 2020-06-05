using GettingReady.Model;
using GettingReady.ViewModel.Admin;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Alunos
{
    public class DetailsPage : ComponentBase
    {
        [Parameter]
        public int AlunoId { get; set; }
        public AlunoData Aluno { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        public bool isLoading { get; set; } = true;


        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
            Aluno = new AlunoData();
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            Aluno.AlunoInfo = await Client.GetJsonAsync<Aluno>($"api/Alunos/{AlunoId}");
            Aluno.Disciplinas = await Client.GetJsonAsync<List<Disciplina>>($"api/Alunos/disciplinas_aluno?matricula={AlunoId}");
        }
    }
}
