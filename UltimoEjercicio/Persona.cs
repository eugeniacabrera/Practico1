using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoEjercicio
{
    public class Persona
    {

        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona() { }
        public Persona(string nombre, string apellido, string documento, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
