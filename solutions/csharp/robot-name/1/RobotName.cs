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
                
                string firstPart = "";
                string secondPart = "";


                for (var i = 0; i < 2; i++)
                {
                    char leter = (char)rd.Next('A', 'Z' + 1);
                    firstPart += leter;
                }

                for (var i = 0; i < 3; i++)
                {
                    int n = rd.Next(0, 10);
                    secondPart += n;
                }
            
                _name = firstPart + secondPart;
                
                if (!(usedNames.Contains(_name)))
                {
                    usedNames.Add(_name);
                }
                
            }

            return _name;
        }
    }

    public void Reset()
    {
        _name = null;
    }
}