namespace ejer2;
class Program
{
    static void Main(string[] args)
    {
        //ENUNCIADO EJERCICIO 2
        //Hacer un programa que solicite el ingreso 
        //de 10 números y que muestre el mayor de ellos por pantalla. 
        //Solo se debe emitir UN valor por pantalla.

        int num, max = 0;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese número");
            num = int.Parse(Console.ReadLine());

            if (x == 0)
            {
                max = num;
            }
            if (num > max)
            {
                max = num;
            }

        }

        Console.WriteLine("El número máximo es " + max);

    }
}
