// See https://aka.ms/new-console-template for more information
using System.Globalization;
using UltimoEjercicio;

class Program
{
    static void Main(string[] args)
    {


        string nombre = "";
        string apellido = "";
        string documento = "";
        string fnacimiento = "";
        string exit = "N";
        List<Persona> lista = new List<Persona>();

        while (exit == "N")
        {



            Console.WriteLine("- Ingrese una persona:");
            Console.WriteLine();

            Console.WriteLine("Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("Documento:");
            documento = Console.ReadLine();
            Console.WriteLine("Fecha Nacimiento (dd-mm-aaaa):");
            fnacimiento = Console.ReadLine();
            Console.WriteLine();


            DateTime nacimiento = DateTime.ParseExact(fnacimiento, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Persona p = new Persona(nombre,apellido, documento, nacimiento);
            lista.Add(p);


            Console.WriteLine("Exit (Y/N):");
            exit = Console.ReadLine();
            Console.WriteLine();

        }

        Console.WriteLine(" Personas ordenadas por edad:");
        Console.WriteLine();

        List<Persona> listaOrdenada = lista.OrderBy(x => x.FechaNacimiento).ToList();
        List<String> listaParseada = new List<string>();
        foreach (var e in listaOrdenada)
        {

            listaParseada.Add(e.Nombre);
            
        }
        
        Console.WriteLine(String.Join(Environment.NewLine, listaParseada));

        Console.ReadLine();
    }
}