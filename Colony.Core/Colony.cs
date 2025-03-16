using Ardalis.Result;

namespace Colony.Core
{
    public class Colony
    {
        private Colony(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
        public uint Year { get; } = 0;

        public static Result<Colony> TryCreate(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return Result.Error("Name is required");
            }

            return new Colony(name);
        }
    }
}