using GettingReady.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Disciplinas
{
    public class DetailBase:ComponentBase
    {
        [Parameter]
        public int DisciplinaId { get; set; }
        public Disciplina disciplina { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        public bool isLoading { get; set; } = true;


        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            disciplina = await Client.GetJsonAsync<Disciplina>($"api/Disciplinas/{DisciplinaId}");
        }
    }
}
