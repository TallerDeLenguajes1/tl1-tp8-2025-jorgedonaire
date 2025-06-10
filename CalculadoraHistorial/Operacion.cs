namespace espacioOperacion;
public class Operacion
{
    private double resultadoAnterior; //Almacena el resultado previo al calculo actual
    private double nuevoValor;  //El valor con el que se opera sobre el resultadoAnterior
    private TipoOperacion operacion; //El tipo de operacion realizada
    public double Resultado //Logica para calcular o devolver el resultado
    {

    }
    public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
}

public enum TipoOperacion
{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar //Representa la accion de borrar el resultado actual o el historial
}