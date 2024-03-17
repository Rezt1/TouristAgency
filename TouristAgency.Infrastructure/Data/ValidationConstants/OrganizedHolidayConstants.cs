namespace TouristAgency.Infrastructure.Data.ValidationConstants
{
    public static class OrganizedHolidayConstants
    {
        public const string PriceMinValue = "0.00";
        public const string PriceMaxValue = "1000000000000.00";

        public const int MinPeopleNeededMinValue = 0;
        public const int MinPeopleNeededMaxValue = int.MaxValue;

        public const int MaxPeopleMinValue = 0;
        public const int MaxPeopleMaxValue = int.MaxValue;

        public const int DayOneDescrpiptionMinValue = 20;
        public const int DayOneDescrpiptionMaxValue = 800;

        public const int LastDayDescriptionMinValue = 20;
        public const int LastDayDescriptionMaxValue = 800;
    }
}
