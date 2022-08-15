namespace ejer1;
class Program
{
    static void Main(string[] args)
    {
        //ENUNCIADO EJERCICIO 1
        //Hacer un programa para ingresar un número y luego se emita por pantalla 
        //un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

        int num;

        Console.WriteLine("ingresar número");
        num = int.Parse(Console.ReadLine());

        if (num > 10)
        {
            Console.WriteLine("el número " + num + " es mayor a 10");
        }
        else
        {
            Console.WriteLine("el número " + num + " es menor a 10");
        }
    }
}
