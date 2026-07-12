public class Robot
{

    private string _name;
    private static Random rd = new Random();
    private static List<string> usedNames = new List<string>();

    public string Name
    {
        get
        {
            if (_name == null)
            {
                do
                {
                    string firstPart = "";
                    string secondPart = "";

                    for (var i = 0; i < 2; i++)
                    {
                        char letter = (char)rd.Next('A', 'Z' + 1);
                        firstPart += letter;
                    }

                    for (var i = 0; i < 3; i++)
                    {
                        int n = rd.Next(0, 10);
                        secondPart += n;
                    }

                    _name = firstPart + secondPart;

                } while (usedNames.Contains(_name));

                usedNames.Add(_name);
            }

            return _name;
        }
    }

    public void Reset()
    {
        _name = null;
    }
}