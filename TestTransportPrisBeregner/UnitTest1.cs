using TranportPrisBeregner;

namespace TestTransportPrisBeregner
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 10, 100)]
        [InlineData(4, 9, 0)]
        [InlineData(5, 9, 75)]
        [InlineData(6,9, 75)]
        [InlineData(4, 10, 50)]
        [InlineData(4, 11, 50)]
        public void Can_calculate_shipping_price(int afstand, int vaegt, int expectedResult)
        {
            // Arrange
            TransportPrisBeregner sut = new TransportPrisBeregner();
            // Act
            int price = sut.TransportBeregner(afstand, vaegt);
            // Assert
            Assert.Equal(expectedResult, price);
        }
    }
}