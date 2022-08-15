namespace ejer3;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 3
        //Hacer un programa que solicite 20 edades y luego calcule 
        //el promedio de edad de aquellas personas mayores a 18 años.

        int edad, mas18 = 0, con = 0;

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("INGRESE EDAD");
            edad = int.Parse(Console.ReadLine());

            if (edad > 18)
            {
                mas18 += edad;
                con++;
            }

        }
        Console.WriteLine("El promedio de edad entre los mayores de 18, es: " + (mas18 / con) + " años");
    }
}
