namespace ejer1;
class Program
{
    static void Main(string[] args)
    {

    //1. Hacer un programa para ingresar un número y luego se emita por pantalla 
    //un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

int num;

Console.WriteLine("Dame número");
num = int.Parse(Console.ReadLine());

if(num == 10){
    Console.WriteLine("Cualquier número menos [" + num + "] please");}
else if(num > 10){
    Console.WriteLine("El número [" + num + "] es mayor a 10");}
    else{
    Console.WriteLine("El número [" + num + "] es menor a 10");}
    }
}
