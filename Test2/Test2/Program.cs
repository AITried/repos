using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
class Program
{
    static double Fun(double x)
    {
        return Math.Pow(x, 4) / (0.5 * Math.Pow(x, 2) + x + 6);
    }
    static void Main(string[] args)
    {
        IntegralCaluclator.Function function = Fun;
        IntegralCaluclator.Integral(function, 0.4, 1.0);
    }

}

    public static class IntegralCaluclator
    {
    public delegate double Function(double x);
    public static double Integral(Function f, double a, double b)
    {
        Trace.Indent();
        try
        {
            Trace.WriteLine("Начало вычисления интеграла");
            double i1 = 1d;
            double i2 = 0d;
            int N = 10;
            double h = 0d;
            double delta = 1 / (double)3 * Math.Abs(i2 - i1);
            int counter = 0;
            while (delta > 0.0001)
            {
                i2 = 0;
                i1 = 0;
                h = (b - a) / N;
                var x1 = a;
                var x2 = a + h;
                for (int k = 1; k <= N; k++)
                {
                    i1 += h * ((f(x2) + f(x1)) / 2);
                    x2 += h;
                    x1 += h;
                }
                int N2 = N * 2;
                h = (b - a) / N2;
                x1 = a;
                x2 = a + h;
                for (int k = 1; k <= N2; k++)
                {
                    Trace.Assert(!(x2 < a || x2 > b), "Выход X за границу");
                    i2 += h * ((f(x2) + f(x1)) / 2);
                    x2 += h;
                    x1 += h;
                    Trace.WriteLine($"Текущее значение интеграла на шаге {k} равно: {i2}");
                    Debug.WriteLineIf(k == 12, $"Значение интеграла на 12 шаге равно: {i2}");
                    Trace.WriteLineIf(k == 12, $"Значение интеграла на 12 шаге равно: {i2}");
                    Trace.WriteLine($"Значение переменных на шаге {k} равно: i2: {i2}\tk: {k}\tx1: {x1}\tx2: {x2}");
                }
                N *= 10;
                delta = (1 / (double)3) * Math.Abs(i2 - i1);
                counter++;
                Trace.WriteLine($"Текущее значение дельты на общем шаге {counter} равно: {delta}");
                Trace.Unindent();
            }
            return i2;
        }
        catch (Exception ex)
        {
            Trace.TraceError($"При вычислении интеграла произошла следующая ошибка: {ex.Message}");
            Trace.Unindent();
            return 0;
        }
    }
}
