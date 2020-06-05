using BlazorInputFile;
using GettingReady.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Disciplinas
{
    public class CreateBase:ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }
        IFileListEntry file;
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
        public bool isLoading { get; set; } = false;
        public bool isFiltered { get; set; } = false;
        public bool isSortedAsc { get; set; } = false;
        public string OrdenarPor { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await Load();
        }
        protected Task Load()
        {
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            StateHasChanged();
            return Task.CompletedTask;
        }
        public async Task HandleFile(IFileListEntry[] files)
        {
            Disciplinas.Clear();
            if (files.Length != 0)
            {
                file = files.FirstOrDefault();

                var dados = new StreamReader(file.Data);
                Console.WriteLine(dados);
                if (file != null)
                {
                    while (true)
                    {
                        var info = await dados.ReadLineAsync();
                        if (info == null)
                        {
                            break;
                        }
                        var disciplina = info.Split(';');
                        if(disciplina[2]=="1"|| disciplina[2] == "0")
                        {
                            Console.WriteLine("Entrei Aqui");
                            Disciplinas.Add(new Disciplina
                            {
                                Id = Convert.ToInt32(disciplina[0]),
                                Nome = disciplina[1],
                                Favorito = disciplina[2] == "0" ? true : false
                            }) ;
                        }
                    }
                }
            }
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
        protected void DeleteDisciplina(int id)
        {
            Disciplinas.Remove(Disciplinas.Where(x => x.Id == id).FirstOrDefault());
            StateHasChanged();
        }
        protected async void Add()
        {
            isLoading = true;

            foreach (var item in Disciplinas)
            {
                await Client.PostJsonAsync("api/Disciplinas", item);
            }
            isLoading = false;
            StateHasChanged();
            navigationManager.NavigateTo("Admin/Disciplinas/Index");
        }
    }
}
