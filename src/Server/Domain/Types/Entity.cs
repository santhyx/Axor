namespace Domain.Types
{
    public abstract class Entity
    {
        public Guid Id { get; protected init; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
