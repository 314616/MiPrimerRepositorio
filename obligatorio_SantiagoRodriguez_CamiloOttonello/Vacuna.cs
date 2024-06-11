using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio_SantiagoRodriguez_CamiloOttonello
{
    public class Vacuna
    {
        public string nombre {  get; set; }
        public string descripcion { get; set; }
        public string patogeno { get; set; }

        public Vacuna(string nombre, string descripcion, string patogeno) 
        {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.patogeno = patogeno;
        }
    }
}
