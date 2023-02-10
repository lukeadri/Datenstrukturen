using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class SortAlgorithm
{
    public abstract int[] Sort(int[] data);
}

public class QuickSort : SortAlgorithm
{
    public override int[] Sort(int[] data)
    {
        return data;
    }
}

public class FactoryPattern
{
    public static SortAlgorithm CreateQuickSort(string type)
    {
        switch (type)
        {
            case "quicksort":
                return new QuickSort();
            default:
                throw new ArgumentException("falsch");
        }
    }
}

