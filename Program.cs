// Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.645 -> 5 78 -> третьей цифры нет 32679 -> 6
int number = 645 ;
if (number >= 1000) 
{
    while(number >= 1000)
    {
    number = number / 10;
    }

    Console.WriteLine(number % 10);

}
else
{
    Console.WriteLine("третьей цифры нет");

}




