using System;

namespace CCD.Patterns.Tests.Builder;

public class HouseBuilder : IHouseBuilder
{
    private readonly House _house;

    public HouseBuilder()
    {
        _house = new House();
    }

    public IHouseBuilder WithRooms(int number)
    {
        _house.Rooms = number;
        return this;
    }

    public IHouseBuilder WithDoors(int number)
    {
        _house.Doors = number;
        return this;
    }

    public IHouseBuilder WithWindows(int number)
    {
        _house.Windows = number;
        return this;
    }

    public IHouseBuilder WithGarage(bool hasGarage)
    {
        _house.HasGarage = hasGarage;
        return this;
    }

    public House Build()
    {
        return _house;
    }
}