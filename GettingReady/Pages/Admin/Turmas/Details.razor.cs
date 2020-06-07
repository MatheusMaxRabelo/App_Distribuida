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

namespace GettingReady.Pages.Admin.Turmas
{
    public class DetailsBase : ComponentBase
    {
        [Parameter]
        public int TurmaId { get; set; }
        public List<Turma_Alunos> turma { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        public bool isLoading { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
            isLoading = true;
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            turma = await Client.GetJsonAsync<List<Turma_Alunos>>($"api/Turmas/turmaAlunos/{TurmaId}");
            isLoading = !isLoading;
        }
    }
}
