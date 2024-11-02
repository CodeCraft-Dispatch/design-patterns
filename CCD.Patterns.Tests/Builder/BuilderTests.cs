using System.Text;

namespace CCD.Patterns.Tests.Builder;

public class BuilderTests
{
    [Fact]
    public void ShouldProvideDefaultConstructedObject()
    {
        // Arrange
        var builder = new Builder<object>();

        // Act
        var result = builder.Build();

        // Assert
        Assert.NotNull(result);
    }

    [Fact]
    public void ShouldProvideDefaultConstructedGuid()
    {
        // Arrange
        var builder = new GuidBuilder();

        // Act
        var result = builder.Build();

        // Assert
        Assert.NotEqual(Guid.Empty, result);
    }

    [Fact]
    public void ShouldProvideCustomConstructedString()
    {
        // Arrange
        var builder = new CustomStringBuilder();

        // Act
        var result = builder.Append("Hello, ").Append("World!").Build();

        // Assert
        Assert.Equal("Hello, World!", result);
    }

    public class GuidBuilder : Builder<Guid>
    {
        protected override Guid CreateInstance()
        {
            return Guid.NewGuid();
        }
    }

    public class CustomStringBuilder : Builder<string>
    {
        private readonly StringBuilder _builder;

        public CustomStringBuilder()
        {
            _builder = new StringBuilder();
        }

        protected override string CreateInstance()
        {
            return string.Empty;
        }

        public CustomStringBuilder Append(string value)
        {
            _builder.Append(value);
            return this;
        }

        public override string Build()
        {
            return _builder.ToString();
        }
    }

}

