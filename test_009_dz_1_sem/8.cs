// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите любое целое число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count <= number)
{
 Console.Write(count);
 Console.Write(" ");
 count = count + 2;
}




