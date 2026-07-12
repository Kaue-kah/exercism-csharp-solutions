class Lasagna
{

    public int lasagnaMinutes = 40;


    public int ExpectedMinutesInOven()
    {
        return lasagnaMinutes;
    }

    public int RemainingMinutesInOven(int timePass)
    {
        return lasagnaMinutes - timePass;
    }

    public int PreparationTimeInMinutes(int qtLasagnas)
    {
        return qtLasagnas * 2;
    }

    public int ElapsedTimeInMinutes(int qtLayers, int minutes)
    {
        return (qtLayers * 2) + minutes;
    }

    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}
