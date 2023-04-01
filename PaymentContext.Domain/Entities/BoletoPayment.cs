using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(DateTime paiDate, 
                             DateTime expireDate, 
                             decimal total, 
                             decimal totalPaid, 
                             Address address, 
                             Document document, 
                             string? payer, 
                             Email email, 
                             string? barCode = null, 
                             string? boletoNumber = null)
        : base(paiDate, expireDate, total, totalPaid, address, document, payer, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string? BarCode { get; private set; }
        public string? BoletoNumber { get; private set; }
    }
}