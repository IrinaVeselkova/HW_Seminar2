int ReadInt(string msg)// объявляем функцию msg строковую
{
Console.WriteLine(msg);//пишет на экран параметр msg
string a = Console.ReadLine();
int numb;
numb = int.Parse(a);//преобразуем строку в число
return numb;// возврат из функции
}
int numb = ReadInt("Введите число от 1 до 7:");

if (numb <1 ^ numb >7)
{
    System.Console.WriteLine("Необходимо ввести число от 1 до 7");
}
else 
{
    if (numb == 6 || numb == 7)
    {
        Console.WriteLine($"Ура!!! Сегодня выходной!");
    }
    else Console.WriteLine($"К сожалению, сегодня не выходной! Пора на работу:(");   
}

