namespace Colony.Core.Domain
{
    public record Person : Entity
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public Sex Sex { get; set; }
        public byte Age { get; set; }
    }
}