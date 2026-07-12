public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int hammingDistance = 0;

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