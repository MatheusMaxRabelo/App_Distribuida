using GettingReady.Model;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Disciplinas
{
    public class EditPage:ComponentBase
    {
        [Parameter]
        public int DisciplinaId { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        public bool isLoading { get; set; } = true;
        public Disciplina disciplina { get; set; }


        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            disciplina = await Client.GetJsonAsync<Disciplina>($"api/Disciplinas/{DisciplinaId}");
            StateHasChanged();
        }
        public async void Submit()
        {
            var jsonContent = JsonConvert.SerializeObject(disciplina);
            Console.WriteLine(jsonContent);
            await Client.PutJsonAsync($"api/Disciplinas/{DisciplinaId}", disciplina);
            Navigation.NavigateTo("/Admin/Disciplinas/Index");
        }
    }
}
