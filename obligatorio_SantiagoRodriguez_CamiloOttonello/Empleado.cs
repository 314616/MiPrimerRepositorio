
using obligatorio_SantiagoRodriguez_CamiloOttonello.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio_SantiagoRodriguez_CamiloOttonello
{
    public abstract class Empleado : IValidar
    {
        public string email { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int id { get; set; }
        private static int idClase {  get; set; } = 0;

        // Constructor vacio
        public Empleado(string email, string contraseña, string nombre, DateTime fechaIngreso) 
        { 
            this.email = email;
            this.contraseña = contraseña;
            this.nombre = nombre;   
            this.fechaIngreso = fechaIngreso;
            this.id = idClase++;
        }



        public void logIn()
        {
            //LOGICA, no es necesaria
        }
        private void validarContraseña()
        {
            if (this.contraseña.Length < 8)
            {
                throw new Exception("Contraseña debe tener al menos 8 caracteres");
            }
        }
        public void Validar()
        {
            validarContraseña();
        }

    }
}
