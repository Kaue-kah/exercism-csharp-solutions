using System.Runtime.InteropServices.Swift;

public class SpaceAge
{

    private int _seconds;
    
    public SpaceAge(int seconds)
    {
        this._seconds = seconds;
    }

    public double OnEarth()
    {
        return (double) _seconds / 31557600;
    }

    public double OnMercury()
    {
        return (double) OnEarth() / 0.2408467;
    }

    public double OnVenus()
    {
        return (double) OnEarth() / 0.61519726;
    }

    public double OnMars()
    {
        return (double) OnEarth() / 1.8808158;
    }

    public double OnJupiter()
    {
        return (double) OnEarth() / 11.862615;
    }

    public double OnSaturn()
    {
        return (double) OnEarth() / 29.447498;
    }

    public double OnUranus()
    {
        return (double) OnEarth() / 84.016846;
    }

    public double OnNeptune()
    {
        return (double) OnEarth() / 164.79132;
    }
}