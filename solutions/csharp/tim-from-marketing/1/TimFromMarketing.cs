static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        department = department ?? "OWNER";
        string text = $"{name} - {department.ToUpper()}";

        if (id != null)
        {
            text = $"[{id}] - " + text;
        }

        return text;
    }
}
