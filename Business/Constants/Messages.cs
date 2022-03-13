using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car added.";
        public static string BrandAdded = "Brand added.";
        public static string ColorAdded = "Color added.";

        public static string CarsListed = "Cars listed.";
        public static string BrandsListed = "Brands listed.";
        public static string ColorsListed = "Colors listed.";
        
        public static string CarUpdated = "Car's information updated.";
        public static string BrandUpdated = "Brand's information updated.";
        public static string ColorUpdated = "Color's information updated.";

        public static string CarRemoved = "Car has been removed.";
        public static string BrandRemoved = "Brand has been removed.";
        public static string ColorRemoved = "Color has been removed.";

        public static string CarNameInvalid = "Car's name must be at least 2 characters.";
        public static string DailyPriceInvalid = "Daily price must be higher than 0";
        
        public static string MaintenanceTime = "Server is under maintenance. Try again later.";
    }
}
