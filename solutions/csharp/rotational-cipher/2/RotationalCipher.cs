using System.Runtime.ConstrainedExecution;

public static class RotationalCipher
{

    const string Plain = "abcdefghijklmnopqrstuvwxyz";

    public static string Rotate(string text, int shiftKey)
    {

        var encodedText = new System.Text.StringBuilder(text.Length);

        foreach (char c in text)
        {
            int index = Plain.IndexOf(char.ToLower(c));

            if (index < 0)
            {
                encodedText.Append(c);
            }
            else
            {
                char shifted = Plain[(index + shiftKey) % 26];

                if (char.IsUpper(c)) encodedText.Append(char.ToUpper(shifted));
                else encodedText.Append(shifted);
            }
        }

        return encodedText.ToString();

    }
}