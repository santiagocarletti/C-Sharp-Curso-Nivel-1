namespace ejer1;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 1
        //Hacer un programa que solicite el ingreso de dos números y luego calcular:
        //La resta si el primero es mayor que el segundo.
        //La suma si son iguales.
        //El producto si el primero es menor.
        //Se deberá emitir un cartel por pantalla con el resultado correspondiente.

        int A, B, R = 0;

        Console.WriteLine("Ingrese 1er número");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese 2do número");
        B = int.Parse(Console.ReadLine());

        if (A == B)
            R = (A + B);

        else if (A > B)
            R = (A - B);

        else
            R = (A * B);

        Console.WriteLine("El resultado es " + R);

    }
}
