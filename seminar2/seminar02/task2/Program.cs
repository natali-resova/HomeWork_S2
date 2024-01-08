
//2. Определить номер координатной плоскости, которой принадлежит точка с координатами (x,y)
double x = +3.3;
double y = -6.8;
if (x > 0)
{
   if (y > 0)
    {
       Console.WriteLine($"I");
    }  
   else
   {   
       Console.WriteLine($"IV");
   }
}
if (x < 0)
 {
if (y > 0)
  {
      Console.WriteLine($"II");
   }
  else
   {   
       Console.WriteLine($"III");
   }
 }
