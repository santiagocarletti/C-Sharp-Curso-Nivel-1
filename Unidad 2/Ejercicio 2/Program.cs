namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 2:
        //Hacer un programa para solicitar por teclado un número y 
        //luego devolver su valor elevado al cubo.

        int numero, resultado;

        Console.WriteLine("Ingrese un número, por favor: ");
        numero = int.Parse(Console.ReadLine());

        resultado = numero * numero * numero;

        Console.WriteLine("El número al cubo resulta en: " + resultado);
    }
}
