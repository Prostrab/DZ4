// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int ReadNum (string message)
{
Console.WriteLine($"Введите массив из 8 эл-ов {message}");
string readNum = Console.ReadLine();
int result = int.Parse(readNum);
return result;
}


int GenerateArray (int len, int minV , int maxV)
{
int [] array = new int [len];


}