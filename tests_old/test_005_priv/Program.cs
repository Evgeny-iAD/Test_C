// See https://aka.ms/new-console-template for more information
Console.Write("Введите имя пользователя: ");
string user_name = Console.ReadLine();
if (user_name.ToLower() == "Мария")   //ToLower приписка для игнора регистра
{
Console.Write("ПШла работать! ");
}
else
{
Console.Write("Добрый день!");
Console.WriteLine(user_name);
}