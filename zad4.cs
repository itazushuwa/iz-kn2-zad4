Console.OutputEncoding = System.Text.Encoding.UTF8;
while (true)
{
    static int C(int n, int k)
    {
        if (k == 0 || k == n)
            return 1;
        else return C(n - 1, k - 1) + C(n - 1, k);
    }

    int n = 0;
    Console.WriteLine("\nВедите степень");
    n = Convert.ToInt32(Console.ReadLine());

    for (int j = 0; j <= n; j++)
    {
        for (int i = 0; i <= j; i++)
        {

            Console.Write(C(j, i) + ", ");
        }
        Console.WriteLine();
    }
}
