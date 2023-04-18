
    Console.WriteLine("Введите число №1:");
    string s1 = Console.ReadLine();
    int Number1 = int.Parse(s1);
    Console.WriteLine("Введите число №2:");
    string s2 = Console.ReadLine();
    int Number2 = int.Parse(s2);

        if (Number1 > Number2)
        {
            Console.WriteLine("Максимальное число: " + Number1);
            Console.WriteLine("Минимальное число: " + Number2);
        }
        else
        {
            Console.WriteLine("Максимальное число: " + Number2);
            Console.WriteLine("Минимальное число: " + Number1);
        }
