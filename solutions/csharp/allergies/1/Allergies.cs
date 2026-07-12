public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private int _mask;

    public Allergies(int mask)
    {
        _mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (_mask & (int)allergen) != 0;
    }

    public Allergen[] List()
    {
        List<Allergen> allergies = new List<Allergen>();


        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if (IsAllergicTo(allergen))
            {
                allergies.Add(allergen);
            }
        }

        return allergies.ToArray();
    }
}