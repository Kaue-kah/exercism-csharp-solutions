public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        string finalWord = "";
        int qtdChar = 1;

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            if ((i + 1 < input.Length) &&
                (currentChar == input[i + 1]))
            {
                qtdChar++;
            }
            else
            {
                if (qtdChar != 1)
                    finalWord += $"{qtdChar}{currentChar}";
                else
                    finalWord += currentChar;

                qtdChar = 1;
            }
        }

        return finalWord;
    }

    public static string Decode(string input)
    {
        string finalWord = "";
        string currentNumber = "0";

        for (var i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            bool isNumber = char.IsNumber(currentChar);

            if (isNumber) { currentNumber += currentChar; }
            else
            {
                int number =
                    (int.Parse(currentNumber) == 0) ? 1 : int.Parse(currentNumber);

                for (var j = 0; j < number; j++)
                    finalWord += currentChar;

                currentNumber = "0";
            }
        }

        return finalWord;
    }
}


