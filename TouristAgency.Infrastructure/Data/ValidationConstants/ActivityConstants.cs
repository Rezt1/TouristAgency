namespace TouristAgency.Infrastructure.Data.ValidationConstants
{
    public static class ActivityConstants
    {
        public const int NameMinLength = 2;
        public const int NameMaxLength = 60;

        public const int DescriptionMinLength = 40;
        public const int DescriptionMaxLength = 800;

        public const string PriceMinValue = "0.00";
        public const string PriceMaxValue = "1000000000000.00";

        public const int MinPeopleNeededMinValue = 0;
        public const int MinPeopleNeededMaxValue = int.MaxValue;
    }
}
