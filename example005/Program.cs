Console.Write("Введите имя пользвателя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{   
     Console.WriteLine("Ура, эт Маша!" );
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine(username);
}
