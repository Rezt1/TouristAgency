namespace TouristAgency.Infrastructure.Data.ValidationConstants
{
    public static class CruiseConstants
    {
        public const int NameMinLength = 2;
        public const int NameMaxLength = 150;

        public const int DescriptionMinLength = 20;
        public const int DescriptionMaxLength = 400;

        public const string PriceMinValue = "0.00";
        public const string PriceMaxValue = "1000000000000.00";

        public const int MinPeopleNeededMinValue = 0;
        public const int MinPeopleNeededMaxValue = int.MaxValue;

        public const int MaxPeopleMinValue = 0;
        public const int MaxPeopleMaxValue = int.MaxValue;
    }
}
