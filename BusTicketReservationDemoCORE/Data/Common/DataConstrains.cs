namespace BusTicketReservationDemoCORE.Data.Common
{
    public static class DataConstrains
    {
        public static class BookingConstants
        {
            public const int BookingNumberMinLength = 5;
            public const int BookingNumberMaxLength = 10;
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1500;
        }

        public static class BusConstants
        {
            public const int ModelMinLength = 3;
            public const int ModelMaxLength = 30;
            public const int TypeMinLength = 3;
            public const int TypeMaxLength = 20;
            public const int RegNumberMinLength = 4;
            public const int RegNumberMaxLength = 10;
            public const int CapasityMin = 30;
            public const int CapasityMax = 60;
        }

        public static class BusOwnerConstants
        {
            public const int CompanyNameMinLength = 2;
            public const int CompanyNameMaxLength = 256;
            public const int VATMixLength = 9;
            public const int VATMaxLength = 15;
            public const int TownMaxLength = 256;
            public const int AddressMaxLength = 256;
            public const int PhoneMinLength = 10;
            public const int PhoneMaxLength = 15;
            public const int ContactPersonMaxLength = 256;
            public const int WebsiteMaxLength = 256;
            public const int DirectorNameMaxLength = 256;
        }

        public static class CustomerConstants
        {
            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 50;
            public const int LastNameMinLength = 3;
            public const int LastNameMaxLength = 50;
            public const int PhoneMinLength = 10;
            public const int PhoneMaxLength = 15;
            public const int AgeMixLength = 18;
            public const int AgeMaxLength = 100;
            public const int AddressMaxLength = 256;
            public const int TownMaxLength = 256;
        }

        public static class DestinationConstants
        {
            public const int StartTownMinLength = 3;
            public const int StartTownMaxLength = 256;
            public const int EndTownMinLength = 3;
            public const int EndTownMaxLength = 256;
        }

        public static class ScheduleConstants
        {
            public const int DurationMinLength = 10;
            public const int DuratonMaxLength = 600;
        }

        public static class SeatConstants
        {
            public const int NumberMinLength = 1;
            public const int NumberMaxLength = 60;
        }

        public static class TicketConstants
        {
            public const int AgeDiscountMinLength = 10;
            public const int AgeDiscountMaxLength = 50;
            public const int CommentMinLength = 10;
            public const int CommentMaxLength = 1500;
        }
    }
}
