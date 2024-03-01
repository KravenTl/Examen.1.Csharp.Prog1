try
{
   
    int n, op,con;
    op= 0;
    do
    {

        Random rand=new Random();
        int ramd = rand.Next(1, 101);
        con = 0;
        Console.Clear();
        Console.WriteLine("\tQuieres empezar el juego?");
        Console.WriteLine("Presione 1 para emepezar el juego");
        Console.WriteLine("Presione -1 para salir");
        op = int.Parse(Console.ReadLine());
        if (op != -1)
        {
            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\tHora de jugar!");
                    do
                    {
                        con++;
                        Console.WriteLine("Ingresa un numero entre 1 y 100");
                        n = int.Parse(Console.ReadLine());
                        if (n < ramd)
                        {
                            Console.WriteLine("Frio");
                        }
                        else
                        {
                            Console.WriteLine("Caliente");
                        }
                    } while (n != ramd);
                    {
                        Console.Clear();
                        Console.WriteLine("Felicidades haz adivinado el numero!:"+ramd) ;
                        Console.WriteLine("El numero de intentos:" +con);

                    }
                    break;
                default:
                    {
                        Console.WriteLine("\tOpcion Invalida");
                    }
                    break;
        }
            
            Console.WriteLine("Presione 0 para volver al menu principal");
            Console.WriteLine("Presione -1 para salir");
            op = int.Parse(Console.ReadLine());
        }
    } while (op != -1);
    {
       Console.WriteLine("Game Over");
    }
}catch (Exception error){
    Console.Clear();
    Console.WriteLine("Valor ingresado no valido");
}