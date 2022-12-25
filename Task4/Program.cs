Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 1)
            {
                Console.WriteLine("Число " + a + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + a + "является: ЧЁТНЫМ");
            }