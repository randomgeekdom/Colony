using Colony.Core.Domain;
using RandomNameGeneratorLibrary;

namespace Colony.Core.Services
{
    public class NameGenerator : INameGenerator
    {
        private readonly PersonNameGenerator _personNameGenerator = new();

        public string GenerateFirstName(Sex sex)
        {
            return sex switch
            {
                Sex.Male => _personNameGenerator.GenerateRandomMaleFirstName(),
                Sex.Female => _personNameGenerator.GenerateRandomFemaleFirstName(),
                _ => _personNameGenerator.GenerateRandomFirstName(),
            };
        }

        public string GenerateLastName()
        {
            return _personNameGenerator.GenerateRandomLastName();
        }
    }
}