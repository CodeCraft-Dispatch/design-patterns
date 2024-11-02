using System;

namespace CCD.Patterns.Tests.Builder;

public class HouseBuilderTests
{
    [Fact]
    public void ShouldReturnHouseWithSpecifiedRooms()
    {
        // Arrange
        var builder = new HouseBuilder();
        
        // Act
        House house = builder.WithRooms(3).Build();
        
        // Assert
        Assert.Equal(3, house.Rooms);
    }

    [Fact]
    public void ShouldReturnHouseWithSpecifiedDoors()
    {
        // Arrange
        var builder = new HouseBuilder();
        
        // Act
        House house = builder.WithDoors(2).Build();
        
        // Assert
        Assert.Equal(2, house.Doors);
    }

    [Fact]
    public void ShouldReturnHouseWithSpecifiedWindows()
    {
        // Arrange
        var builder = new HouseBuilder();
        
        // Act
        House house = builder.WithWindows(5).Build();
        
        // Assert
        Assert.Equal(5, house.Windows);
    }

    [Fact]
    public void ShouldReturnHouseWithGarage_WhenGarageIsSetToTrue()
    {
        // Arrange
        var builder = new HouseBuilder();
        
        // Act
        House house = builder.WithGarage(true).Build();
        
        // Assert
        Assert.True(house.HasGarage);
    }

    [Fact]
    public void ShouldReturnHouseWithoutGarage_WhenGarageIsSetToFalse()
    {
        // Arrange
        var builder = new HouseBuilder();
        
        // Act
        House house = builder.WithGarage(false).Build();
        
        // Assert
        Assert.False(house.HasGarage);
    }

    [Fact]
    public void ShouldReturnHouseWithAllSpecifiedProperties()
    {
        // Arrange
        var builder = new HouseBuilder();
        
        // Act
        House house = builder.WithRooms(3)
                             .WithDoors(2)
                             .WithWindows(5)
                             .WithGarage(true)
                             .Build();
        
        // Assert
        Assert.Equal(3, house.Rooms);
        Assert.Equal(2, house.Doors);
        Assert.Equal(5, house.Windows);
        Assert.True(house.HasGarage);
    }
}
