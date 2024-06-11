using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio_SantiagoRodriguez_CamiloOttonello
{
    public class Tarea
    {
        public int id {  get; set; }
        public static int idClase { get; set; } = 0;
        public string descripcion { get; set; }
        public DateTime fechaPactada { get; set; }
        public bool tareaCompletada {  get; set; }
        public DateTime fechaCierre { get; set; }
        public string comentario { get; set; }
        public Capataz asignadaPor {  get; set; }

        //constructor vacio
        public Tarea(string descripcion, DateTime fechaPactada, DateTime fechaCierre, bool tareaCompletada,string comentario, Capataz asignadaPor)
        {
            this.id = idClase++;
            this.descripcion = descripcion;
            this.fechaPactada = fechaPactada;
            this.tareaCompletada = tareaCompletada;
            this.fechaCierre = fechaCierre;
            this.comentario = comentario;
            this.asignadaPor = asignadaPor;
        }
        public Tarea(string descripcion, DateTime fechaPactada, Capataz asignadaPor) 
        { 
            this.id = idClase++;
            this.descripcion = descripcion;
            this.fechaPactada = fechaPactada;
            this.tareaCompletada = false;
            this.comentario = "";
            this.asignadaPor = asignadaPor;
        }

        public override bool Equals(object? obj)
        {
            Tarea t = (Tarea)obj;
            return t.id == this.id;
        }
        public override string ToString() 
        {
            return $"La id de la tarea es {this.id}";
        }
    }
}
