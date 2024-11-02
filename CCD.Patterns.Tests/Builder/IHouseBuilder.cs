using System;

namespace CCD.Patterns.Tests.Builder;

public interface IHouseBuilder
{
    IHouseBuilder WithRooms(int number);
    IHouseBuilder WithDoors(int number);
    IHouseBuilder WithWindows(int number);
    IHouseBuilder WithGarage(bool hasGarage);
    House Build();
}
