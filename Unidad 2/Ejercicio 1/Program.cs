namespace calculadora;
class Program
{
    static void Main(string[] args)
    {

    //ENUNCIADO EJERCICIO 1:
    //Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.

    //Paso 0: Tipo de dato
    int n1, n2, resultado;


    //Paso 1: Pedir valores
    Console.WriteLine("Ingrese un número: ");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Otro número, por favor: ");
    n2 = int.Parse(Console.ReadLine());

    //Paso 2: Realizar cálculo
    resultado = n1 + n2;

    //Paso 3: Emitir resultado
    Console.WriteLine("La suma de ambos da: " + resultado);

    }
}
