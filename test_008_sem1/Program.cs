// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
double i = number;
//int num = -number;
//
//while (count < (number*2 + 1))
//{
//  Console.WriteLine(num);
//  num++;
//  count++;
//}

i = i/10;
number = number/10;
int sum = Convert.ToInt32((i-number)*10);
Console.WriteLine("последняя  цифра числа: ");
Console.WriteLine(sum);



