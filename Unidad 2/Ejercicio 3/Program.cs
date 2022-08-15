namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        //ENUNCIADO EJERCICIO 3
        //Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y 
        //la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado 
        //que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

        float kms, kmxhs, tiempoaprox;

        Console.WriteLine("Cuántos kms separan una ciudad de la otra? ");
        kms = float.Parse(Console.ReadLine());
        Console.WriteLine("En promedio, a cuántos kms por hora circulará? ");
        kmxhs = float.Parse(Console.ReadLine());

        tiempoaprox = kms / kmxhs;

        //ANOTACION
        //Acortar decimales. Ej. Al imprimir un resultado, en este caso de la variable 'tiempo' y éste
        //da 4.21379, si quiero que después del punto solo se muestren dos decimales, en la línea de
        //WriteLine.. >> ("El tiempo será de: "+ tiempo.ToString("0.00") + " horas");
        //~ acción, parámetro, argumento ..

        Console.WriteLine("Duración aproximada del trayecto (en horas): " + tiempoaprox.ToString("0.00"));

    }
}
