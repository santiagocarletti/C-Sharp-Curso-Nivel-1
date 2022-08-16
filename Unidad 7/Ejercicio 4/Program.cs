namespace _4v2a;
class Program
{
    static void Main(string[] args)
    {
        //ENUNCIADO EJERCICIO 4
        //Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        //- Número de Artículo (1 a 15)
        //- Cantidad Vendida 
        //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        //Se pide determinar e informar:
        //a) El número de artículo que más se vendió en total.
        //b) Los números de artículos que no registraron ventas.
        //c) Cuantas unidades se vendieron del número de artículo 10.

        int[] arts = new int[15];
        int[] cans = new int[15];
        int art, can;

        Console.WriteLine("ingrese artículo");
        art = int.Parse(Console.ReadLine());

        while (art != 0)
        {

            Console.WriteLine("ingrese cantidad");
            can = int.Parse(Console.ReadLine());

            for (int x = 0; x < 15; x++)
            {

                if (art == (x + 1))
                {
                    cans[x] += can;
                }
            }

            Console.WriteLine("ingrese artículo");
            art = int.Parse(Console.ReadLine());

        }

        int banA = cans[0], posA = 1;

        for (int x = 0; x < 15; x++)
        {

            if (cans[x] > banA)
            {
                banA = cans[x];
                posA = (x + 1);
            }

            if (cans[x] == 0)
            {
                Console.WriteLine("El artículo " + (x + 1) + " no registra ventas");
            }

        }

        Console.WriteLine("El artículo " + posA + ", con un total de " + banA + " unidades, fue el mas vendido");
        Console.WriteLine("El artículo Nº 10 registra " + cans[9] + " ventas");

    }
}
