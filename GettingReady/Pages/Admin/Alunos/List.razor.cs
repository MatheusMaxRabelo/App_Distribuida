﻿using Blazored.Modal;
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

namespace GettingReady.Pages.Admin.Alunos
{
    public class ListPage:ComponentBase
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }
        [Inject]
        public IModalService Modal { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        public Paginas Pagina { get; set; } = new Paginas { Atual =1,ItensPagina = 10 };
        public int AlunoId { get; set; }
        public List<Aluno> aux { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
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
            await GetAlunos();
            StateHasChanged();
        }
        protected async Task GetAlunos()
        {
            isLoading = true;
            aux = await Client.GetJsonAsync<List<Aluno>>("/api/Alunos");
            aux.OrderBy(x => x.Nome);
            Alunos = aux;
            isLoading = false;
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

        protected void Paginacao(int quant)
        {
            Pagina.ItensPagina = quant;
            Pagina.Total = Alunos.Count / quant;
            PaginarAlunos();
            StateHasChanged();
        }
        protected void PaginarAlunos()
        {
            Pagina.Total = Alunos.Count / Pagina.ItensPagina;
            Alunos = aux.Skip((Pagina.Atual - 1) * Pagina.ItensPagina)
                .Take(Pagina.ItensPagina).ToList();
        }
        protected void NextPage(int page)
        {
            Pagina.Atual = page;
            PaginarAlunos();
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

        protected void NavigateTo(int id)
        {
            navigationManager.NavigateTo($"Admin/Alunos/Detail/{id}");
        }

        protected void ConfirmDelete(int matricula, string nome)
        {
            AlunoId = matricula;
            ModalParameters parameters = new ModalParameters();
            parameters.Add("Mensagem", $"Tem certeza que deseja apagar o aluno \n {nome.ToUpper()} ?");
            parameters.Add("SimText", "Confirmar");
            parameters.Add("NaoText", "Cancelar");

            Modal.OnClose += ModalClose;
            Modal.Show<ConfirmDelete>("Deletar aluno", parameters);
        }

        private async void ModalClose(ModalResult result)
        {
            if (!result.Cancelled)
            {
                await Client.DeleteAsync($"/api/alunos/{AlunoId}");
                Message = "Aluno deletado com sucesso!";
                MessageColor = "Color:Green";
                Alunos = null;
                await GetAlunos();
                StateHasChanged();
            }

            Modal.OnClose-=ModalClose;
        }
    }
}