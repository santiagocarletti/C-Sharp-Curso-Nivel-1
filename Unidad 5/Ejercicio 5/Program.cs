namespace ejer5x2;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 5
        //Hacer un programa que solicite 20 números y luego emitir por pantalla 
        //el máximo de los números pares y el mínimo de los números impares.

        int num, maxpar = 0, minimp = 0, conpar = 0, conimp = 0;


        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese Nro.");
            num = int.Parse(Console.ReadLine());

            if ((num % 2 == 0))
            {
                conpar++;
                if (conpar == 1)
                    maxpar = num;
                else if (num > maxpar)
                    maxpar = num;
            }
            else
            {
                conimp++;
                if (conimp == 1)
                    minimp = num;
                else if (num < minimp)
                    minimp = num;
            }

        //ANOTACION: CIERRE DE FOR    
        }

        Console.WriteLine("Mayor número par: " + maxpar);
        Console.WriteLine("Menor número impar: " + minimp);
    }
}
