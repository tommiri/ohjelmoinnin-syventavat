﻿namespace harj_20;

public class City
{
    public string Name;
    public Coordinates Location;

    public City(string name, Coordinates location)
    {
        Name = name;
        Location = location;
    }

    public override string ToString()
    {
        return string.Format("{0} @ {1}, {2}", Name, Location.Latitude, Location.Longitude);
    }

    public double DistanceTo(City other)
    {
        return this.Location.DistanceTo(other.Location);
    }
}