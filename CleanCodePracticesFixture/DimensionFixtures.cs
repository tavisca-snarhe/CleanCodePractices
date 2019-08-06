using CleanCodePractices;
using Xunit;

namespace CleanCodePracticesFixture
{
    public class DimensionFixtures
    {
        Dimension dimension;
        [Fact]
        public void Dimension_Constructor_Should_Set_Height_Test()
        {
            dimension = new Dimension(12, 34);
            Assert.Equal(12, dimension.Height);
        }

        [Fact]
        public void Dimension_Constructor_Should_Set_Width_Test()
        {
            dimension = new Dimension(12, 34);
            Assert.Equal(34, dimension.Width);
        }

        [Fact]
        public void Change_Should_Change_Height_Test()
        {
            dimension = new Dimension(12, 34);
            dimension.Change(40, 20);
            Assert.Equal(40, dimension.Height);
        }

        [Fact]
        public void Change_Should_Change_Width_Test()
        {
            dimension = new Dimension(12, 34);
            dimension.Change(40, 20);
            Assert.Equal(20, dimension.Width);
        }
    }
}