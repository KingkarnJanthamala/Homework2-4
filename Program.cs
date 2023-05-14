using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); //N คือช่วงทั้งหมด
        int K = int.Parse(Console.ReadLine()); //K คือระยะช่วงถนน
        if ((N >= 1) && (N <= 10000) && (K >= 1) && (K <= 100))
        {
            int[] n = new int[N]; //n คือจำนวนช่วง
            for (int i = 0; i < N; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            int max = 0; //max คือค่าสูงสุด
            for (int i = K; i <= (N - 1) - K; i++)
            {
                int tmp = n[i]; //tmp คือค่าปัจจุบัน
                for (int j = 1; j <= K; j++)
                {
                    tmp = n[i + j] + n[i - j] + tmp;
                }
                max = Max(tmp, max);
            }
            Console.WriteLine(max);
        }
    }
    static int Max(int tmp, int max)
    {
        if (tmp > max)
        {
            return tmp;
        }
        return max;
    }
}