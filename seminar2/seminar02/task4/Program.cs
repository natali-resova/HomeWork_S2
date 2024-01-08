
//4. Вывести цифры натурального числа N через запятую
// Вариант 1

//long N = 1;
//while (N >= 1)
//{
//  long lastN = N % 10;
//  N = N / 10;
//  Console.Write(lastN + ",");
//}

// Вариант 2

double N = 01;
// Определение значения b - кол-ва разрядов в числе N
int b = 0;
double A = N;
while ( N >=1)
{    
    b = b + 1;   
    N =  N / 10;
}
//Console.WriteLine(b);
while (b >= 1)
{
double B = Math.Floor(A / Math.Pow(10,b-1));
double lastB = B % 10;
b = b - 1;
Console.Write(lastB + ",");
}