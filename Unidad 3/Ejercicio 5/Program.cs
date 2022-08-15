namespace ejer5;
class Program
{
    static void Main(string[] args)
    {

        //5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

        int a, b, c, d;

        Console.WriteLine("INGRESE NUMERO");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE NUMERO");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE NUMERO");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE NUMERO");
        d = int.Parse(Console.ReadLine());

        if(a > 100){
            Console.WriteLine("EL NUMERO " + a + " ES MAYOR A 100");
        }
        if(b > 100){
            Console.WriteLine("EL NUMERO " + b + " ES MAYOR A 100");
        }
        if(c > 100){
            Console.WriteLine("EL NUMERO " + c + " ES MAYOR A 100");
        }
        if(d > 100){
            Console.WriteLine("EL NUMERO " + d + " ES MAYOR A 100");
        }

    }
}
