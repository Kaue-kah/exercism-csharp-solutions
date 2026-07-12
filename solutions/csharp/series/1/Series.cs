public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {

        if (String.IsNullOrEmpty(numbers))
            throw new ArgumentException();
            
        if (sliceLength <= 0)
            throw new ArgumentException();

        int size = numbers.Length;
        
        if (size < sliceLength) 
            throw new ArgumentException();

        List<string> slicedNumbers = new List<string>();
        
        for (var i = 0; i <= size - sliceLength; i++)
        {
            slicedNumbers.Add(numbers.Substring(i, sliceLength));
        }
        
        return slicedNumbers.ToArray();
        
    }
}