using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    // UM VALUE OBJECT NÁO TERÁ UM ID, PORQUE NÁO SERÁ UMA ENTIDADE NO FIM DAS CONTAS
    public class Name : ValueObject
    {
        public Name(string? firstName, string? lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
    }
}