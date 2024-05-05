var list = new List<int> { 5, 7, 10, 2, 3, 6, 8 };
//2,3,5,6,7,10
list.Sort();
var result = new List<int>();
//2,3,5,6,7,10
//3,4,5,6,7,10
//5,6,7,10
//6,7,10
//7,10
var max = list.Min();
for (int i = 0; i < list.Count; i++)
{
    var start = list[i];
    for (int j = start, k = i; k < list.Count && j < start + list.Count - i; j++, k++)
    {
        if (list[k] == j)
        {
            result.Add(j);

        }
        else
        {
            break;
        }


    }

    if (result.Count > max)
    {
        max = result.Count;
    }
    foreach (var item in result)
    {
        Console.Write($"{item},");
    }


    Console.WriteLine();
    result.Clear();
}

Console.WriteLine($"max: {max}");