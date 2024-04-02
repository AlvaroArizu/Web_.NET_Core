namespace ModeladoInstituto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creamos una CLASE y luego varios OBJETOS de ese tipo");
            Console.WriteLine("");
            //Cremaos algunos objetos (son variables) del tipo persona
            Persona persona = new Persona(); //Defino la variable y la instancio (es crear)

            persona.Nombre = "Alvaro";
            persona.Apellido = "Arizu";
            persona.FechaNacimiento = Convert.ToDateTime("07/12/2000");
            persona.Email = "alvaro.arizu2000@gmail.com";
            persona.DNI = 43151864;

            //Muestro los datos
            persona.MostrarDatos();
            

            //Creamos otro objeto Persona
            Persona persona2 = new Persona(); //Defino la variable y la instancio (es crear)
                                              //ES UN CONSTRUCTOR Persona();
            persona2.Nombre = "Martina";
            persona2.Apellido = "Vazquez";
            persona2.FechaNacimiento = Convert.ToDateTime("22/08/2000");
            persona2.Email = "martina__vazquez@hotmail.com";
            persona2.DNI = 42662174;

            //Muestro los datos
            persona2.MostrarDatos();

            //CREO OTRO OBJETO PERSONA, pero llamo al contructor SOBRECARGADO
            //Al mismo timepo que creo el objeto, completo los valores de los atributos
            Persona persona3 = new Persona(Convert.ToDateTime("09/02/1968"), "arios@hotmail.com", "Marco", "Rios", 20117188);
            persona3.MostrarDatos();

            //Asociacion entre objetos (Persona2 y Domicilio)
            Domicilio domicilio = new Domicilio();
            domicilio.CalleNroPiso = "Gral acha 22";
            domicilio.Provincia = "Mendoza";
            domicilio.Ciudad = "Lomas";
            domicilio.Pais = "Argentina";
            domicilio.CP = "5555";

            //ASOCIO......, "Direccion esta en Persona.cs", 
            persona2.Direccion = domicilio;
            Console.WriteLine($"Dom, asociado a {persona2.Nombre} {persona2.Apellido}");
            Console.WriteLine(persona2.Direccion.MostrarDomicilio()); //Mostrar el domicilio de la persona asiciada

            Console.WriteLine("");
            //Creo un objeto tipo Estudiante
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = "Carlos";
            estudiante.Apellido = "Bauza";
            estudiante.FechaNacimiento = Convert.ToDateTime("28/11/2000");
            estudiante.Email = "cbauza@gmail.com";
            estudiante.DNI = 42456978;
            estudiante.NotaPromedio = 8;

            estudiante.MostrarDatos();

            Console.ReadKey();
        }
    }
}
