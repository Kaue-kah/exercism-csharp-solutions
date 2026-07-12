using System.Reflection.Metadata.Ecma335;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string formatedNumber = "";
        
        foreach (char c in phoneNumber)
        {
            if (char.IsNumber(c))
                formatedNumber += c;
        }

        if (formatedNumber.Length != 10)
            throw new ArgumentException();

        return formatedNumber;

    }
}