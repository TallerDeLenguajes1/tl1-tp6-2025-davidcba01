// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("valor de a: " + a);
Console.WriteLine("valor de b: " + b);

int numero=0;
Console.WriteLine("Ingrese un numero que quiera invertir (entero positivo):");
string entrada = Console.ReadLine();
bool esNumero = int.TryParse(entrada, out numero);

if (esNumero)
{
    Console.WriteLine($"El número ingresado es: {numero}");

    if (numero > 0)
    {
        int numeroInvertido = 0;

        while (numero > 0)
        {
            int digito = numero % 10;
            numeroInvertido = (numeroInvertido * 10) + digito;
            numero /= 10;
        }

        Console.WriteLine("El numero invertido es: " + numeroInvertido);
    } 
    else
    {
        Console.WriteLine("La entrada no es un número entero válido");
    }
}
else
{
    Console.WriteLine("La entrada no es un número entero válido");
}