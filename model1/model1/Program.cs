using System;

class Program
{
    static void Main(string[] args)
    {
        Lab1();
        Console.WriteLine();

        Lab2();
        Console.WriteLine();

        Lab3();
        Console.WriteLine();
    }

    static void Lab1()
    {
        double price_max = 140;
        double square_max = 200;
        double f_max = 0;
        int Ax = 0, Bx = 0, Cx = 0, Dx = 0;

        int Ap = (int)(140 / 4);
        int As = (int)(200 / 3);
        int Bp = (int)(140 / 3);
        int Bs = (int)(200 / 8);
        int Cp = (int)(140 / 5);
        int Cs = (int)(200 / 6);
        int Dp = (int)(140 / 4);
        int Ds = (int)(200 / 5);

        int Am = Math.Min(Ap, As);
        int Bm = Math.Min(Bp, Bs);
        int Cm = Math.Min(Cp, Cs);
        int Dm = Math.Min(Dp, Ds);

        for (int A = 0; A <= Am; A++)
        {
            for (int B = 0; B <= Bm; B++)
            {
                for (int C = 0; C <= Cm; C++)
                {
                    for (int D = 0; D <= Dm; D++)
                    {
                        double f = 5 * A + 3 * B + 1 * C + 3 * D;
                        double price = 4 * A + 5 * B + 6 * C + 3 * D;
                        double square = 6 * A + 5 * B + 7 * C + 5 * D;
                        if (f > f_max && price <= price_max && square <= square_max)
                        {
                            f_max = f;
                            Ax = A;
                            Bx = B;
                            Cx = C;
                            Dx = D;
                        }
                    }
                }
            }
        }

        Console.WriteLine("Значения A, B, C, D: " + Ax + ", " + Bx + ", " + Cx + ", " + Dx);
        Console.WriteLine("Повышение производительности: " + (2 * Ax + 1 * Bx + 2 * Cx + 3 * Dx));
        Console.WriteLine("Общая стоимость: " + (2 * Ax + 1 * Bx + 3 * Cx + 5 * Dx));
        Console.WriteLine("Общая площадь: " + (5 * Ax + 6 * Bx + 4 * Cx + 6 * Dx));
        Console.ReadKey();
    }

    static void Lab2()
    {
        double fir_max = 360;
        double sec_max = 260;
        double thi_max = 440;
        double f_max = 0;
        int X1 = 0, X2 = 0;

        int X1_1 = 360;
        int X1_2 = 260;
        int X1_3 = 220;
        int X2_1 = 180;
        int X2_2 = (int)(260 / 3);
        int X2_3 = (int)(440 / 3);

        int X1m = new int[] { X1_1, X1_2, X1_3 }.Min();
        int X2m = new int[] { X2_1, X2_2, X2_3 }.Min();

        for (int X11 = 1; X11 <= X1m; X11++)
        {
            for (int X22 = 1; X22 <= X2m; X22++)
            {
                double res1 = X11 + 2 * X22;
                double res2 = X11 + 3 * X22;
                double res3 = 2 * X11 + 3 * X22;
                double f = 12 * X11 + 4 * X22;

                if (f > f_max && res1 <= fir_max && res2 <= sec_max && res3 <= thi_max)
                {
                    f_max = f;
                    X1 = X11;
                    X2 = X22;
                }
            }
        }

        Console.WriteLine("Значения X1, X2: " + X1 + ", " + X2);
        Console.WriteLine("Прибыль: " + (12 * X1 + 4 * X2));
        Console.WriteLine("Стоимость 1: " + (X1 + 2 * X2));
        Console.WriteLine("Стоймость 2: " + (X1 + 3 * X2));
        Console.WriteLine("Стоймость 2: " + (2 * X1 + 3 * X2));
        Console.ReadKey();
    }

    static void Lab3()
    {
        double a_min = 800;
        double b_min = 700;
        double c_min = 900;
        double p_min = double.MaxValue;
        int Ax = 0, Bx = 0, Cx = 0;

        int Ab = (int)(800 / 360);
        int Aj = (int)(700 / 170);
        int Au = (int)(900 / 380);
        int Bb = (int)(800 / 240);
        int Bj = (int)(700 / 250);
        int Bu = (int)(900 / 440);
        int Cb = (int)(800 / 300);
        int Cj = (int)(700 / 110);
        int Cu = (int)(900 / 440);

        int Am = new int[] { Ab, Aj, Au }.Min();
        int Bm = new int[] { Bb, Bj, Bu }.Min();
        int Cm = new int[] { Cb, Cj, Cu }.Min();

        for (int A = 0; A <= Am; A++)
        {
            for (int B = 0; B <= Bm; B++)
            {
                for (int C = 0; C <= Cm; C++)
                {
                    double resB = 360 * A + 240 * B + 300 * C;
                    double resJ = 170 * A + 250 * B + 110 * C;
                    double resU = 380 * A + 440 * B + 440 * C;
                    double price = 31 * A + 23 * B + 20 * C;

                    if (price < p_min && resB >= 800 && resJ >= 700 && resU >= 900)
                    {
                        Ax = A;
                        Bx = B;
                        Cx = C;
                        p_min = price;
                    }
                }
            }
        }

        Console.WriteLine("Значения A, B, C, D: " + Ax + ", " + Bx + ", " + Cx);
        Console.WriteLine("Белки: " + (360 * Ax + 240 * Bx + 300 * Cx));
        Console.WriteLine("Жиры: " + (170 * Ax + 250 * Bx + 110 * Cx));
        Console.WriteLine("Углеводы: " + (380 * Ax + 440 * Bx + 440 * Cx));
        Console.WriteLine("Цена: " + (31 * Ax + 23 * Bx + 20 * Cx));
        Console.ReadKey();
    }
}
