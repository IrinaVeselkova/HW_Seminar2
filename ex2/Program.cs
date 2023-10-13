int ReadInt(string msg)// объявляем функцию msg строковую
{
Console.WriteLine(msg);//пишет на экран параметр msg
string a = Console.ReadLine();
int numb;
numb = int.Parse(a);//преобразуем строку в число
return numb;// возврат из функции
}
int numb = ReadInt("Введите число:");

if (100 > numb )
{
    System.Console.WriteLine($"В числе {numb} нет третьего знака.");

}
else 

{
    int i = 1000;
    while (i < numb)
    {
        numb = numb/10;
        i++;
    }
    Console.WriteLine(numb%10);
}    

