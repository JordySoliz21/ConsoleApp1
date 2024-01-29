int Numero;
Console.Title = "VERIFICANDO NUMEROS PARES";
Console.Write("\nIngrese un numero:");
Numero = int.Parse(Console.ReadLine());

if (Numero < 0)
{
    Console.Write("\n\tNumero Negativo...Ingrese un numero positivo");
}

if (Numero == 0)
{
    Console.Write("\n\tLA DIVISIÓN DE CERO NO EXISTE");
}

else if (Numero % 2 == 0)
{
    Console.Write("\n\tEl numero (" + Numero + ") es par.");
    if (Numero >= 10 && Numero <= 100)
    {
        Console.Write("\n\tEl numero (" + Numero + ") se encuentra en el rango [10-100]");
    }
    else
    {
        Console.Write("\n\tEl numero (" + Numero + ") NO esta en el rango [10-00]");
    } 
}
else
{
    Console.Write("\n\tEl numero ingresado es impar...");
}
    Console.ReadKey();

