using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Shared.Componentes
{
    public class ConfirmDeletePage:ComponentBase
    {
        [Inject]
        public IModalService Modal { get; set; }

        [CascadingParameter] ModalParameters Parameters { get; set; }
        public string Mensagem { get; set; }
        public string SimText { get; set; }
        public string NaoText { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            Mensagem = Parameters.Get<string>("Mensagem");
            SimText = Parameters.Get<string>("SimText");
            NaoText = Parameters.Get<string>("NaoText");
        }

        protected void Confirm()
        {
            Modal.Close(ModalResult.Ok<string>(""));
        }
        protected void Cancelar()
        {
            Modal.Cancel();
        }
    }
}
