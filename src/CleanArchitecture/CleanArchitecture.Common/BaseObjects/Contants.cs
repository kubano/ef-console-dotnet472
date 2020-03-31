using System.Collections.Generic;

namespace CleanArchitecture.Common
{
    public static class AppSettings
    {
        // to avoid magic numbers
        public const int HAS_MAXLENGHT2 = 2;

        public const int HAS_MAXLENGHT5 = 5;
        public const int HAS_MAXLENGHT12 = 12;
        public const int HAS_MAXLENGHT24 = 24;
        public const int HAS_MAXLENGHT48 = 48;
        public const int HAS_MAXLENGHT64 = 64;
        public const int HAS_MAXLENGHT96 = 96;
        public const int HAS_MAXLENGHT128 = 128;
        public const int HAS_MAXLENGHT256 = 256;
        public const int HAS_MAXLENGHT512 = 512;
        public const int HAS_MAXLENGHT1024 = 1024;
        public const int HAS_MAXLENGHT2048 = 2048;
        public const int HAS_MAXLENGHT450 = 450; // to match with main entity ApplicationUser.Id = nvarchar(450)

        public const int HAS_DECIMALS18 = 18;
        public const int HAS_DECIMALS2 = 2;

        public const string TRANSACTION_SUCCESS = "SUCCESS: Your form was successfully saved!";
        public const string TRANSACTION_ERROR = "ERROR: An error happened when saving your data, the Web Team was notified!";
        public const string TRANSACTION_WARNING = "WARNING: Validation Errors were found in our form, check fields and submit again.";
    }
}