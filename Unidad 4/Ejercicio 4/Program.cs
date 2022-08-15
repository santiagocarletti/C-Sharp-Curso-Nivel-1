namespace ejer4;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 4
        //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la 
        //suma de los dos primeros es mayor al producto del segundo con el tercero.

        int a, b, c;

        Console.WriteLine("INGRESE 1er NUMERO");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE 2do NUMERO");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE 3er NUMERO");
        c = int.Parse(Console.ReadLine());

        if((a + b) > (b * c)){
            Console.WriteLine("El 1er + el 2do número es [MAYOR] al 2do x el 3ero");
        }else{
            Console.WriteLine("El 1er + el 2do número es [IGUAL o MENOR] al 2do x el 3ero");
        }

    }
}
