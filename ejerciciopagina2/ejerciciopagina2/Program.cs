//Desarrollar un programa que muestre la tabla de multiplicar de un numero ingresado por el teclado del 1 al 15 

public class jercicioPagina2
{
    static void Main(string[] args)
    {
        int n;
        string linea;

        Console.Write("ingrese multiplicador:");

        linea = Console.ReadLine();

        n = int.Parse(linea);
        for (int i = 0; i <= n; i++)
        {
            Console.Write(i + " x " + n + " = " + i * n +"\n" );


        }

        Console.ReadKey();
  



    }

}
