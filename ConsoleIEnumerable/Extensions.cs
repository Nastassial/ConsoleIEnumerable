
using System.Numerics;

namespace ConsoleIEnumerable;

internal static class Extensions
{
    public static IEnumerable<TResult> SumWithNext<TResult>(this IEnumerable<TResult> source)
    where TResult : INumberBase<TResult>
    {
        var sourceArray = source.ToArray();

        for (int i = 0; i < sourceArray.Length; i++)
        {
            if (i == sourceArray.Length - 1)
            {
                yield break;
            }

            yield return sourceArray[i] + sourceArray[i + 1];
        }
    }
}
