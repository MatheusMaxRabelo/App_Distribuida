using GettingReady.Model;
using GettingReady.ViewModel.Admin;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.user_Professor.Questoes
{
    public class DetailsBase : ComponentBase
    {
        [Parameter]
        public int QuestaoId { get; set; }
        public QuestaoData Questao { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        public bool isLoading { get; set; } = true;


        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
            Questao = new QuestaoData();
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            Questao.QuestaoInfo = await Client.GetJsonAsync<Questao>($"api/Questoes/{QuestaoId}");
            Questao.Assuntos = await Client.GetJsonAsync<Assunto>($"api/Assuntos/{Questao.QuestaoInfo.AssuntoId}");
            Questao.Professores = await Client.GetJsonAsync<Professor>($"api/Professores/{Questao.QuestaoInfo.ProfessorId}");
        }
    }
}
