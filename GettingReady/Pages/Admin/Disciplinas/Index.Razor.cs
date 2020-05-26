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

namespace GettingReady.Pages.Admin.Disciplinas
{
    public class IndexPage:ComponentBase
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }
        [Inject]
        public IModalService Modal { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        public int DisciplinaId { get; set; }
        public List<Disciplina> aux { get; set; }
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
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
            await GetDisciplinas();
            StateHasChanged();
        }
        protected async Task GetDisciplinas()
        {
            isLoading = true;
            aux = await Client.GetJsonAsync<List<Disciplina>>("/api/Disciplinas");
            aux.OrderBy(x => x.Nome);
            Disciplinas = aux;
            isLoading = false;
            DisciplinaId = 0;
        }
        protected void SortTable(string campoOrdenar)
        {
            if (campoOrdenar != OrdenarPor)
            {
                Disciplinas = Disciplinas.OrderBy(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();
                isSortedAsc = true;
                OrdenarPor = campoOrdenar;
            }
            else
            {
                if (isSortedAsc)
                    Disciplinas = Disciplinas.OrderByDescending(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();
                else
                    Disciplinas = Disciplinas.OrderBy(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();

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
                navigationManager.NavigateTo($"Admin/Disciplinas/Detail/{id}");
            }

            else if (page == 'e')
            {
                Console.WriteLine("Estou editando");
                navigationManager.NavigateTo($"Admin/Disciplinas/Edit/{id}");
            }
            GetDisciplinas();
            StateHasChanged();
        }

        protected void ConfirmDelete(int id, string nome)
        {
            Console.WriteLine(DisciplinaId);
            DisciplinaId = id;
            ModalParameters parameters = new ModalParameters();
            parameters.Add("Mensagem", $"Tem certeza que deseja apagar a disciplina \n {nome.ToUpper()} ?");
            parameters.Add("SimText", "Confirmar");
            parameters.Add("NaoText", "Cancelar");

            Modal.OnClose += ModalClose;
            Modal.Show<ConfirmDelete>("Deletar Disciplina", parameters);
        }

        private async void ModalClose(ModalResult result)
        {
            if (!result.Cancelled)
            {
                Console.WriteLine(DisciplinaId);
                isLoading = true;
                Disciplinas.Clear();
                StateHasChanged();
                await Client.DeleteAsync($"/api/disciplinas/{DisciplinaId}");
                Message = "Disciplina deletada com sucesso!";
                MessageColor = "Color:Green";
                Disciplinas = null;
                await GetDisciplinas();
                StateHasChanged();
            }

            Modal.OnClose -= ModalClose;
        }
    }
}
