namespace ProcedimientoYFuncion
{
    internal class Program
    {
        //Procedimiento, cumple su objetivo y no retorna NADA
        public static void Saludo()
        {
            Console.WriteLine("Hola");
        }
        //Funcion, entran 2 valores int a la fx y retorna el resultado
        public static int Suma(int a, int b)
        {
            return a + b;   
        }

        static void ModificarParametroPorValor(int i)
        {
            i = 30;
            Console.WriteLine($"En ModificarParametroPorValor, el valor del parametro i es: {i}");
            return;
        }
        static void ModificarParametroPorReferencia(ref int i)
        {
            i = 40;
            Console.WriteLine($"En ModificarParametroPorReferencia, el valor del parametro i es: {i}");
            return;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Procedimeintos y Funciones!");
            Console.WriteLine(Environment.NewLine); //Genera una linea en blanco

            //Llamo al procecimeito Saludo
            Program.Saludo();
            Saludo();
            Console.WriteLine(Environment.NewLine);

            //Llamo a la funcion Suma
            //FORMA CORTA
            Console.WriteLine($"El resultado de sumar 3 y 6 es: {Suma(3, 6)}");
            Console.WriteLine(Environment.NewLine);
            //FORMA LARGA
            int rta;
            rta = Suma(2,3);
            Console.WriteLine($"El resultado de sumar 2 y 3 {rta}" );
            Console.WriteLine(Environment.NewLine);

            //TIPOS DE PARAMETROS
            //Por valor
            Console.WriteLine("Probamos pasaje de paremtros por VALOR");
            int valor = 20;
            Console.WriteLine("En el MAIN, valor tiene un = {0}", valor);
            ModificarParametroPorValor(valor);
            Console.WriteLine("En el MAIN, valor vuelve a tener  un = {0}", valor);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Probamos pasaje de paremtros por REFERECNIA ");
            int valor1 = 30;
            Console.WriteLine("En el MAIN, valor1 tiene un = {0}", valor1);
            ModificarParametroPorReferencia( ref valor1);
            Console.WriteLine("En el MAIN, valor1 QUEDA MODIFICADO  un = {0}", valor1);
            Console.WriteLine(Environment.NewLine);

            Console.ReadKey();
        }
    }
}
