try {
    long op,fa;
    int n, nr;
    double r;
    op = 0;

    do
    {
        Console.Clear();
        Console.WriteLine("\tBienvenido");
        Console.WriteLine("Seleccione una opcion");
        Console.WriteLine("1. Factorial");
        Console.WriteLine("2. Raiz cuadrada");
        Console.WriteLine("3. Salir");
        op = long.Parse(Console.ReadLine());

        if (op != 3)
        {
            switch (op)
            {
                case 1:
                    Console.WriteLine("\tFactorial");
                    Console.WriteLine("Ingrse un numero entero positivo");
                    n=int.Parse(Console.ReadLine());
                    fa = 1;
                    for(int i=1; i<=n; i++)
                    {
                        fa = fa*i;
                    }
                    Console.WriteLine("El factorial del numero es:" + fa);
                    break;
                case 2:
                    
                    Console.WriteLine("\tRaiz cuadrada");
                    Console.WriteLine("Ingrese un numero enetero positivo");
                    nr=int.Parse(Console.ReadLine());
                    r = Math.Sqrt(nr);
                    Console.WriteLine("El resultado es: " + r);
                    break;
                default: Console.WriteLine("\tOpcion invalida, seleccione de nuevo");
                    break;
            }
            Console.WriteLine("Presione cualquier numero y luego presione enter para volver al menu de opciones");
            Console.WriteLine("Ingrese 3 para salir");
            op = long.Parse(Console.ReadLine());
        }
    } while (op != 3);
    Console.WriteLine("Fin del programa");
}
catch(Exception eror)
{
    Console.Clear();
    Console.WriteLine("\tValor invalido");
}