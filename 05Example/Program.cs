Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("это МАША! Дааааааа!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}
