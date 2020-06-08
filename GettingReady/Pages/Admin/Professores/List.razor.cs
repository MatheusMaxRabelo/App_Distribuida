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

namespace GettingReady.Pages.Admin.Professores
{
    public class ListProfessor : ComponentBase
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }
        [Inject]
        public IModalService Modal { get; set; }
        [Inject]
        public HttpClient Client { get; set; }

        public int ProfessorId { get; set; }
        public List<Professor> aux { get; set; }
        public List<Professor> Professores { get; set; } = new List<Professor>();
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
            await GetProfessores();
            StateHasChanged();
        }

        protected async Task GetProfessores()
        {
            isLoading = true;
            aux = await Client.GetJsonAsync<List<Professor>>("/api/Professores");
            aux.OrderBy(x => x.Nome);
            Professores = aux;
            isLoading = false;
        }

        protected void SortTable(string campoOrdenar)
        {
            if (campoOrdenar != OrdenarPor)
            {
                Professores = Professores.OrderBy(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();
                isSortedAsc = true;
                OrdenarPor = campoOrdenar;
            }
            else
            {
                if (isSortedAsc)
                    Professores = Professores.OrderByDescending(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();
                else
                    Professores = Professores.OrderBy(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();

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
            navigationManager.NavigateTo($"Admin/Professores/{page}/{id}");
        }

        protected void DeleteProfessor(int matricula)
        {
            Professores.Remove(Professores.Where(x => x.Id == matricula).FirstOrDefault());
            StateHasChanged();
        }

        protected void ConfirmDelete(int matricula, string nome)
        {
            ProfessorId = matricula;
            ModalParameters parameters = new ModalParameters();
            parameters.Add("Mensagem", $"Tem certeza que deseja apagar o professor \n {nome.ToUpper()} ?");
            parameters.Add("SimText", "Confirmar");
            parameters.Add("NaoText", "Cancelar");

            Modal.OnClose += ModalClose;
            Modal.Show<ConfirmDelete>("Deletar professor", parameters);
        }

        private async void ModalClose(ModalResult result)
        {
            if (!result.Cancelled)
            {
                await Client.DeleteAsync($"/api/professores/{ProfessorId}");
                Message = "Professor deletado com sucesso!";
                MessageColor = "Color:Green";
                Professores = null;
                await GetProfessores();
                StateHasChanged();
            }

            Modal.OnClose -= ModalClose;
        }
    }
}
