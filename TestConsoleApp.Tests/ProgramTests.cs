using TestConsoleApp;
using Xunit;
using System.Reflection;

namespace TestConsoleApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Constructor_SetsValueCorrectly()
        {
            // Arrange
            int expected = 123;

            // Act
            var program = new Program(expected);

            // Assert (using reflection to access protected field)
            var field = typeof(Program).GetField("value", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            Assert.NotNull(field);
            int actual = (int)field.GetValue(program)!;
            Assert.Equal(expected, actual);
        }
    }
}
