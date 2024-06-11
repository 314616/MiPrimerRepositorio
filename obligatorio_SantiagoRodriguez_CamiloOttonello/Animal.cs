using obligatorio_SantiagoRodriguez_CamiloOttonello.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace obligatorio_SantiagoRodriguez_CamiloOttonello
{
    public abstract class Animal : IValidar
    {
        public string id {  get; set; }
        public TipoSexo sexo { get; set; }
        public string raza { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public double costoAdquisicion {  get; set; }
        public double costoAlimentacion { get; set; }
        public double pesoActual {  get; set; }
        public bool esHibrido { get; set; }
        public List<VacunaAplicada> vacunacionesAplicadas { get; set; }
        public bool esLibre {  get; set; }

        public Animal(string id, TipoSexo sexo, string raza, DateTime fechaNacimimento, double costoAdquisicion, double costoAlimentacion, double pesoActual, bool esHibrido, bool esLibre)
        {
            this.vacunacionesAplicadas = new List<VacunaAplicada>();
            this.id = id;
            this.sexo = sexo;
            this.raza = raza;
            this.fechaNacimiento = fechaNacimimento;
            this.costoAdquisicion = costoAdquisicion;
            this.costoAlimentacion = costoAlimentacion;
            this.pesoActual = pesoActual;
            this.esHibrido = esHibrido;
            this.esLibre = esLibre;
        }
        public Animal(string id, TipoSexo sexo, string raza, DateTime fechaNacimimento, double costoAdquisicion, double costoAlimentacion, double pesoActual, bool esHibrido)
        {
            this.vacunacionesAplicadas = new List<VacunaAplicada>();
            this.id = id;
            this.sexo = sexo;
            this.raza = raza;
            this.fechaNacimiento = fechaNacimimento;
            this.costoAdquisicion = costoAdquisicion;
            this.costoAlimentacion = costoAlimentacion;
            this.pesoActual = pesoActual;
            this.esHibrido = esHibrido;
            this.esLibre = true;

        }

        public Animal(string id) 
        {
            this.id = id;
        }

        private void validarCodigo()
        {
            if(this.id.Length < 8)
            {
                throw new Exception("El codigo debera tener al menos 8 caracteres");
            }
        }
        private void validarEdad()
        {
            DateTime fechaNacimiento = this.fechaNacimiento;
            DateTime actual = DateTime.Now;
            TimeSpan edad = actual - fechaNacimiento;
            if (edad.Days < 92)
            {
                throw new Exception("No se puede vacunar, es menor a 3 meses de edad");
            }
        }
        public void RegistrarVacuna(VacunaAplicada vAplicada)
        {
            validarEdad();
            vacunacionesAplicadas.Add(vAplicada);
        }
        public void Validar() 
        {
            validarCodigo();
            //LOGICA
        }


        public void CalcularCostoCrianza()
        {
            //LOGICA
        }
        public void CalcularGanancia()
        {
            //LOGICA
        }
        protected abstract void CalcularVentaPotencial();

        public override string ToString()
        {
            return $"I- El Id del animal es {this.id}\n" +
                $"II- Es de raza {this.raza}\n" +
                $"III- El peso actual del animal es de {this.pesoActual} kg\n" +
                $"IV- El sexo del animal es {this.sexo}";
        }
        public override bool Equals(object? otroObjeto)
        {
            Animal a = (Animal)otroObjeto;
            return a.id == this.id;
        }
    }
}
