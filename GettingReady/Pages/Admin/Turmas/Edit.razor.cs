﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Pages.Admin.Turmas
{
    public class EditBase:ComponentBase
    {
        [Parameter]
        public int TurmaId { get; set; }
    }
}
