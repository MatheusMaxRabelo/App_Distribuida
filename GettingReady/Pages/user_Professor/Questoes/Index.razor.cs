using Blazored.Modal;
using Blazored.Modal.Services;
using GettingReady.Model;
using GettingReady.Shared.Componentes;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.user_Professor.Questoes
{
    public class IndexPage : ComponentBase
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }
        [Inject]
        public IModalService Modal { get; set; }
        [Inject]
        public HttpClient Client { get; set; }

        public int QuestaoId { get; set; }
        public List<Questao> aux { get; set; }
        public List<Questao> Questoes { get; set; } = new List<Questao>();
        public bool isFiltered { get; set; } = false;
        public bool isSortedAsc { get; set; } = false;
        public string OrdenarPor { get; set; }
        public string Message { get; set; } = string.Empty;
        public string MessageColor { get; set; } = string.Empty;
        public bool isLoading { get; set; } = true;


        protected async override Task OnInitializedAsync()
        {
            await Load();
        }

        protected async Task Load()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            await GetQuestoes();
            StateHasChanged();
        }

        protected async Task GetQuestoes()
        {
            isLoading = true;
            aux = await Client.GetJsonAsync<List<Questao>>("/api/Questoes");
            aux.OrderBy(x => x.Id);
            Questoes = aux;
            isLoading = false;
        }

        protected void SortTable(string campoOrdenar)
        {
            if (campoOrdenar != OrdenarPor)
            {
                Questoes = Questoes.OrderBy(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();
                isSortedAsc = true;
                OrdenarPor = campoOrdenar;
            }
            else
            {
                if (isSortedAsc)
                    Questoes = Questoes.OrderByDescending(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();
                else
                    Questoes = Questoes.OrderBy(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();

                isSortedAsc = !isSortedAsc;
            }
            StateHasChanged();
        }

        protected string SortIcon(string campoOrdenado)
        {
            if (OrdenarPor != campoOrdenado)
                return string.Empty;

            if (isSortedAsc)
                return "fa-sort-up";
            else
                return "fa-sort-down";
        }

        protected void NavigateTo(string page, int id)
        {
            navigationManager.NavigateTo($"Professor/Questoes/{page}/{id}");
        }

        protected void ConfirmDelete(int id_questao, string nome)
        {
            QuestaoId = id_questao;
            ModalParameters parameters = new ModalParameters();
            parameters.Add("Mensagem", $"Tem certeza que deseja apagar a questão: \n {nome.ToUpper()} ?");
            parameters.Add("SimText", "Confirmar");
            parameters.Add("NaoText", "Cancelar");

            Modal.OnClose += ModalClose;
            Modal.Show<ConfirmDelete>("Deletar questão", parameters);
        }

        private async void ModalClose(ModalResult result)
        {
            if (!result.Cancelled)
            {
                await Client.DeleteAsync($"/api/questoes/{QuestaoId}");
                Message = "Questão deletada com sucesso!";
                MessageColor = "Color:Green";
                Questoes = null;
                await GetQuestoes();
                StateHasChanged();
            }

            Modal.OnClose -= ModalClose;
        }
    }
}
