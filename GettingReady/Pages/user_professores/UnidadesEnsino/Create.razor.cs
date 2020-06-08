using GettingReady.Model;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.user_professores.UnidadesEnsino
{
    public class CreateBase : ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }
        public UnidadeEnsino unidade { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public bool isLoading { get; set; } = true;
        public string message { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
            isLoading = true;
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            unidade = new UnidadeEnsino();
            Disciplinas = await Client.GetJsonAsync<List<Disciplina>>($"api/disciplinas");
            var jsonContent = JsonConvert.SerializeObject(Disciplinas);
            Console.WriteLine(jsonContent);
            jsonContent = JsonConvert.SerializeObject(unidade);
            Console.WriteLine(jsonContent);
            Console.WriteLine();
            isLoading = false;
        }
        public async void Submit()
        {
            isLoading = true;
            unidade.disciplina = Disciplinas.Where(x => x.Id == unidade.DisciplinaId).FirstOrDefault();
            await Client.PostJsonAsync($"api/UnidadesEnsino", unidade);
            Navigation.NavigateTo("Professor/Unidades/Index");
        }
    }
}
