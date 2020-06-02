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

namespace GettingReady.Pages.Admin.Turmas
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }
        [Inject]
        public IModalService Modal { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        public int TurmaId { get; set; }
        public List<Turma> Turmas { get; set; } = new List<Turma>();
        public List<Turma> aux { get; set; } = new List<Turma>();
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
            await GetTurmas();
            StateHasChanged();
        }
        protected async Task GetTurmas()
        {
            isLoading = true;
            aux = await Client.GetJsonAsync<List<Turma>>("/api/Turmas");
            Turmas = aux;
            isLoading = false;
        }
        protected void SortTable(string campoOrdenar)
        {
            if (campoOrdenar != OrdenarPor)
            {
                Turmas = Turmas.OrderBy(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();
                isSortedAsc = true;
                OrdenarPor = campoOrdenar;
            }
            else
            {
                if (isSortedAsc)
                    Turmas = Turmas.OrderByDescending(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();
                else
                    Turmas = Turmas.OrderBy(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();

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

        protected void NavigateTo(char page, int id)
        {
            if (page == 'd')
            {
                Console.WriteLine("Saca os detalhes");
                navigationManager.NavigateTo($"Admin/Turmas/Detail/{id}");
            }

            else if (page == 'e')
            {
                Console.WriteLine("Estou editando");
                navigationManager.NavigateTo($"Admin/Turmas/Edit/{id}");
            }
            GetTurmas();
            StateHasChanged();
        }

        protected void ConfirmDelete(int id, string nome)
        {
            TurmaId = id;
            ModalParameters parameters = new ModalParameters();
            parameters.Add("Mensagem", $"Tem certeza que deseja apagar a turma \n {id} - {nome} ?");
            parameters.Add("SimText", "Confirmar");
            parameters.Add("NaoText", "Cancelar");
            Modal.OnClose += ModalClose;
            Modal.Show<ConfirmDelete>("Deletar turma", parameters);
        }

        private async void ModalClose(ModalResult result)
        {
            if (!result.Cancelled)
            {
                isLoading = true;
                Turmas.Clear();
                StateHasChanged();
                await Client.DeleteAsync($"/api/turmas/{TurmaId}");
                Message = "Turma deletada com sucesso!";
                MessageColor = "Color:Green";
                await GetTurmas();
                StateHasChanged();
            }
            isLoading = false;
            Modal.OnClose -= ModalClose;
        }
    }
}
