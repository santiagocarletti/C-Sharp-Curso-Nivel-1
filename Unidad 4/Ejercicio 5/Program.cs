namespace ejer5;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 5
        //Hacer un programa para ingresar 4 números. Luego analizar e informar 
        //por pantalla si los mismos se encuentran ordenados de forma decreciente.

        int a, b, c, d;

        Console.WriteLine("Ingresar 1er NUMERO");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar 2do NUMERO");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar 3er NUMERO");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar 4to NUMERO");
        d = int.Parse(Console.ReadLine());

        if((a > b) && (b > c) && (c > d)){
            Console.WriteLine("LOS NUMEROS FUERON INGRESADOS DE MANERA DECRECIENTE");
        }else{
            Console.WriteLine("LOS NUMEROS FUERON INGRESADOS DE MANERA CRECIENTE");
        }
        

    }
}
