//https://exercism.org/tracks/csharp/exercises/space-age
using System;

public class SpaceAge
{

    private double ageSeconds;
    
    public SpaceAge(int seconds)
    {
        ageSeconds = seconds;
    }

    public double OnEarth()
    {
        return ageSeconds / 31557600;
    }

    public double OnMercury()
    {
        return OnEarth()/0.2408467;
    }

    public double OnVenus()
    {
        return OnEarth()/ 0.61519726;
    }

    public double OnMars()
    {
        return OnEarth() / 1.8808158;
    }

    public double OnJupiter()
    {
        return OnEarth()/ 11.862615;
    }

    public double OnSaturn()
    {
        return OnEarth() / 29.447498;
    }

    public double OnUranus()
    {
        return OnEarth() / 84.016846;
    }

    public double OnNeptune()
    {
        return OnEarth() / 164.79132;
    }
}