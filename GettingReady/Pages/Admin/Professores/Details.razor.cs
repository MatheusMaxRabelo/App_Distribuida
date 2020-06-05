﻿using GettingReady.Model;
using GettingReady.ViewModel.Admin;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Professores
{
    public class DetailsProfessor : ComponentBase
    {
        [Parameter]
        public int ProfessorId { get; set; }
        public ProfessorData Professor { get; set; }
        [Inject]
        public HttpClient Client { get; set; }
        public bool isLoading { get; set; } = true;


        protected override async Task OnInitializedAsync()
        {
            await Load();
        }
        protected async Task Load()
        {
            Professor = new ProfessorData();
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://trabalhocleber.azurewebsites.net");
            Professor.ProfessorInfo = await Client.GetJsonAsync<Professor>($"api/Professores/{ProfessorId}");
        }
    }
}
