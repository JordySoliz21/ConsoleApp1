
Console.Title = " El mayor de dos numeros";
    Int32 x, y;

Console.WriteLine("Digitar el primer número del 1 al 1000");
    x = Int32.Parse(Console.ReadLine());

 Console.WriteLine("Digitar el segundo número del 1 al 1000");
    y = Int32.Parse(Console.ReadLine());

    if (x > y)
    {
        Console.WriteLine("\nEl numero {0} es mayor que {1}", x, y); // v
    }
    if (x == y)
    {
    Console.WriteLine("\nEl numero {0} es igual a {1}", x, y);
    }
    else
    {
        Console.WriteLine("\nEl numero {0} es mayor que {1}", y, x); // f
    }

    Console.WriteLine("\n\n");
    Console.WriteLine("\n----->Fin del programa");
    Console.ReadKey();

