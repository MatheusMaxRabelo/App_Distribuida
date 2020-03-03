using Blazored.Modal;
using Blazored.Modal.Services;
using GettingReady.Model;
using GettingReady.Shared.Componentes;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public int AlunoId { get; set; }

        public List<Aluno> Alunos { get; set; }
        public bool isFiltered { get; set; } = false;
        public bool isSortedAsc { get; set; } = false;
        public string OrdenarPor { get; set; }

        protected override Task OnInitializedAsync()
        {
            Alunos = new List<Aluno>();
            Alunos.Add(new Aluno
            {
                Nome="Matheus Maximiano Rabelo",
                Matricula=599950,
                areaId=333,
                Curso=new Curso { Nome="Sistemas de Informação"}
            });
            return base.OnInitializedAsync();
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
                Alunos.Remove(Alunos.Where(x => x.Matricula == AlunoId).FirstOrDefault());
                StateHasChanged();
            }

            Modal.OnClose-=ModalClose;
        }
    }
}
