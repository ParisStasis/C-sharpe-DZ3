// Задача 19 Программа принимает число и проверяет является ли оно палиндромом.


Console.WriteLine("ВВедите число  ");
string number = Console.ReadLine();
int length = number.Length;
if ( length == 5 )
{
    if (number[0]==number[4]&& number[1]==number[3])
    {
        Console.WriteLine($"{number} - является палиндромом" );
    
    }
    else
    {
        Console.WriteLine($"{number} - не является палиндромом");
    }
}