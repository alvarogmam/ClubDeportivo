using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Modelos
{
    public class Cuota
    {
        public int IdCuota { get; set; }
        public int IdSocio { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estado { get; set; }
    }
}
