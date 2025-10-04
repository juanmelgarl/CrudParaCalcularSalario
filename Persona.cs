using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApps
{
    public class Persona
    {
        public string? Nombre {  get; set; }
        public decimal sueldo { get; set; }
        public decimal aumento { get; set; }
        public decimal sueldoFinal => sueldo + (sueldo * aumento / 100);
        public DateTime registro {  get; set; } = DateTime.Now;
    }
}
