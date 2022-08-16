namespace _3v2a;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 3
        //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
        //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter
        //dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
        //CADENA FUENTE: “La mar estaba serena"
        //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        //CADENA RESULTADO: “Li mir estibi sereni"

        char[] oracion = new char[21];
        char letra, actual, nueva;

        for (int x = 0; x < 21; x++){
            
            Console.WriteLine("ingrese letra");
            letra = char.Parse(Console.ReadLine());
            oracion[x] = letra;

        }

        Console.WriteLine("Qué letra desea modificar?");
        actual = char.Parse(Console.ReadLine());
        Console.WriteLine("Por cuál desea reemplazarla?");
        nueva = char.Parse(Console.ReadLine());

        for (int x = 0; x < 21; x++){
            
            if(oracion[x] == actual){
                oracion[x] = nueva;
            }

        }

        for (int x = 0; x < 21; x++){

        Console.Write(oracion[x]);

        }

    }
}
