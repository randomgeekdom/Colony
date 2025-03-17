using Colony.Core.Domain;

namespace Colony.Core.Services
{
    public interface IAttributeGenerator
    {
        Sex GenerateRandomSex();
    }
}