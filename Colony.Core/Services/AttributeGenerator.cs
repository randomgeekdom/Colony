using Colony.Core.Domain;

namespace Colony.Core.Services
{
    public class AttributeGenerator : IAttributeGenerator
    {
        private readonly Random _random = new();
        public Sex GenerateRandomSex()
        {
            // https://pubmed.ncbi.nlm.nih.gov/12476264/
            // Percentage of population that is intersex = 0.018%
            double intersexProbability = 0.00018;
            if (_random.NextDouble() < intersexProbability)
            {
                return Sex.Other;
            }
            return _random.Next(2) == 0 ? Sex.Male : Sex.Female;
        }
    }
}