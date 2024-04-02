namespace PrimerEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string Nombre;

            Console.WriteLine("Bienvenidos al curso!");

            Console.WriteLine("Como te llamas?");
            Nombre= Console.ReadLine();

            Console.WriteLine($"Hola! {Nombre}");
            Console.WriteLine("Hola!" + Nombre);
            Console.WriteLine("Hola {0}", Nombre);
            */

            //**SINTAXIS * *

            // [AMBITO][TIPO DE DATO][NOMBRE] = [ASIGNACION] * *

            //Ejemplos tipiado explicito
            int nro = 10;
            String texto;
            Boolean bandera;

            //Ejemplos tipiado impicito
            var i = 5;
            var a = new[] { 1, 2, 3, };

            //Reccorre el array
            foreach(var x in a) {
                Console.WriteLine($"Elememto del array {x}");
            }

            //Objeto de tipo anonimo 
            //Al crear la variabele no le indico el tipo de dato
            var anon = new { Name = "Juan", Age = 34 };
            Console.WriteLine($"El valor de los atributos NOMBRE y EDAD, son: {anon.Name} y {anon.Age}");

            //Colecciones genericas 
            var NombrePersona = new List<string>();
            NombrePersona.Add("Alvaro");
            NombrePersona.Add("Martina");
            NombrePersona.Add("Oliver");

            foreach (var item in NombrePersona)
            {
                Console.WriteLine($"Nombre {item}");

            }
            Console.WriteLine($"La lista tiene {NombrePersona.Count} elementos");

            Console.ReadKey();
        }
    }
}
