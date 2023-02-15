// Задача_№56 Написать программу копирования массива

 int N;
    System.Console.Write("Задайте желаемую длину массива:");
         N=Convert.ToInt32(Console.ReadLine());

int [] M;
M=new int[N]; 

Random random=new Random();
  for(int i=0;i<M.Length;i++)
    M[i]=random.Next(1,999);

    System.Console.Write("Дан массив случайных чисел:--->");
   for(int i=0;i<M.Length;i++)
    System.Console.Write($" [ {M[i]} ] ");
    System.Console.WriteLine();
int [] M1;
M1=new int[M.Length]; 
Array.Copy(M,M1,M.Length);
System.Console.Write("Копия массива----------------->");
 for(int i=0;i<M1.Length;i++)
  System.Console.Write($" [ {M1[i]} ] ");



