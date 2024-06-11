using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio_SantiagoRodriguez_CamiloOttonello
{
    public class Bovino : Animal
    {
        public TipoAlimento tipoAlimento {  get; set; }
        public static double precioKgBovino { get; set; } = 2000;

        public Bovino(string id, TipoSexo sexo, string raza, DateTime fechaNacimimento, double costoAdquisicion, double costoAlimentacion, double pesoActual, bool esHibrido, bool esLibre, TipoAlimento tipoAlimento) : base (id, sexo, raza, fechaNacimimento, costoAdquisicion, costoAlimentacion, pesoActual, esHibrido, esLibre)
        {
            this.tipoAlimento = tipoAlimento;
        }
        public Bovino(string id, TipoSexo sexo, string raza, DateTime fechaNacimimento, double costoAdquisicion, double costoAlimentacion, double pesoActual, bool esHibrido, TipoAlimento tipoAlimento) : base (id, sexo, raza, fechaNacimimento, costoAdquisicion, costoAlimentacion, pesoActual, esHibrido)
        {
            this.tipoAlimento = tipoAlimento;
        }
        public Bovino(string id) : base(id)
        {
        }
        protected override void CalcularVentaPotencial()
        {
            //LOGICA
        }

        // El equals este DEBERIA que ir en Animal, habria que ponerlo y probar que funcione. 

    }
}
