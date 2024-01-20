using ConsoleIEnumerable;
using System.Numerics;

int[] numbersIntArray = [4, 2, 6, 1, 3, 2, 1];
List<int> numbersIntList = new List<int>() { 5, 2, 6 };
double[] numbersDoubleArray = [4.3, 5.7, 2.0, 6.1];

WriteResult(numbersIntArray);
WriteResult(numbersIntList);
WriteResult(numbersDoubleArray);

void WriteResult<TValue>(IEnumerable<TValue> source)
    where TValue : INumberBase<TValue>
{
    Console.Write("Result: ");

    foreach (var num in source.SumWithNext())
    {
        Console.Write(num + " ");
    }

    Console.WriteLine();
}