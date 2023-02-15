// Задача_№50 Выяснить являются ли три числа сторонами треугольника.

int a,b,c;
       System.Console.WriteLine("Введите последовательно три числа подтверждая ввод каждого нажатием клавиши Enter");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            c=Convert.ToInt32(Console.ReadLine());

   if(a+b>c && b+c>a && a+c>b) 
     {
       System.Console.WriteLine("Являются");
     }
    else 
     {
        System.Console.WriteLine("Не являются");
     } 

