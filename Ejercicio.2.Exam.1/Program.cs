try
{
    double n1,n2,r;
    char op;
    do
    {
        Console.Clear();
        Console.WriteLine("\t\tBienvenido");
        Console.WriteLine("\tIngrese la operacion que desea realizar (porfavor ingresar el operador )");
        Console.WriteLine("Suma +");
        Console.WriteLine("Resta -");
        Console.WriteLine("Multiplicacion *");
        Console.WriteLine("Division /");
        Console.WriteLine("Para salir ingrese k");
        op=char.Parse(Console.ReadLine().ToLower ());

      if (op != 'k')
        {
            switch(op)
            {
                case '+':
                    Console.WriteLine("Ingrse el primer numero");
                    n1=double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    n2 = double.Parse(Console.ReadLine());
                    r = n1 + n2;
                    Console.WriteLine("El resultado es:" + r);
                    break;
                case '-':
                    Console.WriteLine("Ingrse el primer numero");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    n2 = double.Parse(Console.ReadLine());
                    r = n1 - n2;
                    Console.WriteLine("El resultado es:" + r);
                    break;
                case '*':
                    Console.WriteLine("Ingrse el primer numero");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    n2 = double.Parse(Console.ReadLine());
                    r = n1*n2;
                    Console.WriteLine("El resultado es:" + r);
                    break;
                case '/': 
                    Console.WriteLine("Ingrse el primer numero");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    n2 = double.Parse(Console.ReadLine());
                    r = n1 / n2;
                    Console.WriteLine("El resultado es:" + r);
                    break;
                default:
                    {
                        Console.WriteLine("\tOpcion Invalida");
                    }
                    break;
            }
            Console.WriteLine("Presione cualquier tecla y luego enter para volver al menu de opciones");
            Console.WriteLine("Ingrese k si desea salir");
            op = char.Parse(Console.ReadLine().ToLower());
        }
    } while (op != 'k');
    {
        Console.WriteLine("Fin del programa");
    }


}catch(Exception error)
{
    Console.Clear();
    Console.WriteLine("Valor ingresado no valido");
}