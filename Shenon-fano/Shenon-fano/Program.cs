string A = "абаббкапроти";
static double[] shenon(string input)
{
    List<char> simvols = new List<char>();
    List<int> kolvo = new List<int>();

    for (int i = 0; i < input.Length; i++)
    {
        if(simvols.Contains(input[i]))
        {
            continue;
        }
        simvols.Add(input[i]);
    }
    
}

