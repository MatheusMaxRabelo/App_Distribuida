using BlazorInputFile;
using GettingReady.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Professores
{
    public class CreateProfessor : ComponentBase
    {
        public List<Professor> Professores { get; set; } = new List<Professor>();

        IFileListEntry file;
        public bool isFiltered { get; set; } = false;
        public bool isSortedAsc { get; set; } = false;
        public string OrdenarPor { get; set; }

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
                            Matricula = Convert.ToInt32(Professor[0]),
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
            Professores.Remove(Professores.Where(x => x.Matricula == matricula).FirstOrDefault());
            StateHasChanged();
        }

    }
}