namespace ejer4;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 4
        //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

        int a, b, c, d, menor = 0;

        Console.WriteLine("INGRESE 1er NUMERO");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE 2do NUMERO");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE 3er NUMERO");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE 4to NUMERO");
        d = int.Parse(Console.ReadLine());

        if (a < b)
        {
            menor = a;
        }
        else
        {
            menor = b;
        }

        if (c < menor)
        {
            menor = c;
        }

        if (d < menor)
        {
            menor = d;
        }

        Console.WriteLine("El menor es " + menor);

    }
}
