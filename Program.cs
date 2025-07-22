// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a: " + a);
Console.WriteLine("valor de b: " + b);

// Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
// texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
// número sólo si éste es mayor a 0.
// Nota: Si observa un subrayado amarillo sugiriendo modificar las variables al tipo
// "nullable", abra el archivo de configuración de proyecto de extensión .csproj y elimine
// la línea que dice <Nullable>enable</Nullable>. No olvide guardar el archivo.

int numero=0;
Console.Write("Ingrese un numero que quiera invertir (entero positivo): ");
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

// Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
// calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
// Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que
// luego pida dos números y que devuelva el resultado de la operación seleccionada. Además
// una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n=== CALCULADORA ===");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.Write("Seleccione una opción (1-4): ");
    string opcion = Console.ReadLine();

    if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4")
    {
        Console.WriteLine("Opción inválida.");
    }
    else
    {
        Console.Write("Ingrese el primer número: ");
        bool esNum1 = double.TryParse(Console.ReadLine(), out double num1);

        Console.Write("Ingrese el segundo número: ");
        bool esNum2 = double.TryParse(Console.ReadLine(), out double num2);

        if (!esNum1 || !esNum2)
        {
            Console.WriteLine("Error: Debe ingresar números válidos.");
        }
        else
        {
            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"Resultado: {num1 + num2}");
                    break;
                case "2":
                    Console.WriteLine($"Resultado: {num1 - num2}");
                    break;
                case "3":
                    Console.WriteLine($"Resultado: {num1 * num2}");
                    break;
                case "4":
                    if (num2 != 0)
                        Console.WriteLine($"Resultado: {(num1 / num2):F2}"); //F2 para mostrar solo 2 decimales
                    else
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    break;
            }
        }
    }

    Console.Write("¿Desea realizar otra operación? (s/n): ");
    string respuesta = Console.ReadLine();
    continuar = (respuesta.ToLower() == "s");
}

// Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la
// calculadora. Solicite al usuario un número y muestre por pantalla:
// ● El valor absoluto de un número
// ● El cuadrado
// ● La raíz cuadrada
// ● El seno
// ● El Coseno
// ● La parte entera de un tipo float.
// Luego de esto, solicite dos números al usuario y determine:
// ● El Máximo entre los dos números
// ● El Mínimo entre los dos números
// Para TODOS los casos, no olvide contemplar siempre el caso de que el usuario no ingrese un número válido.

Console.WriteLine("\n--- CALCULADORA V2 ---");
Console.Write("Ingrese un número: ");
string entrada1 = Console.ReadLine();

if (double.TryParse(entrada1, out double numero1))
{
    Console.WriteLine($"Valor absoluto: {Math.Abs(numero1)}");
    Console.WriteLine($"Cuadrado: {Math.Pow(numero1, 2)}");

    if (numero1 >= 0)
        Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero1):F2}");
    else
        Console.WriteLine("Raíz cuadrada: Error, no se puede calcular con un número negativo.");

    Console.WriteLine($"Seno: {Math.Sin(numero1):F4}");
    Console.WriteLine($"Coseno: {Math.Cos(numero1):F4}");
    Console.WriteLine($"Parte entera: {Math.Truncate(numero1)}");
}
else
{
    Console.WriteLine("Error: No ingresó un número válido.");
}

// Observaciones:
// Math es parte de la librería estándar para funciones matemáticas.
// El :F2 y :F4 limita la cantidad de decimales mostrados.

Console.WriteLine("\n--- COMPARACIÓN ENTRE DOS NÚMEROS ---");

Console.Write("Ingrese el primer número: ");
string input1 = Console.ReadLine();

Console.Write("Ingrese el segundo número: ");
string input2 = Console.ReadLine();

bool esNumero1 = double.TryParse(input1, out double n1);
bool esNumero2 = double.TryParse(input2, out double n2);

if (esNumero1 && esNumero2)
{
    double max = Math.Max(n1, n2);
    double min = Math.Min(n1, n2);

    Console.WriteLine($"Máximo: {max}");
    Console.WriteLine($"Mínimo: {min}");
}
else
{
    Console.WriteLine("Error: Uno o ambos valores ingresados no son válidos.");
}

/*Ejercicio 4.
Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes tarea:*/

// ● Obtener la longitud de la cadena y muestre por pantalla.
Console.Write("\nIngrese una cadena de texto: ");
string cadena1 = Console.ReadLine();
Console.WriteLine($"La longitud de la cadena es: {cadena1.Length}");

// ● A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.
Console.Write("Ingrese una segunda cadena: ");
string cadena2 = Console.ReadLine();
string concatenada = string.Concat(cadena1, " ", cadena2);
Console.WriteLine($"Cadenas concatenadas: {concatenada}");

// ● Extraer una subcadena de la cadena ingresada.
if (cadena1.Length >= 3)
{
    string subcadena = cadena1.Substring(0, 3); // primeros 3 caracteres
    Console.WriteLine($"Subcadena (primeros 3 caracteres): {subcadena}");
}
else
{
    Console.WriteLine("La cadena es muy corta para extraer una subcadena de 3 caracteres.");
}

/* ● Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y 
mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para la suma sería: “la suma 
de “ num1 “ y de” num2 “ es igual a: ” resultado.
Donde num1, num2 y resultados son los sumandos y el resultado de la operación respectivamente.
Nota: Busque el comportamiento del Método ToString();*/

Console.Write("\nIngrese el primer número: ");
double.TryParse(Console.ReadLine(), out double a1);

Console.Write("Ingrese el segundo número: ");
double.TryParse(Console.ReadLine(), out double b1);

double resultado = a1 + b1;

string textoResultado = $"La suma de {a1.ToString()} y de {b1.ToString()} es igual a: {resultado.ToString()}";
Console.WriteLine(textoResultado);

// ● Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla

Console.WriteLine("\nCaracteres individuales de la primera cadena:");
foreach (char c in cadena1)
{
    Console.WriteLine(c);
}

// ● Buscar la ocurrencia de una palabra determinada en la cadena ingresada

Console.Write("\nIngrese una palabra a buscar en la primera cadena: ");
string palabra = Console.ReadLine();

if (cadena1.Contains(palabra))
    Console.WriteLine($"La palabra '{palabra}' aparece en la cadena.");
else
    Console.WriteLine($"La palabra '{palabra}' NO se encuentra.");

// ● Convierta la cadena a mayúsculas y luego a minúsculas.

Console.WriteLine($"Mayúsculas: {cadena1.ToUpper()}");
Console.WriteLine($"Minúsculas: {cadena1.ToLower()}");

// ● Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los 
//resultados (Revisar el comportamiento de split())

Console.Write("\nIngrese una cadena separada por comas: ");
string separada = Console.ReadLine();

string[] partes = separada.Split(',');

Console.WriteLine("Partes separadas:");
foreach (string parte in partes)
{
    Console.WriteLine(parte.Trim()); // elimina espacios
}

/*● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena 
de caracteres y que el sistema lo resuelva. Por ej. ingrese por pantalla “582+2” y que le devuelva 
la suma de 582 con 2*/

Console.Write("\nIngrese una ecuación simple (ej. 582+2): ");
string ecuacion = Console.ReadLine();

if (ecuacion.Contains("+"))
{
    var partes1 = ecuacion.Split('+');
    if (double.TryParse(partes1[0], out double n11) && double.TryParse(partes1[1], out double n22))
        Console.WriteLine($"Resultado: {n11 + n22}");
    else
        Console.WriteLine("Valores no válidos.");
}
else if (ecuacion.Contains("-"))
{
    var partes1 = ecuacion.Split('-');
    if (double.TryParse(partes1[0], out double n11) && double.TryParse(partes1[1], out double n22))
        Console.WriteLine($"Resultado: {n11 - n22}");
    else
        Console.WriteLine("Valores no válidos.");
}
else if (ecuacion.Contains("*"))
{
    var partes1 = ecuacion.Split('*');
    if (double.TryParse(partes1[0], out double n11) && double.TryParse(partes1[1], out double n22))
        Console.WriteLine($"Resultado: {n11 * n22}");
    else
        Console.WriteLine("Valores no válidos.");
}
else if (ecuacion.Contains("/"))
{
    var partes1 = ecuacion.Split('/');
    if (double.TryParse(partes1[0], out double n11) && double.TryParse(partes1[1], out double n22))
    {
        if (n22 != 0)
            Console.WriteLine($"Resultado: {n11 / n22}");
        else
            Console.WriteLine("No se puede dividir por cero.");
    }
    else
        Console.WriteLine("Valores no válidos.");
}
else
{
    Console.WriteLine("Formato de ecuación no válido.");
}