using Ardalis.Result;
using Colony.Core.Services;

namespace Colony.Tests
{
    public class SettlementServiceTests 
    {
        [Fact]
        public void EstablishSettlement_ReturnsSettlement()
        {
            var nameGenerator = new NameGenerator();
            var attributeGenerator = new AttributeGenerator();
            var sut = new SettlementService(nameGenerator, attributeGenerator);
            var result = sut.EstablishSettlment("Test Settlement");
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Value);
            Assert.Equal("Test Settlement", result.Value.Name);
            Assert.Equal(10, result.Value.Population.Count);
        }

        [Fact]
        public void EstablishSettlement_WithEmptyName_ReturnsError()
        {
            var nameGenerator = new NameGenerator();
            var attributeGenerator = new AttributeGenerator();
            var sut = new SettlementService(nameGenerator, attributeGenerator);
            var result = sut.EstablishSettlment("");
            Assert.True(result.IsError());
            Assert.Contains("Name is required", result.Errors);
        }
    }
}
