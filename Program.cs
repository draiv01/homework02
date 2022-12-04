// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


// int Test()
// {
//     int num = new Random().Next(100, 1000);
//     System.Console.WriteLine(num);
//     int a = num /100;
//     int b = num /10;
//     int c = num /10 % 10;
//     return ((a * 10) - b);
//     }
// int res = Test();
// System.Console.WriteLine(res);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



// void Test(int num)
// {
//     if (num > 99)
//     {
//         System.Console.WriteLine($"Третья цифра {num%10}");
//     }
//     else
//     {
//         System.Console.WriteLine($"Третьей цифры нет");
//     }
// }
// System.Console.WriteLine();
// int num = Convert.ToInt32(Console.ReadLine());
// Test(num);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// void Square_test(int day){
//     if (day < 6){
//         Console.Write($"Рабочий день");
//     }
//     else if (day <= 7){
//         Console.Write($"выходной");
//     }
//     else{
//         Console.Write($"Нет такого дня");
//     }
// }
// int day = Convert.ToInt32(Console.ReadLine());
// Square_test(day);