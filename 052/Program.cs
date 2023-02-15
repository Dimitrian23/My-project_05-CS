// Задача_№52 Написать программу преобразования десятичного числа в двоичное

System.Console.WriteLine("Введите число:");
        int N=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine();
int S=N;        
int N2=0,k=0;
while(N!=0)
{
    N2=N2+N%2*(int)Math.Pow(10,k);
    N=N/2;
    k++;
}
System.Console.WriteLine($"Преобразую десятичное число {S} в двоичное {N2} ");

