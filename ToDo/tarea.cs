namespace espacioTarea;
public class Tarea
{
    public int TareaID { get; set; }
    public string Descripcion { get; set; }
    public int Duracion { get; set; }

    public Tarea(int tareaID, string descripcion, int duracion) {
        TareaID = tareaID;
        Descripcion = descripcion;
        Duracion = duracion;
    }

    public Tarea() {
        
    }
}
