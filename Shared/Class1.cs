namespace Shared
{
    public class Persona
    {
        public string Nombre { get; set; } = "-- Sin Nombre --";
        
        public string Documento
        {
            get { return Documento; }
            set
            {
                if (value.Length < 7)
                    throw new ArgumentException("Formato de documento incorrecto.");
                else
                    Documento = value.ToUpper();
            }   
        }
    }
}