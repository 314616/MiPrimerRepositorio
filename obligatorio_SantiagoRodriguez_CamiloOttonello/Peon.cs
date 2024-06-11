using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio_SantiagoRodriguez_CamiloOttonello
{
    public class Peon : Empleado
    {
        public bool residenteEstancia { get; set; }
        public List<Tarea> tareas { get; set; }
        
        public Peon(string email, string contraseña, string nombre, DateTime fechaIngreso, bool residenteEstancia) : base(email, contraseña, nombre, fechaIngreso)
        {
            this.tareas = new List<Tarea>();
            this.residenteEstancia = residenteEstancia;
        }

        public void ComentarTarea(int id, string comentario)
        {
            foreach (Tarea t in tareas)
            {
                if (t.id.Equals(id))
                {
                    if (!t.tareaCompletada) 
                    {
                        t.comentario = comentario;
                    }
                 
                }
            }
        }
        public List<Tarea> MostrarTareas()
        {
            return tareas;
        }
    }
}