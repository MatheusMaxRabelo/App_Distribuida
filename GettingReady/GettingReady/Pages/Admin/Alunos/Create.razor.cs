using BlazorInputFile;
using GettingReady.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Alunos
{
    public class CreatePage : ComponentBase
    {
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();

        IFileListEntry file;
        public bool isFiltered { get; set; } = false;
        public bool isSortedAsc { get; set; } = false;
        public string OrdenarPor { get; set; }

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
                            areaId = Convert.ToInt32(aluno[2])
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

    }
}