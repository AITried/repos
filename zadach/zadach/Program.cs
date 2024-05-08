class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] st = new string[n];
        int[,] arr = new int[n,n];
        for (int i = 0; i < n; i++)
        {
            st = Console.ReadLine().Split(" ");
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = Convert.ToInt32(st[j]);
            }
            
        }
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int> ();

        int dell = 2;
        for (int i = 1; i <Math.Sqrt(arr[0,1]); i++)
        {
            if (arr[0,1]%i==0 && !list1.Contains(i))
            {
                list1.Add(i);
            }
        }
        list1.Add(arr[0, 1]);
        
        for (int i = 1; i < n; i++)
        {
            if (arr[0, i] == 0)
            {
                continue;
            }
            for (int j = 1; j <= Math.Sqrt(arr[0,i]); j++)
            {
                if (arr[0, i] % j == 0 && !list2.Contains(i))
                {
                    list2.Add(j);
                }
            }

            for (int j = 0; j < list1.Count; j++)
            {
                if (!list2.Contains(list1[j]))
                {
                    list1.Remove(list1[j]);
                }
            }
        }
        list1.Add(1);
        int[] ans = new int[n];
        ans[0] = list1.Max(x => x);
        for (int i = 1; i < n; i++)
        {
            ans[i] = arr[0,i]/ans[0];
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(ans[i] + " ");
        }

    }
}