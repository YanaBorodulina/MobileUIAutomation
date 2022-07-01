using Sample.Mobile.Core;

namespace SampleMobileAutomationTests.Pages
{
    public class PaymentSelectors
    {
        public static string YourCardSection => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_your_cards";
        public static string AddNewCardSection => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_add_card";
        public static string CardNumberFiled => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_card_number";
        public static string NameOnCardField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_name_on_card";
        public static string ExpirationMonthDropDown => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/spinner_month";
        public static string ExpirationYearDropDown => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/spinner_year";
        public static string BillingAddressFiled => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_billing_address";
        public static string CityField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_city";
        public static string StateProvinceField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_state";
        public static string PostalZipCodeField => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/edt_zip_code";
        public static string SaveCardCheckBox => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/check_save_card";
        public static string CompleteReservationButton => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/btn_save_and_pay";
        public static string DataPrivacyAndSecurityPolicy => TestConfig.PlatformName == "IOS" ? "" : "com.solaireresort.mysolairemobileapp:id/txt_terms_and_conditions";
        
    }
}