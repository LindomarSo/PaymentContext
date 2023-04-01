namespace PaymentContext.Shared.Entities
{
    // UMA ENTIDADE SEMPRE TERÁ UM ID 
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}