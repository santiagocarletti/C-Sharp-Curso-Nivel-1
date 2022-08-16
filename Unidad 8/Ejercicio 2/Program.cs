namespace ejer2;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 2
        //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
        //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

        int num, pares = 0;
        bool resultado;

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese el " + (x + 1) + "º número");
            num = int.Parse(Console.ReadLine());

            resultado = parImpar(num);

            if (resultado == true)
            {
                pares++;
            }
        }

        Console.WriteLine("Se ingresaron " + pares + " números pares");

    }

    static bool parImpar(int a)
    {
        bool r;
        if (a % 2 == 0)
        {
            r = true;
        }
        else
        {
            r = false;
        }
        return r;
    }

}
