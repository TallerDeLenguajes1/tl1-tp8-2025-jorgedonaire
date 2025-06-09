using espacioTarea;

string cantidadIngresada, opcionIngresada;
int opcionConvertida;
List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();

Console.WriteLine("*** PROGRAMA DE TAREAS ***");
Console.WriteLine(" ");
Console.WriteLine("Ingrese la cantidad de tareas que desee cargar aleatoriamente: ");
cantidadIngresada = Console.ReadLine();
if (int.TryParse(cantidadIngresada, out int cantidadConvertida))
{
    Random rnd = new Random();
    for (int i = 0; i < cantidadConvertida; i++)
    {
        int numeroAleatorio = rnd.Next(10, 100);
        TareasPendientes.Add(new Tarea(i, $"Descripcion de tarea nro {i}", numeroAleatorio));
    }
}
else
{
    Console.WriteLine("Error, debe ingresar un numero");
}

//INTERFAZ
do
{
    Console.WriteLine(" ");
    Console.WriteLine("*** MENU ***");
    Console.WriteLine("Seleccione una opcion: ");
    Console.WriteLine("Presione 1 para marcar una tarea pendiente como realizada");
    Console.WriteLine("Presione 2 para buscar una tarea pendiente por su descripcion");
    Console.WriteLine("Presione 3 para ver las tareas pendientes y realizadas");
    Console.WriteLine("Presione 4 para salir");
    Console.WriteLine(" ");
    opcionIngresada = Console.ReadLine();
    if (int.TryParse(opcionIngresada, out opcionConvertida))
    {
        switch (opcionConvertida)
        {
            case 1:
                Console.WriteLine("Ingrese el ID de la tarea que desea marcar como realizada");
                string idIngresado;
                idIngresado = Console.ReadLine();
                int iteracion = 0;
                if (int.TryParse(idIngresado, out int idConvertido))
                {
                    foreach (Tarea tareaActual in TareasPendientes)
                    {
                        if (idConvertido == tareaActual.TareaID)
                        {
                            TareasRealizadas.Add(tareaActual);
                            TareasPendientes.RemoveAt(iteracion);
                            break;
                        }
                        iteracion++;
                    }
                }
                else
                {
                    Console.WriteLine("Error, ingrese un ID valido");
                }
                break;
            case 2:
                string descripcionIngresada;
                Console.WriteLine("Ingrese la descripcion de la tarea buscada: ");
                descripcionIngresada = Console.ReadLine();

                foreach (Tarea tareaActual in TareasPendientes)
                {
                    if (tareaActual.Descripcion == descripcionIngresada)
                    {
                        Console.WriteLine("--- Tarea encontrada ---");
                        Console.WriteLine($"Tarea ID: {tareaActual.TareaID}");
                        Console.WriteLine($"Descripcion: {tareaActual.Descripcion}");
                        Console.WriteLine($"Duracion: {tareaActual.Duracion}");
                        Console.WriteLine("---");
                    }
                }
                break;
            case 3:
                Console.WriteLine("***** Lista de TAREAS PENDIENTES *****");
                foreach (Tarea tareaActual in TareasPendientes)
                {
                    Console.WriteLine($"Tarea ID: {tareaActual.TareaID}");
                    Console.WriteLine($"Descripcion: {tareaActual.Descripcion}");
                    Console.WriteLine($"Duracion: {tareaActual.Duracion}");
                    Console.WriteLine("-----");

                }
                Console.WriteLine(" Fin de lista de tareas pendientes ");

                Console.WriteLine("***** Lista de TAREAS REALIZADAS *****");
                foreach (Tarea tareaActual in TareasRealizadas)
                {
                    Console.WriteLine($"Tarea ID: {tareaActual.TareaID}");
                    Console.WriteLine($"Descripcion: {tareaActual.Descripcion}");
                    Console.WriteLine($"Duracion: {tareaActual.Duracion}");
                    Console.WriteLine("-----");

                }
                Console.WriteLine(" Fin de lista de tareas realizadas ");
                break;  
            case 4:
                Console.WriteLine("*** FIN DEL PROGRAMA ***");
                break;
            default:
                Console.WriteLine("Ingrese una opcion valida");
                break;
        }
    }else
    {
        Console.WriteLine("Error, debe ingresar un numero");   
    }
} while (opcionConvertida != 4);
