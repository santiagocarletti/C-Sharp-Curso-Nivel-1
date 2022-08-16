namespace ejer1;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 1
        //Hacer un programa para ingresar 10 números. El mismo debe analizar 
        //y mostrar por pantalla cuántos de esos números son primos.

        int primos = 0, num;

        for(int x = 0; x < 10; x++){
            Console.WriteLine("INGRESE " + (x + 1) + "º NUMERO");
            num = int.Parse(Console.ReadLine());

                int restocero = 0;

                for(int y = 1; y <= num; y++){
                if(num % y == 0){
                        restocero++;
                }

                //ANOTACION: SIGUIENTE } CIERRA FOR [y]
                }
                if(restocero == 2){
                    primos++;      
                }
        //ANOTACION: SIGUIENTE } CIERRA FOR [x]  
        }
        Console.WriteLine("TOTAL DE Nros. PRIMOS: " + primos);

    }
}
