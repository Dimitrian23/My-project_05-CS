// Задача_№51 С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

// namespace GeekBrains
// {
//    namespace Introduction
//    {
//       class Task051
//       {
//          static void Main()
//           {
//             int N=Convert.ToInt32(Console.ReadLine());
//             int k=0;
//             for(int i=0;i<N;i++)
//              {
//                 int n=int.Parse(Console.ReadLine());
//                  if(n>0) k++;
//              }
//              System.Console.WriteLine();
//                 System.Console.WriteLine(k);
//           }
//       }
//    }
// }
               System.Console.WriteLine("Параметр ограничения: сколько чисел нужно ввести с клавиатуры для проверки?");
        int N=Convert.ToInt32(Console.ReadLine());
               System.Console.WriteLine();
               System.Console.WriteLine("Вводите последовательно числа подтверждая ввод каждого нажатием клавиши--->[Enter]");
            int k=0;
            for(int i=0;i<N;i++)
               {
                int n=Convert.ToInt32(Console.ReadLine());
                 if(n>0) k++;
               }
               System.Console.WriteLine("Столько значений больше нуля было введено с клавиатуры");
               System.Console.WriteLine(k);







