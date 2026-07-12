public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int hammingDistance = 0;
        int sizeRange = firstStrand.Length;

        if (sizeRange > secondStrand.Length)
                sizeRange = secondStrand.Length;

        for (int i = 0; i < sizeRange; i++)
        {
            if (firstStrand[i] != secondStrand[i])
                hammingDistance++;
        }

        return hammingDistance;
    }
}