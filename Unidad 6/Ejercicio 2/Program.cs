namespace unidad6;
class Program
{
    static void Main(string[] args)
    {

        //ENUNCIADO EJERCICIO 2
        //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
        //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

        int mxporip = 0, grporip = 0, num, grdecr = 0;

        for(int x = 0; x < 5; x++){
            Console.WriteLine("ingresar número " + (x + 1) + "º grupo");
            num = int.Parse(Console.ReadLine());

            int conip = 0, connr = 0, porip = 0;
            int conpb = 0, bpuntob = 0;

                while(num != 0){
                    connr++;
                    if(num % 2 != 0){
                        conip++;
                        }

                    if(connr == 1){
                        bpuntob = num;
                        conpb++;
                    }else if(num < bpuntob){
                            bpuntob = num;
                            conpb++;
                    }

                        Console.WriteLine("ingresar número " + (x + 1) + "º grupo");
                        num = int.Parse(Console.ReadLine());
                    

                //ANOTACION: Siguiente llave cierra while
                }

                porip = conip * 100 / connr;
                if(x == 0){
                    grporip = (x + 1);
                    mxporip = porip;
                }else if(porip > mxporip){
                    grporip = (x + 1);
                    mxporip = porip;
                }

                if(connr == conpb){
                    grdecr++;
                }

        //ANOTACION: Siguiente llave cierra for [x]
        }
    
        Console.WriteLine("El " + grporip + "º grupo, (con un " + mxporip + "%), tiene mayor porcentaje de números impares");

        if(grdecr == 0)
            Console.WriteLine("Ningún grupo fue cargado de manera decreciente");
        
        if(grdecr == 1)
            Console.WriteLine("Solo un grupo se cargó de manera decreciente");
        
        if(grdecr > 1)
            Console.WriteLine(+ grdecr + " grupos fueron cargados de manera decreciente" );

    }
}
