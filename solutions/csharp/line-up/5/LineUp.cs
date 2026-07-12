public static class LineUp
{
    public static string Format(string name, int number)
    {
        string ending = "th";
        int except = number % 100;

        if (!(except >= 11 && except <= 13))
        {
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
                    break;
            }
        }
        

        return $"{name}, you are the {number}{ending} customer we serve today. Thank you!";
    }
}
