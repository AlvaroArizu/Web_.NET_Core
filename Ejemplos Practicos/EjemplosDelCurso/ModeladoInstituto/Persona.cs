using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoInstituto
{

    //Definimos los atributos: fecha de nacimiento, email, nombre, apellido
    internal class Persona
    {
        #region CONSTRUCTORxOMISION
        //Constructor por omision, exite siempre aunque no este en el codigo
        //Es un metodo publico que tiene el mismo nombre que la clase
        public Persona() 
        {
            //Inicializmos los valores de los atributos
            Nombre = "";
            Apellido = "";
            Email = "";
            FechaNacimiento = DateTime.Now;
            DNI = 00000000;
        }
        #endregion

        #region CONSTRUCTORsobrecargado
        //Creo otra version del constructor, a esto se lo llama SOBRECARGA
        //POLIMORFISMO, tengo varias formas de construir el objeto

        public Persona(DateTime fechaNacimiento, string email, string nombre, string apellido, int dni) 
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            DNI = dni;
        }
        #endregion

        #region CONSTRUCTORES
        //Atributos, son datos que va a tener un objeto de la clase
        //Todas las clases tienen constructores, este es un metodo que se ejecuta cuando crear el objeto
        //El contructor siempre existe y si lo escribo inicializa el nuevo objeto, se puede tener varios constructores
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

        public Domicilio Direccion {  get; set; } //ASOCIACION ENTRE OBJETOS
                                                  //Tendremos un objeto del tipo Domicilio "conversando" con un objeto del tipo "Persona"
        
        #endregion

        #region METODOS
        //Metodos-Operaciones
        public void MostrarDatos() //Implementado como un procedimiento
        {
            Console.WriteLine($"Nombre completo: {Nombre} {Apellido}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Fecha de nacimiento: {FechaNacimiento}");
            Console.WriteLine($"DNI: {DNI}");
            Console.WriteLine($"Edad: {CalcularEdad()}");
            Console.WriteLine("");
            //Console.WriteLine($"Edad: {CalcularEdad}");
        }
        #endregion

        #region FUNCIONES
        public int CalcularEdad() //Implementado como una funcion
        {
            int iAnio;
            iAnio = DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1;

            return iAnio;
        }

       
        #endregion

    }
}
