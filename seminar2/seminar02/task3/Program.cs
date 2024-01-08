
//3.Показать наибольшую цифру целого числа, принадлежащего отрезку [10, 99]
//D=d1*10+d2
int D = 99;
int d1 = D / 10;
int d2 = D - d1*10;
if (d1 > d2)
{
   Console.WriteLine(d1);
}
else
{
   if (d1 < d2)
   {
      Console.WriteLine(d2);
   }
   else
   {
       Console.WriteLine($"{d1}{d2} - количество десятков и единиц в этом числе одинаково");
   }
}