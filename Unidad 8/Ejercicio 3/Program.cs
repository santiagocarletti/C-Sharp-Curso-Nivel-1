namespace ejer3;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 3
        //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
        //Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
        //Informar el promedio teniendo en cuenta sólo los números primos.

        bool resultado;
        int num, conpri = 0, acu = 0;
        Console.WriteLine("Ingrese un número");
        num = int.Parse(Console.ReadLine());
        
        while(num != 0){
        resultado = primos(num);

        //ANOTACION: PROMEDIO
        if(resultado == true){
            acu += num;
            conpri++;
        }

        Console.WriteLine("Ingrese un número");
        num = int.Parse(Console.ReadLine());

        //ANOTACION: CIERRE DE WHILE
        }
        Console.WriteLine("Fin de los ingresos");
        Console.WriteLine("El promedio de números primos es " + (acu / conpri));

    }

    static bool primos(int n){
        int rc = 0;
        bool r;
        for (int x = 1; x <= n; x++){
            if((n % x) == 0){
                rc++;
            }
        }
        if(rc == 2){
            r = true;
        }else{
            r = false;
        }
        return r;
    }


}
