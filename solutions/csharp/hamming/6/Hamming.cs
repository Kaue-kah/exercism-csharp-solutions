public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int hammingDistance = 0;

        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException();

        int sizeRange = firstStrand.Length;

        for (int i = 0; i < sizeRange; i++)
        {
            if (firstStrand[i] != secondStrand[i])
                hammingDistance++;
        }

        return hammingDistance;
    }
}