using GettingReady.Model;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Professores
{
    public class EditProfessor : ComponentBase
    {
        [Parameter]
        public int ProfessorId { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }
        public HttpClient Client { get; set; }
        public bool isLoading { get; set; } = true;
        public Professor professor { get; set; }
        

        protected override async Task OnInitializedAsync()
        {
            await Load();
        }

        protected async Task Load()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            professor = await Client.GetJsonAsync<Professor>($"api/Professores/{ProfessorId}");
            StateHasChanged();
        }

        protected async void Submit()
        {
            var jsonContent = JsonConvert.SerializeObject(professor);
            Console.WriteLine(jsonContent);
            await Client.PutJsonAsync($"api/Professores/{ProfessorId}", professor);
            Navigation.NavigateTo("/Admin/Professores/List");
        }
    }
}
