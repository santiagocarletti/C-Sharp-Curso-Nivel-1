namespace ejer2;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 2
        //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de 
        //la cantidad de litros vendidos según la siguiente escala:
        //Si vende menos de 100 litros, no hay descuento.
        //Si vende entre 101 y 300 litros, el descuento es del 10%.
        //Si vende entre 301 y 500 litros, el descuento es del 15%.
        //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
        //Hacer un programa que solicite el ingreso del importe total de la venta y 
        //la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

        float importe, litros;

        Console.WriteLine("Ingresar importe");
        importe = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar cantidad de litros");
        litros = float.Parse(Console.ReadLine());

        if (litros < 101)
            importe = importe;
        else if (litros > 100 && litros < 301)
            importe = importe * 0.9F;
        else if (litros > 300 && litros < 501)
            importe = importe * 0.85F;
        else
            importe = importe * 0.75F;

        Console.WriteLine("El importe final es: " + importe);


    }
}
