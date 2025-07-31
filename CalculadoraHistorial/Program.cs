using System.ComponentModel;
using espacioOperacion;

List<Operacion> operaciones = new List<Operacion>();
Console.WriteLine("**** CALCULADORA ****");
int bandera = 1;
while (bandera == 1)
{
    Console.WriteLine("Elija la opcion que desee: ");
    Console.WriteLine("1. Mostrar el historial ");
    Console.WriteLine("2. Realizar operacion ");
    string opcionIngresada = Console.ReadLine();
    int i = 0;
    bool opcionValida = int.TryParse(opcionIngresada, out int opcionConvertida);

    if (opcionValida)
    {
        switch (opcionConvertida)
        {
            case 1:
                Console.WriteLine("Historial de operaciones");
                foreach (Operacion item in operaciones)
                {
                    Console.WriteLine($"La {item.Operaciones} de {item.ResultadoAnterior} y {item.NuevoValor} es {item.Resultado()}");
                }
                break;
            case 2:
                Console.WriteLine("Elija la operacion que desee realizar: ");
                Console.WriteLine("1 . Suma");
                Console.WriteLine("2 . Resta");
                Console.WriteLine("3 . Multiplicacion");
                Console.WriteLine("4 . Division");
                string operacionIngresada = Console.ReadLine();
                if (double.TryParse(operacionIngresada, out double operacionConvertida))
                {
                    Console.WriteLine("Ingrese el 1er numero: ");
                    string num1Ingresado = Console.ReadLine();
                    if (double.TryParse(num1Ingresado, out double num1Convertido))
                    {
                        Console.WriteLine("Ingrese el 2do numero: ");
                        string num2Ingresado = Console.ReadLine();
                        if (double.TryParse(num2Ingresado, out double num2Convertido))
                        {
                            if (operaciones.Count() == 0) //Primera operacion
                            {
                                Operacion nuevaOperacion = new Operacion(num1Convertido, num2Convertido, (TipoOperacion)operacionConvertida);
                                Console.WriteLine("El resultado es = " + nuevaOperacion.Resultado());
                                operaciones.Add(nuevaOperacion);
                            }
                            else
                            {
                                double resultadoAnterior = operaciones[i].Resultado();
                                Operacion nuevaOperacion = new Operacion(resultadoAnterior, num2Convertido, (TipoOperacion)operacionConvertida);
                                Console.WriteLine("El resultado es = " + nuevaOperacion.Resultado());
                                operaciones.Add(nuevaOperacion);
                                i++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error, debe ingresar un numero");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error, debe ingresar un numero");
                    }


                }
                else
                {
                    Console.WriteLine("Error al ingresar. Debe elegir un numero.");
                }
                break;

        }
    }
    Console.WriteLine("Desea realizar otra operacion?:");
    Console.WriteLine("1. Si");
    Console.WriteLine("2. No");
    string banderaIngresada = Console.ReadLine();
    int.TryParse(banderaIngresada, out bandera);
}
