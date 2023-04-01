using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(DateTime paiDate, 
                                 DateTime expireDate, 
                                 decimal total, 
                                 decimal totalPaid, 
                                 Address address, 
                                 Document document, 
                                 string? payer, 
                                 Email email, 
                                 string? cardHolderNumber = null, 
                                 string? cardNumber = null, 
                                 string? lastTransactionNumber = null)
        : base(paiDate, expireDate, total, totalPaid, address, document, payer, email)
        {
            CardHolderNumber = cardHolderNumber;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string? CardHolderNumber { get; private set; }
        public string? CardNumber { get; private set; }
        public string? LastTransactionNumber { get; private set; }
    }
}