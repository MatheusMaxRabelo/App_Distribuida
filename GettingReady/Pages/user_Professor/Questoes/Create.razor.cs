using Blazored.Modal;
using Blazored.Modal.Services;
using GettingReady.Model;
using GettingReady.Shared.Componentes;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.user_Professor.Questoes
{
    public class CreateQuestao : ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }
      //  [Inject]
      //  public IModalService Modal { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }

        public Questao questao { get; set; }
        // public List<Questao> Questoes { get; set; } = new List<Questao>();
        public List<Professor> Professores { get; set; }
        public List<Assunto> Assuntos { get; set; }

        public int QuestaoId { get; set; }
        public bool isFiltered { get; set; } = false;
        public bool isSortedAsc { get; set; } = false;
        public string OrdenarPor { get; set; }
        public bool isLoading { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public string MessageColor { get; set; } = string.Empty;


        protected override async Task OnInitializedAsync()
        {
            await Load();
        }

        protected async Task Load()
        {
            isLoading = true;
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            questao = new Questao();
            Professores = new List<Professor>();
            Assuntos = new List<Assunto>();
            Professores = await Client.GetJsonAsync<List<Professor>>($"api/Professores");
            Assuntos = await Client.GetJsonAsync<List<Assunto>>($"api/Assuntos");

            /*var jsonContent = JsonConvert.SerializeObject(Professores);
            Console.WriteLine(jsonContent);
            jsonContent = JsonConvert.SerializeObject(questao);
            Console.WriteLine(jsonContent);
            jsonContent = JsonConvert.SerializeObject(Assuntos);
            Console.WriteLine(jsonContent);*/

            isLoading = false;
            StateHasChanged();
        }

        protected async void Submit()
        {
            isLoading = true;
            await Client.PostJsonAsync($"api/Questoes", questao);
            Navigation.NavigateTo("Professor/Questoes/Index");
            isLoading = false;
            StateHasChanged();
        }
    }
}
