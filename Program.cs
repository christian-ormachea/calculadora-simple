using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola, bienvenido a la calculadora de Christian");
        Console.WriteLine("Porfavor ingrese el tipo de operacion que desee realizar: ");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");

        int opcion = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingresa el primer número:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo número:");
        double num2 = double.Parse(Console.ReadLine());


        switch(opcion){
            case 1: 
                Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
            break;
            case 2: 
                Console.WriteLine($"El resultado de la resta es: {num1 - num2}");
            break;
            case 2:
                Console.WriteLine($"El resultado de la multiplicacion es: {num1 * num2}");
                break;
            case 3:
                if(num1 = 0 || num2 = 0){
                    Console.WriteLine("Ingrese numeros distintos a 0")
                    break;
                }
                Console.WriteLine($"El resultado de la division: {num1 / num2}");
                break;
            default:
                Console.WriteLine("Ingrese una operacion valida");
                break;

        }

    }
}


