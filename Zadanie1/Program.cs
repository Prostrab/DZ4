// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16*/




// Метод 1 
void AB (int a ,int b)
{

Console.WriteLine($"Число А в степени B = {(Math.Pow(a,b))} ");


}

AB(3,5);


//Метод 2 - цикл



 void AB (int a, int b)

{
    int result = 1;
    for (int i = 1; i<=b; i++)
    {
        result = result*a;
        

    }
    
    Console.WriteLine($"{a} в степени {b} = {result}");
}
AB (2,3);



