using System;
using System.Text;
namespace SoftwareTestingLabsExamples01x01
{
    class Program
    {
        //Метод, считающий сумму элементов массива
        static int sum(int[] x, int N)//1
        {//2
            int s = 0;//3
            for (int i = 0; i < N; i++)//4
                s += x[i];//5
            return s;//6
        }
        //Метод для ввода целых чисел с клавиатуры
        static int ReadInt(string prompt)//7
        {//8
            Console.Write(prompt);//9
            int x = int.Parse(Console.ReadLine());//10
            return x;//11
        }
        static void Main(string[] args)//12
        {
            const int N = 10;//13
            int[] a = new int[N] { 1, 3, -5, 0, 4, 6, -1, 9, 3, 2 };//14
            //Найдем максимальный элемент массива
            int m = a[0];//15
            for (int i = 1; i < N; i++)//16
                if (m < a[i])//17
                    m = a[i];//18
            Console.WriteLine(m);//19
            //Найдем сумму элементов массива
            int s;//20
            s = sum(a, N);//21
            Console.WriteLine(s);//22
            int z = s / m;//23
            int k = 0;//24
            for (int i = 0; i < N; i++)//25
                if (a[i] > z)//26
                    k += a[i];//27
                else//28
                    k -= a[i];//29
            Console.WriteLine(k);//30
            int x, y;//31
            x = ReadInt("");//32
            y = ReadInt("");//33
            s = 0;//34
            while ((x != 0) && (x != 0))//35
            {//36
                x--;//37
                y--;//38
                s += x + y;//39
            }//40
            Console.WriteLine(s);//41
        }
    }
}
