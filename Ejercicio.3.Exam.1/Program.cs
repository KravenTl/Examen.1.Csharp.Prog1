try
{
    int n;
    Console.WriteLine("\tIngrese el numero para hacer la multiplicacion");
    n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= 10; i++)
    {
        int r = n * i;
        Console.WriteLine("{0}*{1}={2}", n, i, r);
    }

}
catch (Exception error)
{
    Console.Clear();
    Console.WriteLine("Valor ingresado no valido");
}