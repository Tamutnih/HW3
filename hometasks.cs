// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// Console.WriteLine("Введите число: ");

// int num = Convert.ToInt32(Console.ReadLine());

int num, rem, sum = 0, temp;
        
    
        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while (Convert.ToBoolean(num))
        {
            rem = num % 10;  //остаток от деления на 10
            num = num / 10; //для получения частного путем деления на 10
            sum = sum * 10 + rem;  //умножение суммы на 10 и добавление остатка
        }
        Console.WriteLine("Обратное число: {0} \n", sum);
        if (temp == sum) //проверка, является ли введенное число равным введенному числу
        {
            Console.WriteLine("Число - палиндром \n\n");
        }
        else
        {
            Console.WriteLine("Число не палиндром \n\n");
        }
        Console.ReadLine();
