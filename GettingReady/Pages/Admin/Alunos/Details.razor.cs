using GettingReady.Model;
using GettingReady.ViewModel.Admin;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Alunos
{
    public class DetailsPage : ComponentBase
    {
        [Parameter]
        public int AlunoId { get; set; }
        public AlunoData Aluno { get; set; }


        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
        }
    }
}
