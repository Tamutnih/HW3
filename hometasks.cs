// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



// int num, rem, sum = 0, temp;
        
    
//         Console.Write("Введите число: ");
//         num = Convert.ToInt32(Console.ReadLine());
//         temp = num;
//         while (Convert.ToBoolean(num))
//         {
//             rem = num % 10;  //остаток от деления на 10
//             num = num / 10; //для получения частного путем деления на 10
//             sum = sum * 10 + rem;  //умножение суммы на 10 и добавление остатка
//         }
//         Console.WriteLine("Обратное число: {0} ", sum);
//         if (temp == sum) //проверка, является ли  число равным введенному числу
//         {
//             Console.WriteLine("Число - палиндром ");
//         }
//         else
//         {
//             Console.WriteLine("Число не палиндром ");
//         }
//         Console.ReadLine();




// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату: x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату: y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату: z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату: x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату: y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату: z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");

 

                