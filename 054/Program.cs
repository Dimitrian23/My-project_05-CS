// Задача_№54 С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

System.Console.WriteLine("введите число N");
int N=Convert.ToInt32(Console.ReadLine());
int [] fib=new int[N];
int a0=0;
int a1=1;

fib[0]=a0;
fib[1]=a1;
for(int i=2;i<N;i++)
{
    int a=a0+a1;
    fib[i]=a;
    a0=a1;
    a1=a;    
}
for(int i=0;i<fib.Length;i++)
{
     System.Console.Write($"_{fib[i]}_");
}







