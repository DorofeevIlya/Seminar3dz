// 35. Подсчитать сумму цифр в числе. Сделать подпрограмму.

int Summa (int A)
{
   int d0;
   int s=0;
   while(A!=0)
    {
        d0=A%10;
        A=A/10;
        s=s+d0;
    }
    return s;
}

Console.Write("Введите число A: ");
int A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {A} = {Summa(A)}");
