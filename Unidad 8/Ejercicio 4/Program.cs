namespace ejer4;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 4
        //Hacer una función de tipo void(porque no va a devolver nada) llamada “positivoNegativoCero” 
        //que reciba un número por valor y una variable por referencia. 
        //Que analice el número y escriba variable recibida por referencia con:
        //a. 1 si el número es positivo.
        //b. - 1 si el número es negativo.
        //c. 0 si el número es cero.
    
        int n1, n2 = 0;

        Console.WriteLine("Ingrese número");
        n1 = int.Parse(Console.ReadLine());
        
        positivoNegativoCero(n1, ref n2);
        Console.WriteLine("RESULTADO: ("+ n2 + ") >> REFERENCIAS >> Negativo[-1] / Cero[0] / Positivo[1]");
    
    }

    static void positivoNegativoCero(int a, ref int b){
        if(a == 0){
            b = 0;
        }else if(a < 0){
            b = -1;
        }else{
            b = 1;
        }
    }



}
