using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(DateTime paiDate, 
                             DateTime expireDate, 
                             decimal total, 
                             decimal totalPaid, 
                             Address address, 
                             Document document, 
                             string? payer, 
                             Email email, 
                             string? transactionCode)
        : base(paiDate, expireDate, total, totalPaid, address, document, payer, email)
        {
            TransactionCode = transactionCode;
        }

        public string? TransactionCode { get; private set; }
    }
}