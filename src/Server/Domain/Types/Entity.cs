namespace Domain.Types
{
    public abstract class Entity : EquitableObject<Entity>
    {
        public Guid Id { get; protected init; }


        protected Entity()
        {
            Id = Guid.NewGuid();
        }


        public static bool operator ==(Entity? entity, Entity? anotherEntity)
            => CompareValues(entity, anotherEntity);

        public static bool operator !=(Entity? entity, Entity? anotherEntity)
            => !CompareValues(entity, anotherEntity);
    }
}
