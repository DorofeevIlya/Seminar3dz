// 33. Возведите число А в натуральную степень B используя цикл

int A,B;
int c=1;
Console.Write("Введите число A: ");
A=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите необходимую степень B: ");
B=Convert.ToInt32(Console.ReadLine());
int A1=A;
    while(c<B)
    {
        c++;
        A=A*A1;
    }
    Console.WriteLine($"{A1} в степени {B} равно {A}"); 
