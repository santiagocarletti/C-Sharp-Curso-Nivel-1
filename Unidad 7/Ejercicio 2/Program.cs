namespace _2v2a;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 2
        //Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese 
        //vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

        int[] numeros = new int[10];
        int num, total = 0, prom = 0;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("INGRESE NUMERO");
            num = int.Parse(Console.ReadLine());
            numeros[x] = num;

            total += num;
        }

        prom = (total / 10);

        Console.WriteLine("El promedio es " + prom + " y los números mayores a él, son:");
        for (int x = 0; x < 10; x++)
        {

            if (numeros[x] > prom)
            {
                Console.WriteLine(+numeros[x]);
            }

        }

    }
}
