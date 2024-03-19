namespace TouristAgency.Infrastructure.Data.ValidationConstants
{
    public class PaymentConstants
    {
        public const string AmountMinValue = "0";
        public const string AmountMaxValue = "1000000000000.00";

        public const int PaymentMethodMinValue = 1;
        public const int PaymentMethodMaxValue = 2;
    }
}
