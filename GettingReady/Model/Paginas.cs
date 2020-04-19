using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Paginas
    {
        public int Atual { get; set; }
        public int ItensPagina { get; set; }
        public int Total { get; set; }
        public int Anterior { get; set; }
        public int Proxima { get; set; }
        public bool Next { get; set; } = false;
        public bool Previous { get; set; } = false;
    }
}
