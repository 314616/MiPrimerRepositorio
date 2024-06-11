using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio_SantiagoRodriguez_CamiloOttonello
{
    public class Ovino : Animal
    {
        public double pesoLana {  get; set; }
        public static double precioKgLana { get; set; } = 13.8;
        public static double precioKgOvino { get; set; } = 2640;

        public Ovino(string id, TipoSexo sexo, string raza, DateTime fechaNacimimento, double costoAdquisicion, double costoAlimentacion, double pesoActual, bool esHibrido, bool esLibre, double pesoLana) : base(id, sexo, raza, fechaNacimimento, costoAdquisicion, costoAlimentacion, pesoActual, esHibrido, esLibre)
        {
            this.pesoLana = pesoLana;
        }
        protected override void CalcularVentaPotencial()
        {
            //LOGICA
        }
    }
}
