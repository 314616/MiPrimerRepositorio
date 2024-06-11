using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio_SantiagoRodriguez_CamiloOttonello
{
    public class VacunaAplicada
    {
        public Vacuna tipoVacuna {  get; set; }
        public DateTime fechaAplicacion { get; set; }
        public DateTime fechaVencimiento { get; set; } 
        
        public VacunaAplicada(Vacuna vacuna, DateTime fechaAplicacion) 
        {
            this.tipoVacuna = vacuna;
            this.fechaAplicacion = fechaAplicacion;
            this.fechaVencimiento = fechaAplicacion.AddYears(1);
        }

        /*public override string ToString()
        {
            return "fecha V" + this.fechaVencimiento;
        }*/
    }
}
