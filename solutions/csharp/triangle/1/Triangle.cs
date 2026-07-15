public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if (!(side1 + side2 >= side3) ||
            !(side2 + side3 >= side1) ||
            !(side1 + side3 >= side2))
            return false;

        if ((side1 != side2) && (side1 != side3) && (side2 != side3))
            return true;

        return false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if (IsScalene(side1, side2, side3))
            return false;

        if (IsEquilateral(side1, side2, side3))
            return false;

        return true;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if (IsScalene(side1, side2, side3))
            return false;

        if ((side1 == side2) && (side2 == side3))
            return true;

        return false;
    }
}