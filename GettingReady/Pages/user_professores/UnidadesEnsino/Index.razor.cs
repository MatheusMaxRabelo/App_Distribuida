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
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.user_professores.UnidadesEnsino
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }
        [Inject]
        public IModalService Modal { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        public int UnidadeId { get; set; }
        public List<UnidadeEnsino> Unidades { get; set; } = new List<UnidadeEnsino>();
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
            await GetUnidades();
            StateHasChanged();
        }
        protected async Task GetUnidades()
        {
            isLoading = true;
            Unidades = await Client.GetJsonAsync<List<UnidadeEnsino>>("/api/UnidadesEnsino");
            Console.WriteLine(Unidades.Count);
            var jsonContent = JsonConvert.SerializeObject(Unidades);
            Console.WriteLine(jsonContent);
            isLoading = false;
        }
        protected void SortTable(string campoOrdenar)
        {
            if (campoOrdenar != OrdenarPor)
            {
                Unidades = Unidades.OrderBy(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();
                isSortedAsc = true;
                OrdenarPor = campoOrdenar;
            }
            else
            {
                if (isSortedAsc)
                    Unidades = Unidades.OrderByDescending(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();
                else
                    Unidades = Unidades.OrderBy(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();

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
                navigationManager.NavigateTo($"Admin/Alunos/Detail/{id}");
            }

            else if (page == 'e')
            {
                Console.WriteLine("Estou editando");
                navigationManager.NavigateTo($"Admin/Alunos/Edit/{id}");
            }
            GetUnidades();
            StateHasChanged();
        }

        protected void ConfirmDelete(int unidadeId, string nome)
        {
            UnidadeId = unidadeId;
            ModalParameters parameters = new ModalParameters();
            parameters.Add("Mensagem", $"Tem certeza que deseja apagar a unidade \n {nome.ToUpper()} ?");
            parameters.Add("SimText", "Confirmar");
            parameters.Add("NaoText", "Cancelar");
            Modal.OnClose += ModalClose;
            Modal.Show<ConfirmDelete>("Deletar Unidade", parameters);
        }

        private async void ModalClose(ModalResult result)
        {
            if (!result.Cancelled)
            {
                isLoading = true;
                Unidades.Clear();
                StateHasChanged();
                await Client.DeleteAsync($"/api/alunos/{UnidadeId}");
                Message = "Unidade deletada com sucesso!";
                MessageColor = "Color:Green";
                await GetUnidades();
                StateHasChanged();
            }
            isLoading = false;
            Modal.OnClose -= ModalClose;
        }
    }
}
