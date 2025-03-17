namespace Colony.Core.Domain
{
    public abstract record Entity 
    {
        public Guid Id { get; set;  } = Guid.NewGuid();
    }
}