// 36. Написать программу вычисления произведения чисел от 1 до N

int N;
int b=1;
int c=1;
Console.Write("Введите число N: ");
N=Convert.ToInt32(Console.ReadLine());

    while(c<N)
    {
            c++;
            b=c*b; 
    }
Console.WriteLine($"Произведение чисел от 1 до {N} = {b}");
