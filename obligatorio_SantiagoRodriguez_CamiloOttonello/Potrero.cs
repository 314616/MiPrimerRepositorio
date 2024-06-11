using obligatorio_SantiagoRodriguez_CamiloOttonello.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio_SantiagoRodriguez_CamiloOttonello
{
    public class Potrero : IValidar
    {
        public int id {  get; set; }
        public static int idClase { get; set; } = 0;
        public string descripcion { get; set; }
        public int cantHectareas { get; set; }
        public int capacidadMaxAnimales { get; set; }
        public List<Animal> animalesPastando { get; set; }
        public double gananciaParcial { get; set; }

        public Potrero(string descripcion, int cantHectareas, int capacidadMaxAnimales) 
        {
            this.id = idClase++;
            this.animalesPastando = new List<Animal>();
            this.descripcion = descripcion;
            this.cantHectareas = cantHectareas;
            this.capacidadMaxAnimales = capacidadMaxAnimales;
        }

        private void validarSuperaCapacidad()
        {
            int contador = 0;
            foreach (Animal a in animalesPastando)
            {
                contador++;
            }                          
            if(this.capacidadMaxAnimales <= contador)
            {
                throw new Exception("Se alcanzo la capacidad maxima de animales para este potrero, no se pueden asignar mas.");
            }
        }
        public void Validar()
        {
            validarSuperaCapacidad();         
        }
        public void CalcularGananciaPotrero()
        {
            //LOGICA
        }
        public override string ToString()
        {
            return $"Identificador de potrero: " + this.id + "\nDescripcion: " + this.descripcion + "\nCantidad de hectareas: " + this.cantHectareas +
                "\nCapacidad maxima de animales: " + this.capacidadMaxAnimales; 
        }
    }
}
