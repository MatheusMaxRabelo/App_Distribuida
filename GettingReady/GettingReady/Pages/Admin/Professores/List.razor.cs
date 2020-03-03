using GettingReady.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Professores
{
    public class ListProfessor : ComponentBase
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public List<Professor> Professores { get; set; }
        public bool isFiltered { get; set; } = false;
        public bool isSortedAsc { get; set; } = false;
        public string OrdenarPor { get; set; }

        protected override Task OnInitializedAsync()
        {
            Professores = new List<Professor>();
            Professores.Add(new Professor
            {
                Id = 1,
                Nome = "Kleber Jacques Ferreira de Souza",
                Matricula = 111111,
            });
            return base.OnInitializedAsync();
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

        protected void NavigateTo(int id)
        {
            navigationManager.NavigateTo($"Admin/Professores/Detail/{id}");
        }

        protected void DeleteProfessor(int matricula)
        {
            Professores.Remove(Professores.Where(x => x.Matricula == matricula).FirstOrDefault());
            StateHasChanged();
        }
    }
}
