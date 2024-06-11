using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace obligatorio_SantiagoRodriguez_CamiloOttonello
{
    public class Capataz : Empleado
    {
        public int cantidadDependientes { get; set; }
        

 
        public Capataz(string email, string contraseña, string nombre, DateTime fechaIngreso, int cantidadDependientes) : base (email, contraseña, nombre, fechaIngreso)
        { 
        this.cantidadDependientes = cantidadDependientes;
        }
    }
}
