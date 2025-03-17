using Ardalis.Result;

namespace Colony.Core.Domain
{
    public record Settlement : Entity
    {
        public required string Name { get; set; }
        public ISet<Person> Population { get; set; } = new HashSet<Person>();
    }
}