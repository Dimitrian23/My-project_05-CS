// Переворот массива


// int[]a={3,2,7,1,9};
//            System.Console.Write("Вариант (А) оригинальный:");
//    for(int i=0;i<a.Length;i++)
//       {
//            System.Console.Write($" {a[i]} ");
//       }
//            System.Console.WriteLine();
// int t;
//    for(int i=0;i<a.Length/2;i++)
//       {
//         t=a[i];
//         a[i]=a[a.Length-i-1];
//         a[a.Length-i-1]=t;
//       }
//            System.Console.Write("Вариант (В) перевёрнутый:");
//    for(int i=0;i<a.Length;i++)
//       {
//            System.Console.Write($" {a[i]} ");
//       }



int[]a={3,2,7,1,9};
           System.Console.Write("Вариант (А) оригинальный:");
   for(int i=0;i<a.Length;i++)
      {
           System.Console.Write($" {a[i]} ");
      }
           System.Console.WriteLine();

  ReverseArray(a);
  
            System.Console.Write("Вариант (В) перевёрнутый:");

   for(int i=0;i<a.Length;i++)
      {
           System.Console.Write($" {a[i]} ");
      }

void Swap(ref int a, ref int b)
      {
         int t=a;
         a=b;
         b=t;
      }

void ReverseArray(int[] a)
{
    for(int i=0;i<a.Length/2;i++)
      {
       Swap(ref a[i], ref a[a.Length-i-1]);
      }
}





