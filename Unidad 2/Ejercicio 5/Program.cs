namespace ejercicio5;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 5
        //Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y 
        //luego calcule y emita por pantalla el promedio final.

        float A, B, C, promedio;

        //float suma; ANOTACION: (EN ESTE CASO NO USO LA VARIABLE POR QUE HICE LA OPERACION DIRECTAMENTE)

        Console.WriteLine("Ingrese primera calificación: ");
        A = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese segunda calificación: ");
        B = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese tercera y última calificación: ");
        C = float.Parse(Console.ReadLine());

        //ANOTACION:
        //PUEDO HACERLO POR PARTES, ASI:
        //suma = A + B + C;
        //promedio = suma / 3;
        //
        //O DIRECTAMENTE, TODO JUNTO, ASI:
        promedio = (A + B + C) / 3;

        Console.WriteLine("El promedio final es: " + promedio);

    }
}
