namespace TouristAgency.Infrastructure.Data.ValidationConstants
{
    public static class BookingConstants
    {
        public const int DiscriminatorMaxLength = 50;

        public const string TotalPriceMinValue = "0.00";
        public const string TotalPriceMaxValue = "1000000000000.00";

        public const int BookingStatusMinValue = 1;
        public const int BookingStatusMaxValue = 4;

        public const int PaymentStatusMinValue = 1;
        public const int PaymentStatusMaxValue = 2;
    }
}
