using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.user_professores.Assuntos
{
    public class CreateBase:ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }

        [Inject]
        public NavigationManager navigationManager { get; set; }
    }
}
