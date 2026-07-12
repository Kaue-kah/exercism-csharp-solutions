public static class LineUp
{
    public static string Format(string name, int number)
    {
        string ending;
        

        switch (number % 10)
        {
            case 1:
                ending = "st";
                break;

            case 2:
                ending = "nd";
                break;

            case 3:
                ending = "rd";
                break;

            default:
                ending = "th";
                break;
        }

        return $"{name}, you are the {number}{ending} customer we serve today. Thank you!";
    }
}
