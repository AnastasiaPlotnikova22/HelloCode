// №1 Метод невозврата без аргументов
void Metod1()
{
Console.WriteLine("Автор …");
}
// Metod1();


// №2 Метод невозврата с аргументами
void Metod2(string msg)
{
Console.WriteLine(msg);
}
//Metod2("Текст сообщения");

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Metod21("Текст", 4);
//или
//Metod21(msg: "Текст", count: 4);

//№3 Метод возврата без аргументов
int Metod3()
{
    return DateTime.Now.Year;
}
// int year = Metod3();
// Console.WriteLine(year);


//№4 Метод возврата с аргументами

// string Metod4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Metod4(10, "z");
// Console.WriteLine(res);



string Metod4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);
