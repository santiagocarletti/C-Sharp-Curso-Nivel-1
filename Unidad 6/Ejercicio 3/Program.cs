namespace ejer3;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 3
        //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un 
        //cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

        int num = 0;

        while (num >= 0)
        {
            Console.WriteLine("ingrese número");
            num = int.Parse(Console.ReadLine());

            int con = 0;

            while ((num != 0) && (num > 0))
            {
                con++;

                Console.WriteLine("ingrese número");
                num = int.Parse(Console.ReadLine());

            //ANOTACION: Siguiente llave cierra 2do while    
            }

            Console.WriteLine("Se ingresaron " + con + " número/s en el grupo");

        }

        Console.WriteLine("Fin de la carga");

    }
}
