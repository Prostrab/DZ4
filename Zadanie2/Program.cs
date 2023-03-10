// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12






Console.WriteLine("Введите число ");
string number = Console.ReadLine();


int NumberLenght (string Lenght) 

{

string LenghtN = String.Empty;
LenghtN = Convert.ToString(number);
int lenght = Convert.ToInt32(LenghtN.Length);

return lenght;

}

Console.WriteLine(NumberLenght (number));


void SumNum(int num, int lenght)
{
    int sum = 0;
    for (int i = 1; i <= lenght; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    Console.WriteLine(sum);
}

SumNum(Convert.ToInt32(number),NumberLenght (number));







