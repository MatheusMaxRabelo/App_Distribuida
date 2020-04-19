using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Alunos
{
    public class EditPage:ComponentBase
    {
        [Parameter]
        public int AlunoId { get; set; }
    }
}
