int ReadInt(string msg)// объявляем функцию msg строковую
{
Console.WriteLine(msg);//пишет на экран параметр msg
string a = Console.ReadLine();
int numb;
numb = int.Parse(a);//преобразуем строку в число
return numb;// возврат из функции
}
int numb = ReadInt("Введите трехзначное число:");

if (100 > numb ^ numb > 999)
{
    System.Console.WriteLine($"Пожалуйста, введите треххначное число. Число {numb} не трехзначное");

}
else 

{
    int i = 100;
    while (i < numb)
    {
        numb = numb/10;
        i++;
    }
    Console.WriteLine(numb%10);
}    

