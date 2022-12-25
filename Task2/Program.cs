 int a, b;
 
        Console.WriteLine("Введите два числа : ");
 
        a = int.Parse(Console.ReadLine());
 
        b = int.Parse(Console.ReadLine());
 
        if (a > b)
 
        {
 
            Console.WriteLine("{0} наименьшее число", b);
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} наименьшее число ", a);
 
        }
 
        Console.ReadLine();