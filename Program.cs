internal class Program
{
    static string[] naves = new string[10];
    static int contadornave = 0;

    static string[] palabras =
    {
        "HALCONMILENARIO",
        "CAZAESTELAR",
        "SUPERDESTRUCTOR",
        "YWING",
        "XWING"
    };


    private static void Main(string[] args)
    {

        int opcion = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine("=== SISTEMA DE FABRICACIÓN DE NAVES ESTELARES ===");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1.Crear nueva nave");
            Console.WriteLine("2.Cambiar nombre de una nave");
            Console.WriteLine("3.Listar todas las naves");
            Console.WriteLine("4.Eliminar una nave");
            Console.WriteLine("5.Eliminar todas las naves");
            Console.WriteLine("6.Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    CrearNave(ref contadornave);
                    break;
                case 2:
                    CambiarNombreNave();
                    break;
                case 3:
                    MostrarNaves(ref contadornave);
                    break;
                case 4:
                    EliminarNave(ref contadornave);
                    break;
                case 5:
                    EliminarTodo(ref contadornave);

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
    static void CrearNave(ref int contadornave)
    {
        if (contadornave <= naves.Length)
        {
            Random random = new Random();
            string nombreNave = palabras[random.Next(palabras.Length)];
            int numeronave = random.Next(10, 99);

            string nombreCompletoNave = $"{nombreNave}-{numeronave}";

            Console.WriteLine($"✓ Nave creada: {nombreCompletoNave}");
            naves[contadornave] = nombreCompletoNave;
            Console.WriteLine();
            contadornave++;
        }
        else
        {
            Console.WriteLine("No se puede generar mas naves");
        }
    }

    static void CambiarNombreNave()
    {
        if (contadornave <= 0)
        {
            Console.WriteLine("No hay naves para renombrar");
        }
        else
        {
            Console.WriteLine("Dime la posicion de la nave (emieza por 0)");
            int posicionActual = Convert.ToInt32(Console.ReadLine());

            string nombreActual = naves[posicionActual];

            if (posicionActual < 0 || posicionActual >= contadornave)
            {
                Console.WriteLine("Posicion invalida");
            }
            else
            {


                Random random = new Random();
                string nombreNave = palabras[random.Next(palabras.Length)];
                int numeronave = random.Next(10, 99);


                string nuevonombrecompleto = $"{nombreNave}-{numeronave}";

                naves[posicionActual] = nuevonombrecompleto;

                Console.WriteLine($"✓ Nave renombrada: {nombreActual} → {nuevonombrecompleto}");

            }
        }





    }

    static void MostrarNaves(ref int contadornave , string titulo = "=== NAVES FABRICADAS ===")
    {
        if (contadornave <= 0)
        {
            Console.WriteLine("\n✗ No hay naves fabricadas.");
        }
        else
        {
            Console.WriteLine(titulo);
            for (int i = 0; i < naves.Length; i++)
            {
                if (naves[i] != null)
                {
                    Console.WriteLine($"[{i}] {naves[i]}");
                }
            }
            Console.WriteLine();
        }
        
    }

    static void EliminarNave(ref int contadornave)
    {
        if (contadornave <= 0)
        {
            Console.WriteLine("No hay naves para eliminar");
        }
        else
        {
            Console.WriteLine("Dime la posicion de la nave que quieres eliminar");
            int posicion = Convert.ToInt32(Console.ReadLine());

            naves[posicion] = "";

            contadornave--;

            Console.WriteLine("=== NAVES ACTULIZADOS ===");
            for (int i = 0; i < naves.Length; i++)
            {
                if (naves[i] != null)
                {
                    Console.WriteLine($"[{i}] {naves[i]}");
                }
            }
            Console.WriteLine();
        }

    }

    static void EliminarTodo(ref int contadornave , bool mostrarConfirmacion = true)
    {
        if (contadornave == 0)
        {
            Console.WriteLine("✗ No hay naves para eliminar.");
        }
        if (mostrarConfirmacion)
        {
            Console.Write($"\n¿Está seguro de eliminar todas las {contadornave} naves? (S/N): ");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" || respuesta == "s")
            {
                Console.WriteLine("=== ELIMINANDO TODAS LAS NAVES ===");
                for (int i = 0; i < naves.Length; i++)
                {
                    naves[i] = null;
                }
                Console.WriteLine("✓ Todos naves eliminados");
                contadornave = 0;
            }
            else
            {
                Console.WriteLine("Operación cancelada.");
            }
        }
        
        
    }
}






