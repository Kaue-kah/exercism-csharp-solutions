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

        if (formatedNumber.Length == 11)
            if (formatedNumber[0] == '1')
                formatedNumber = formatedNumber.Substring(1);


        if (formatedNumber.Length != 10)
            throw new ArgumentException();


        if (formatedNumber[0] == '1' || formatedNumber[0] == '0')
            throw new ArgumentException();

        if (formatedNumber[3] == '0' || formatedNumber[3] == '1')
            throw new ArgumentException();

        return formatedNumber;

    }
}