public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        char[] letters = ['I', 'V', 'X', 'L', 'C', 'D', 'M'];

        string test = value.ToString();
        string romanNumber = "";

        for (var i = 0; i < test.Length; i++)
        {
            int currentNumber = int.Parse(test[test.Length - i - 1].ToString());
            int vIndex = i * 2;

            if (currentNumber <= 5)
            {
                switch (currentNumber)
                {
                    case 5:
                        romanNumber = letters[vIndex + 1] + romanNumber;
                        break;
                    case 4:
                        romanNumber = $"{letters[vIndex]}{letters[vIndex + 1]}" + romanNumber;
                        break;
                    case 3:
                    case 2:
                    case 1:
                        for (var j = 0; j < currentNumber; j++)
                            romanNumber = $"{letters[vIndex]}{romanNumber}";
                        break;
                    default:
                        break;
                }
            }

            if (currentNumber <= 9)
            {
                switch (currentNumber)
                {
                    case 9:
                        romanNumber = $"{letters[vIndex]}{letters[vIndex + 2]}" + romanNumber;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        string number = $"{letters[vIndex + 1]}";
                        for (var j = 0; j < (currentNumber - 5); j++)
                            number += $"{letters[vIndex]}";
                        romanNumber = $"{number}" + romanNumber;
                        break;
                    default:
                        break;
                }
            }
        }

        return romanNumber;
    }
}