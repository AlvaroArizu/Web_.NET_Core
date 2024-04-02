using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoInstituto
{
    internal class Estudiante : Persona //ASI IDICO HERENCIA ":Persona", por lo tanto Estudiante extiende la funcionalidad de la clase Persona
    {
        //Aplico herencia simple, e idico que Estudiante es una Persona
        public int NotaPromedio { get; set; }
    }
}
