using System;
using System.Security.Cryptography;

class RemoteControlCar
{
    private int Meters = 0;
    private int Battery = 100;

    public static RemoteControlCar Buy()
    {
        
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {Meters} meters";
    }

    public string BatteryDisplay()
    {
        switch (Battery == 0)
        {
            case true:
                return "Battery empty";
            case false:
                return $"Battery at {Battery}%";
        }
    }

    public void Drive()
    {
        switch (Battery == 0) 
        {
            case true:
                Meters = 2000;
                break;
            default:
                Meters += 20;
                Battery -= 1;
                break;
        }
    }
}
