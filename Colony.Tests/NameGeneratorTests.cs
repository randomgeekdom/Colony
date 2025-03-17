
using Colony.Core.Domain;
using Colony.Core.Services;

namespace Colony.Tests
{
    public class NameGeneratorTests
    {
        private NameGenerator _sut = new NameGenerator();

        [Theory]
        [InlineData(Sex.Male)]
        [InlineData(Sex.Female)]
        [InlineData(Sex.Other)]
        public void GenerateFirstName_ReturnsName(Sex sex)
        {
            var result = _sut.GenerateFirstName(sex);
            Assert.NotNull(result);
        }
    }
}
