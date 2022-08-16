namespace _1v2a;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 1
        //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
        //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y 
        //su posición dentro del vector.

        int[] numeros = new int[10];
        int num, max = numeros[0], pos = 1;

        for (int x = 0; x < 10; x++)
        {

            Console.WriteLine("INGRESE NUMERO");
            num = int.Parse(Console.ReadLine());
            numeros[x] = num;

            if (num > max)
            {
                max = num;
                pos = x + 1;
            }
        }

        Console.WriteLine("En la " + pos + "º posición, se cargó el número máximo (" + max + ")");

    }
}
