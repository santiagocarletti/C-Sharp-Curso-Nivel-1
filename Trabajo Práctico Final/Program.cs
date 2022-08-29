namespace TPFinal_Carletti;
class Program
{
    static void Main(string[] args)
    {
        //TEMATICA EJERCICIO: TRABAJO PRACTICO FINAL
        //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
        //A partir de dichos datos informar:
        //a. El mayor de los números pares.
        //b. La cantidad de números impares.
        //c. El menor de los números primos.
        //Nota: evaluar el uso de una función que analice si un número dado
        //es primo o no y que devuelva true o false según corresponda.

        int num = 0, minPri = 0, conImp = 0, maxPar = 0;
        bool banPar = false, funPrimos = false, banPri = false;

        Console.WriteLine("Ingrese un número");
        num = int.Parse(Console.ReadLine());

        while (num != 0)
        {

            if ((num % 2) == 0)
            {
                if (!banPar)
                {
                    banPar = true;
                    maxPar = num;
                }
                else
                {
                    if (num > maxPar)
                    {
                        maxPar = num;
                    }
                }
            }
            else
            {
                conImp++;
            }

            funPrimos = primos(num);
            if (funPrimos)
            {
                if (!banPri)
                {
                    banPri = true;
                    minPri = num;
                }
                else if (num < minPri)
                {
                    minPri = num;
                }
            }

            Console.WriteLine("Ingrese otro número");
            num = int.Parse(Console.ReadLine());

        }

        if (!banPar)
        {
            Console.WriteLine("No se ingresaron números pares");
        }
        else
        {
            Console.WriteLine("El máximo número par es: " + maxPar);
        }
        if (conImp == 0)
        {
            Console.WriteLine("No se ingresaron números impares");
        }
        else
        {
            Console.WriteLine("Se ingresó un total de " + conImp + " número/s impar/es");
        }
        if (!banPri)
        {
            Console.WriteLine("No se ingresaron números primos");
        }
        else
        {
            Console.WriteLine("El menor número primo es: " + minPri);
        }

    }

    static bool primos(int Nro)
    {
        int resCero = 0;
        bool rtn = false;
        for (int x = 1; x <= Nro; x++)
        {
            if ((Nro % x) == 0)
            {
                resCero++;
            }
        }
        if (resCero == 2)
        {
            rtn = true;
        }
        return rtn;

    }
}
