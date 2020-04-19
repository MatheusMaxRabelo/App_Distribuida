using BlazorInputFile;
using GettingReady.Model;
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

namespace GettingReady.Pages.Admin.Alunos
{
    public class CreatePage : ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }

        [Inject]
        public NavigationManager navigationManager { get; set; }
        public List<Aluno> Alunos { get; set; }
        IFileListEntry file;
        public bool isFiltered { get; set; } = false;
        public bool isSortedAsc { get; set; } = false;
        public string OrdenarPor { get; set; }
        public bool isLoading { get; set; } = false;
        public string Message = string.Empty;

        protected async override Task OnInitializedAsync()
        {
            await Load();
        }

        protected async Task Load()
        {
            Alunos = new List<Aluno>();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
           // Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            StateHasChanged();
        }

        public async Task HandleFile(IFileListEntry[] files)
        {
            Alunos.Clear();
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
                        var aluno = info.Split(';');
                        Alunos.Add(new Aluno
                        {
                            Matricula = Convert.ToInt32(aluno[0]),
                            Nome = aluno[1],
                            CursoId = Convert.ToInt32(aluno[2])
                        });
                    }
                }
            }
        }
        protected void SortTable(string campoOrdenar)
        {
            if (campoOrdenar != OrdenarPor)
            {
                Alunos = Alunos.OrderBy(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();
                isSortedAsc = true;
                OrdenarPor = campoOrdenar;
            }
            else
            {
                if (isSortedAsc)
                    Alunos = Alunos.OrderByDescending(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();
                else
                    Alunos = Alunos.OrderBy(x => x.GetType().GetProperty(campoOrdenar).GetValue(x, null)).ToList();

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
        protected void DeleteAluno(int matricula)
        {
            Alunos.Remove(Alunos.Where(x => x.Matricula == matricula).FirstOrDefault());
            StateHasChanged();
        }

        protected async void AddAluno()
        {
            isLoading = true;
            var jsonContent = JsonConvert.SerializeObject(Alunos);
            Console.WriteLine(jsonContent);
            Console.WriteLine(Client.BaseAddress);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync("/api/Alunos", contentString);
            if (response.IsSuccessStatusCode)
                navigationManager.NavigateTo("Admin/Alunos/List");
            Message = "Não foi possível salvar os alunos";
            isLoading = false;
            StateHasChanged();
        }
    }
}