class RemoteControlCar
{
    public int CarBattery = 100;
    public int MetersTraveled = 0;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {MetersTraveled} meters";
    }

    public string BatteryDisplay()
    {
        if (CarBattery > 0)
        {
            return $"Battery at {CarBattery}%";
        }
        else
        {
            return "Battery empty";
        }
        
    }

    public void Drive()
    {
        if (CarBattery > 0){
            MetersTraveled += 20;
            CarBattery -= 1;
        }
    }
}
