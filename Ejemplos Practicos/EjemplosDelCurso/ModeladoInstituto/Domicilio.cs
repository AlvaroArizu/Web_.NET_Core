using System.Net;

namespace ModeladoInstituto
{
    public class Domicilio
    {
        //Creamos una clase domicilio para asociar a la persona o a sucursal
        public string CalleNroPiso {  get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string CP { get; set; }
        public string Pais { get; set; }


        //Funcion 
        public string MostrarDomicilio()
        {
            string rta;
            rta = $"Domicilio: {CalleNroPiso}, {Ciudad}, {Provincia}, {Pais}, {CP}";
       
            return rta;
        }
    }
}