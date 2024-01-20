int[] numbersArr = [4, 2, 6, 1, 3, 2, 1];

Numbers numbers = new Numbers(numbersArr);

foreach (int n in numbers)
{
    Console.WriteLine(n);
}


class Numbers
{
    private int[] _arr;

    public Numbers(int[] arr)
    {
        _arr = arr;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < _arr.Length; i++)
        {
            if (i == _arr.Length - 1)
            {
                yield break;
            }

            yield return _arr[i] + _arr[i + 1];
        }
    }
}
