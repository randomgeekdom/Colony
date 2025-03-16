namespace Colony.Core.Dtos
{
    public record ColonyDto
    {
        public string Name { get; set; }
        public uint Year { get; set; }

        public static ColonyDto FromEntity(Colony colony) =>
            new()
            { Name = colony.Name, Year = colony.Year };

        public Colony ToEntity() => Colony.TryCreate(Name).Value; // Handle errors appropriately
    }
}