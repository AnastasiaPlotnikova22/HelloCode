﻿Console.Write("Введите им пользователя: ");
string? username = Console.ReadLine();

if(username.ToLower() == "маша")
{
     Console.WriteLine("Ура, это МАША!");
}
else
{
     Console.Write("Привет, ");
    Console.WriteLine(username);   
}
