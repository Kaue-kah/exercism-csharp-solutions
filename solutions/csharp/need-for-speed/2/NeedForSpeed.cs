class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int _batteryDrain;
    private int _speed;
    private int _battery;
    private int _distanceDriven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
        this._battery = 100;
        this._distanceDriven = 0;
    }

    public bool BatteryDrained()
    {
        if (_battery - _batteryDrain < 0)
        {
            return true;
        }
        return false;
    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if (this.BatteryDrained() == false)
        {
            _battery -= _batteryDrain;
            _distanceDriven += _speed;
        }
        
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance)
    {
        this._distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        
        while (_distance > car.DistanceDriven())
        {
            if (car.BatteryDrained())
            {
                return false;
            }
            car.Drive();
        }

        return true;

    }
}
