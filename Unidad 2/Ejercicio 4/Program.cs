namespace ejercicio4;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 4
        //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 
        //más una comisión del 5% sobre el total facturado por cada empleado. 
        //Hacer un programa para ingresar el total facturado por un empleado 
        //y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

        float facturacion, comision, sueldoTotal;
        //ANOTACION: MUY IMPORTANTE EL FLOAT EN LUGAR DE INT

        Console.WriteLine("Ingrese el total facturado por el empleado: ");
        facturacion = float.Parse(Console.ReadLine());

        const float sueldoBasico = 15000;
        const float porcentajeComision = 0.05F;

        comision = facturacion * porcentajeComision;
        sueldoTotal = sueldoBasico + comision;

        Console.WriteLine("Sueldo total del empleado: " + sueldoTotal);

    }
}
