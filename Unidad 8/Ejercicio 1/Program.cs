﻿namespace ejer1;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 1
        //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto 
        //de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y 
        //muestre por pantalla el monto total a pagar. Usar la función.

        int n1, n2, resultado;

        Console.WriteLine("Ingrese 1º número");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese 2º número");
        n2 = int.Parse(Console.ReadLine());

        resultado = Producto(n1, n2);

        Console.WriteLine("El resultado es " + resultado);
    }

    static int Producto(int a, int b)
    {
        int r;
        r = a * b;
        return r;
    }


}
