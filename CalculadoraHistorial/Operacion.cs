namespace espacioOperacion;
public class Operacion
{
    private double resultadoAnterior; //Almacena el resultado previo al calculo actual
    private double nuevoValor;  //El valor con el que se opera sobre el resultadoAnterior
    private TipoOperacion operaciones; //El tipo de operacion realizada
    public double Resultado() //Logica para calcular o devolver el resultado
    {
        double resultado = 0;
        switch (operaciones)
        {
            case (TipoOperacion)1:
                resultado = ResultadoAnterior + nuevoValor;
                break;
            case (TipoOperacion)2:
                resultado = ResultadoAnterior - nuevoValor;
                break;
            case (TipoOperacion)3:
                resultado = ResultadoAnterior * nuevoValor;
                break;
            case (TipoOperacion)4:
                resultado = ResultadoAnterior / nuevoValor;
                break;
        }
        return resultado;
    }
    public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
    public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
    public TipoOperacion Operaciones { get => operaciones; set => operaciones = value; }

    public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
    {
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operaciones = operacion;
    }
}
public enum TipoOperacion
{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar //Representa la accion de borrar el resultado actual o el historial
}