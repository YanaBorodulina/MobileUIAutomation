namespace SampleMobileAutomationTests.Models
{
    public class PaymentModel
    {
        public string CardNumber { get; set; }
        public string NameOnCard { get; set; }
        public string BillingAddress { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalZipCode { get; set; }
        public string ExpirationMonth { get; set; }
        public string ExpirationYear { get; set; }
    }
}