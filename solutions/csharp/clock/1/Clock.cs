public class Clock : IEquatable<Clock>
{
    int hours;
    int minutes;

    public Clock(int hours, int minutes)
    {
        int total = ((hours * 60 + minutes) % 1440 + 1440) % 1440;
        this.hours = total / 60;
        this.minutes = total % 60;
    }

    public override string ToString()
    {
        return $"{hours:D2}:{minutes:D2}";
    }

    public Clock Add(int minutesToAdd)
    {
        return new Clock(hours, minutes + minutesToAdd);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        return Add(-minutesToSubtract);
    }

    public bool Equals(Clock other)
    {
        if (other == null) return false;

        return hours == other.hours &&
               minutes == other.minutes;
    }

}
