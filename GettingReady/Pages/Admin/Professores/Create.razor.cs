using BlazorInputFile;
using Blazored.Modal;
using Blazored.Modal.Services;
using GettingReady.Model;
using GettingReady.Shared.Componentes;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Professores
{
    public class CreateProfessor : ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }
        [Inject]
        public IModalService Modal { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }
        public List<Professor> Professores { get; set; } = new List<Professor>();

        IFileListEntry file;
        public int ProfessorId { get; set; }
        public bool isFiltered { get; set; } = false;
        public bool isSortedAsc { get; set; } = false;
        public string OrdenarPor { get; set; }
        public bool isLoading { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public string MessageColor { get; set; } = string.Empty;

        protected async override Task OnInitializedAsync()
        {
            await Load();
        }

        protected async Task Load()
        {
            Professores = new List<Professor>();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            StateHasChanged();
        }

        public async Task HandleFile(IFileListEntry[] files)
        {
            Professores.Clear();
            if (files.Length != 0)
            {
                file = files.FirstOrDefault();
                var dados = new StreamReader(file.Data);
                if (file != null)
                {
                    while (true)
                    {
                        var info = await dados.ReadLineAsync();
                        if (info == null)
                        {
                            break;
                        }
                        var Professor = info.Split(';');
                        Professores.Add(new Professor
                        {
                            Id = Convert.ToInt32(Professor[0]),
                            Nome = Professor[1]
                        });
                    }
                }
            }
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
        protected void DeleteProfessor(int matricula)
        {
            Professores.Remove(Professores.Where(x => x.Id == matricula).FirstOrDefault());
            StateHasChanged();
        }

        protected void ConfirmDelete(int matricula, string nome)
        {
            ProfessorId = matricula;
            ModalParameters parameters = new ModalParameters();
            parameters.Add("Mensagem", $"Tem certeza que deseja apagar o professor {nome.ToUpper()}?");
            parameters.Add("SimText", "Confirmar");
            parameters.Add("NaoText", "Cancelar");

            Modal.OnClose += ModalClose;
            Modal.Show<ConfirmDelete>("Deletar professor", parameters);
        }

        private void ModalClose(ModalResult result)
        {
            if (!result.Cancelled)
            {
                Professores.Remove(Professores.Where(x => x.Id == ProfessorId).FirstOrDefault());
                Message = "Professor deletado com sucesso!";
                MessageColor = "color: green";
                //Professores = null;
                StateHasChanged();
            }
            else
                Modal.OnClose -= ModalClose;
        }

        protected async void AddProfessor()
        {
            isLoading = true;
            var jsonContent = JsonConvert.SerializeObject(Professores);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync("/api/professores", contentString);

            if (response.IsSuccessStatusCode)
                navigationManager.NavigateTo("Admin/Professores/List");
            
            Message = "Não foi possível salvar os professores";
            
            isLoading = false;
            StateHasChanged();
        }

    }
}