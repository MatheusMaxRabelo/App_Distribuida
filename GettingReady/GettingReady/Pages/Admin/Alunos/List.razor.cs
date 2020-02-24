using GettingReady.Model;
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

        public List<Aluno> Alunos { get; set; }
        public bool isFiltered { get; set; } = false;
        public bool isSortedAsc { get; set; } = false;
        public string OrdenarPor { get; set; }

        protected override Task OnInitializedAsync()
        {
            Alunos = new List<Aluno>();
            Alunos.Add(new Aluno
            {
                Id=1,
                Nome="Matheus Maximiano Rabelo",
                Matricula=599950,
                areaId=333,
                areaConhecimento=new AreaConhecimento { Nome="Sistemas de Informação"}
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
    }
}
