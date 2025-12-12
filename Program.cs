internal class Program
{
    static string[] naves = new string[100];
    int contadornave = 0;


    private static void Main(string[] args)
    {
        int opcion = 0;
        Random random = new Random();

        do
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1.Crear nueva nave");
            Console.WriteLine("2.Cambiar nombre de una nave");
            Console.WriteLine("3.Listar todas las naves");
            Console.WriteLine("4.Eliminar una nave");
            Console.WriteLine("5.Eliminar todas las naves");
            Console.WriteLine("6.Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CrearNave();
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opcion no valido.");
                    break;
            }




        } while (opcion != 6);

    }
    static void CrearNave()
    {
        string[] palabras = new string[]
        {
            "HALCONMILENARIO",
            "CAZAESTELAR",
            "SUPERDESTRUCTOR",
            "YWING",
            "XWING"
        };
        Random random = new Random();
        string nombreNave = palabras[random.Next(palabras.Length)];

        int numeronave = random.Next(10, 99);

        string nombreCompletoNave = $"{nombreNave}-{numeronave}";

        Console.WriteLine($"Nave creada: {nombreCompletoNave}");
        Console.WriteLine();
    }
    static void CambiarNombreNave()
    {
        Console.WriteLine("Dime el nombre actual de la nave");
        string nombreActual = Console.ReadLine();

        foreach (var nave in naves)
        {
            if (nombreActual == nave)
            {
                Console.WriteLine("Dime el nombre nuevo de la nave y su numero");
                string nuevonombre = Console.ReadLine();

                Console.WriteLine($"Nuevo nombre completo es: {nuevonombre}");
            }
        }
    }
}