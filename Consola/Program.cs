using obligatorio_SantiagoRodriguez_CamiloOttonello;
using System.ComponentModel.Design;
using System.Data;

namespace Consola
{
    public class Program
    {

        public static Sistema s = new Sistema();

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Opcion 1- Listar todos los animales.");
                Console.WriteLine("Opcion 2- Mostrar los potreros con una cantidad de hectareas y capacidad maxima mayor a la ingresada.");
                Console.WriteLine("Opcion 3- Establecer el precio por kilogramo de lana de los ovinos.");
                Console.WriteLine("Opcion 4- Alta de ganado bovino.");
                Console.WriteLine("Opcion 0- Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        OpcionListarAnimales();
                        break;
                    case "2":
                        Console.Clear();
                        FiltrarPotreros();
                        break;
                    case "3":
                        Console.Clear();
                        IngresarPrecioLana();
                        break;
                    case "4":
                        DarDeAltaUnBovino();
                        break;
                    case "5":
                    
                        Console.ReadKey();
                        break;
                    case "0":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("La opción no es válida");
                        Console.ReadKey();
                        break;
                }
            }
        }


        public static void OpcionListarAnimales()
        {
            Console.Clear();
            int contador = 0;
            try
            {
                List<Animal> animales = s.ObtenerListaAnimales();
                foreach (Animal a in animales)
                {
                    contador++;
                    Console.WriteLine("Animal: "+ contador);
                    Console.WriteLine(a);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Presione una tecla para volver al menu.");
            Console.ReadKey();
        }
        
        public static void FiltrarPotreros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de hectareas");
            bool exito1 = false;
            bool exito2 = false;
            int hectareas = 0;
            int capacidad = 0;
            while (!exito1)
            {
                exito1 = int.TryParse(Console.ReadLine(), out hectareas);
                if (!exito1 ) 
                {
                    Console.WriteLine("Por favor, ingrese un numero.");
                }
            }
            Console.WriteLine("Ingrese la capacidad maxima de animales");
            while (!exito2)
            {
                exito2 = int.TryParse(Console.ReadLine(), out capacidad);
                if (!exito2)
                {
                    Console.WriteLine("Por favor, ingrese un numero.");
                }
            }
            int contador = 0;
            List<Potrero> potrerosFiltrados = s.MostrarPotreros(hectareas, capacidad);
            foreach(Potrero p in potrerosFiltrados)
            {
                contador++;
                if (contador != 0) 
                {
                    Console.WriteLine("Potrero " + contador);
                    Console.WriteLine(p);
                }
                else
                {
                    Console.WriteLine("No hay nignun potrero con esas especifiaciones");
                }
            }
            Console.WriteLine("Presione una tecla para volver al menu.");
            Console.ReadKey();
        }
        public static void IngresarPrecioLana()
        {
            Console.Clear();
            Console.WriteLine("El precio de la lana actual es de: " + s.MostrarPrecioLana());
            bool exito1 = false;
            double precio = 0;
            Console.WriteLine("Ingrese el precio por kg de lana a establecer");
            while (!exito1) 
            {
                exito1 = double.TryParse(Console.ReadLine(), out precio);
                if (!exito1) 
                {
                    Console.WriteLine("Por favor, ingrese un numero");
                }
            }
            s.EstablecerPrecioKgLana(precio);
            Console.WriteLine("El precio de la lana actual es de: " + s.MostrarPrecioLana());
            Console.WriteLine("Presione una tecla para volver al menu.");
            Console.ReadKey();
        }

        public static void DarDeAltaUnBovino() 
        {
            Console.Clear();
            bool exitoCodigo = false;
            string idNoVerificado = "";
            while (!exitoCodigo) 
            {
                Console.WriteLine("Ingrese el Codigo Identificador del Bovino a dar de alta, recuerde, tiene que ser de minimo 8 caracteres y no puede ser igual a los anteriores.");
                idNoVerificado = Console.ReadLine();
                Bovino pruebaCodigo = new Bovino(idNoVerificado);
                try
                {
                    s.ValidarCodigo(pruebaCodigo);
                    exitoCodigo = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Ingrese 1 si el bovino es macho, 2 por si es hembra.");
            bool exitoNumeroSexo = false;
            bool exitoSexo = false;
            int nS = 0;
            TipoSexo tipoSexo;
            while (!exitoSexo)
            {
                while (!exitoNumeroSexo)
                {
                    exitoNumeroSexo = int.TryParse(Console.ReadLine(), out nS);
                    if (!exitoNumeroSexo)
                    {
                        Console.WriteLine("Por favor, ingrese un numero entero.");
                    }
                }
                if (nS == 1 || nS == 2) 
                {
                    exitoSexo = true;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese uno de los numeros solicitados.");
                }
            }
            if (nS == 1)
            {
                tipoSexo = TipoSexo.Macho;

            }
            else
            {
                tipoSexo = TipoSexo.Hembra;
            }

            Console.WriteLine("Ingrese la raza del animal.");
            string raza = Console.ReadLine();
            Console.WriteLine("A continuacion se le pedira la fecha de nacimiento en partes");

            bool exitoFecha = false;
            DateTime fechaNacimiento = DateTime.Now;
            int año = 0;
            int mes = 0;
            int dia = 0;
            //COMO VALIDAMOS LA FECHA CORRECTAMENTE. ?????????????????????????????
            while(!exitoFecha) 
            {
                bool exitoAño = false;
                bool exitoMes = false;
                bool exitoDia = false;
                Console.WriteLine("Año");
                while (!exitoAño)
                {
                    exitoAño = int.TryParse(Console.ReadLine(), out año);
                    if (!exitoAño)
                    {
                        Console.WriteLine("Por favor, ingrese un numero entero.");
                    }
                }
                Console.WriteLine("Mes");
                while (!exitoMes)
                {
                    exitoMes = int.TryParse(Console.ReadLine(), out mes);
                    if (!exitoMes)
                    {
                        Console.WriteLine("Por favor, ingrese un numero entero.");
                    }
                }
                Console.WriteLine("Dia");
                while (!exitoDia)
                {
                    exitoDia = int.TryParse(Console.ReadLine(), out dia);
                    if (!exitoDia)
                    {
                        Console.WriteLine("Por favor, ingrese un numero entero.");
                    }
                }
                try
                {
                    s.ValidarFecha(año, mes, dia);                  
                    fechaNacimiento = new DateTime(año, mes, dia);
                    exitoFecha = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }


            Console.WriteLine("Ingrese el costo de adquisision del Animal");
            bool exitoCosto = false;
            double costoAnimal = 0.00;
            while (!exitoCosto)
            {
                exitoCosto = double.TryParse(Console.ReadLine(), out costoAnimal);
                if (!exitoCosto)
                {
                    Console.WriteLine("Por favor, ingrese un numero.");
                }
            }
            Console.WriteLine("Ingrese el costo de alimentacion del animal");
            bool exitoAlimento = false;
            double costoAlimento = 0.00;
            while (!exitoAlimento)
            {
                exitoAlimento = double.TryParse(Console.ReadLine(), out costoAlimento);
                if (!exitoAlimento)
                {
                    Console.WriteLine("Por favor, ingrese un numero.");
                }
            }
            Console.WriteLine("Ingrese el peso del animal en KG");
            bool exitoPeso = false;
            double peso = 0.00;
            while (!exitoPeso)
            {
                exitoPeso = double.TryParse(Console.ReadLine(), out peso);
                if (!exitoPeso)
                {
                    Console.WriteLine("Por favor, ingrese un numero.");
                }
            }
            Console.WriteLine("Ingrese 1 si el animal es pura sangre, 2 si el animal es hibrido.");
            bool exitoNumeroHibrido = false;
            bool exitoHibrido = false;
            int nH = 0;
            bool esHibrido;
            while (!exitoHibrido)
            {
                while (!exitoNumeroHibrido)
                {
                    exitoNumeroHibrido = int.TryParse(Console.ReadLine(), out nH);
                    if (!exitoNumeroHibrido)
                    {
                        Console.WriteLine("Por favor, ingrese un numero entero.");
                    }
                }
                if (nH == 1 || nH == 2)
                {
                    exitoHibrido = true;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese uno de los numeros solicitados.");
                }
            }
            if (nH == 1)
            {
                esHibrido = false;
            } else 
            {
                esHibrido = true;
            }
            Console.WriteLine("Que tipo de alimento se le da al animal. Ingrese 1 para ´Grano´ y 2 para ´Pastura´");
            bool exitoNumeroAlimento = false;
            bool exitoAlimento2 = false;
            int nA = 0;
            TipoAlimento tipoAlimento;
            while (!exitoAlimento2)
            {
                while (!exitoNumeroAlimento)
                {
                    exitoNumeroAlimento = int.TryParse(Console.ReadLine(), out nA);
                    if (!exitoNumeroAlimento)
                    {
                        Console.WriteLine("Por favor, ingrese un numero entero.");
                    }
                }
                if (nA == 1 || nA == 2)
                {
                    exitoAlimento2 = true;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese uno de los numeros solicitados.");
                }
            }
            if (nA == 1)
            {
                tipoAlimento = TipoAlimento.Grano;
            }
            else
            {
                tipoAlimento = TipoAlimento.Pastura;
            }
            Bovino bovinoUsuario = new Bovino(idNoVerificado, tipoSexo, raza, fechaNacimiento, costoAnimal, costoAlimento, peso, esHibrido, tipoAlimento);
                s.AltaBovino(bovinoUsuario);
                Console.WriteLine("El bovino de datos:");
                Console.WriteLine(bovinoUsuario.ToString() + "\nQuedo registrado.\nPresione una tecla para volver al menu.");

            Console.ReadKey();
        }
    }
}
