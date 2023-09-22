//Pedir por consola un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos) y mostrar por pantalla, el siguiente mensaje «Hola » <nombre> » bienvenido a » <ciudad>

public class Ejercicio1
{
    static void Main(string[] args)
    {

        Console.Write("ingrese el nombre de la persona:");

        string nombre = Console.ReadLine();

        Console.Write("ingrese la ciudad:");

        string ciudad = Console.ReadLine();

        Console.WriteLine("Hola"    + nombre +     "Bienvenido a "  + ciudad);

        Console.ReadLine();
        
    }
    

}
