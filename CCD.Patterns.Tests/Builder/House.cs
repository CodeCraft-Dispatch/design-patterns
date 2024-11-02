using System;

namespace CCD.Patterns.Tests.Builder;

public class House
{
    public int Rooms { get; set; }
    public int Doors { get; set; }
    public int Windows { get; set; }
    public bool HasGarage { get; set; }

    public override string ToString()
    {
        return $"House with {Rooms} rooms, {Doors} doors, {Windows} windows, " +
               $"and {(HasGarage ? "a garage" : "no garage")}.";
    }
}
