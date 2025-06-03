using espacioTarea;

List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();

//Carga de 5 tareas aleatorias
Random rnd = new Random();
int numeroAleatorio = rnd.Next(10, 100);

for (int i = 0; i < 5; i++)
{
    TareasPendientes.Add(new Tarea(i, $"Tarea nro {i}", numeroAleatorio));
}

//mostrar lista de pendientes
Console.WriteLine("***** Lista de TAREAS PENDIENTES *****");
foreach (Tarea tareaActual in TareasPendientes)
{
    Console.WriteLine($"Tarea ID: {tareaActual.TareaID}");
    Console.WriteLine($"Descripcion: {tareaActual.Descripcion}");
    Console.WriteLine($"Duracion: {tareaActual.Duracion}");
    Console.WriteLine("-----");

}
Console.WriteLine("*** Fin de lista de tareas pendientes ***");

//mover tareas de pendientes a realizadas
Console.WriteLine("Ingrese el ID de la tarea que desea marcar como realizada");
string idIngresado;
idIngresado = Console.ReadLine();
int iteracion=0;
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
}else
{
    Console.WriteLine("Error, ingrese un ID valido");
}

//mostrar lista de pendientes
Console.WriteLine("***** Lista de TAREAS PENDIENTES *****");
foreach (Tarea tareaActual in TareasPendientes)
{
    Console.WriteLine($"Tarea ID: {tareaActual.TareaID}");
    Console.WriteLine($"Descripcion: {tareaActual.Descripcion}");
    Console.WriteLine($"Duracion: {tareaActual.Duracion}");
    Console.WriteLine("-----");

}
Console.WriteLine(" Fin de lista de tareas pendientes ");

//mostrar lista de realizadas
Console.WriteLine("***** Lista de TAREAS REALIZADAS *****");
foreach (Tarea tareaActual in TareasRealizadas)
{
    Console.WriteLine($"Tarea ID: {tareaActual.TareaID}");
    Console.WriteLine($"Descripcion: {tareaActual.Descripcion}");
    Console.WriteLine($"Duracion: {tareaActual.Duracion}");
    Console.WriteLine("-----");

}
Console.WriteLine(" Fin de lista de tareas realizadas ");

//busqueda de tareas por descripcion
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