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

        if (formatedNumber.Length > 0)
        {
            int firstNumber = char.ConvertToUtf32(formatedNumber[0]);
            if (firstNumber < 2)
                formatedNumber = formatedNumber.Substring(1);
        }
            

        if (formatedNumber.Length != 10)
            throw new ArgumentException();

        return formatedNumber;

    }
}