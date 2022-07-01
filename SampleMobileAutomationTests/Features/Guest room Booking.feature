Feature: Guest_room_Booking

    Background:
        Given user click on "RoomButton" at the bottom menu
        Given user skip user guid for "Rooms" screen

    Scenario: Verify Rooms screen view
        Then user verifies rooms screen view

    Scenario: Create a bokking
        Given user generates the date bigger than today on "11" "days" and save to "checkInDate"
        And user generates the date bigger than today on "12" "days" and save to "checkOutDate"
        Given user select check-in date "checkInDate"
        And user select check-out date "checkOutDate"
        And user selects the number of rooms "1"
        Given user clicks on the "DialogButtonOk" in the "Dialog" screen
        And user selects the number of adults "2"
        Given user clicks on the "DialogButtonOk" in the "Dialog" screen
        And user selects the number of children "1"
        Given user clicks on the "DialogButtonOk" in the "Dialog" screen
        When user search rooms and click book
        Then user verifies Your details screen
        Given user fill Your details form with following data:
          | Field              | Value              |
          | PhoneNumber        | 380670000000       |
          | Email              | test@automation.ui |
          | CountryOfResidence | Philippines        |
        Given user skip user guid for "Additional Services" screen
        Then user "skip" additional services
        Then user verifies summary screen with following data:
          | Field        | Value        |
          | CheckInDate  | checkInDate  |
          | CheckOutDate | checkOutDate |
          | Adults       | 2            |
          | Children     | 1            |
        Given user clicks on the "ConfirmButton" in the "SummaryScreen" screen
        Given user skip user guid for "Payment" screen
        Given user clicks on the "AddNewCardSection" in the "PaymentScreen" screen
        Given user fill payment form with following data:
          | Field           | Value            |
          | CardNumber      | 3562000011112222 |
          | NameOnCard      | UI Automation    |
          | BillingAddress  | test             |
          | City            | test             |
          | StateProvince   | test             |
          | PostalZipCode   | 49000            |
          | ExpirationMonth | Jul              |
          | ExpirationYear  | 2026             |
        Then user verifies confirmation message with "confirmation number is"

    Scenario: Verify TERMS AND CONDITIONS
        When user search rooms and click book
        Given user clicks on the "TermAndConditionLink" in the "YourDetailsScreen" screen
        Then user verifies term and condition header "Terms and Conditions"

    Scenario: Verify additional services
        When user search rooms and click book
        Given user fill Your details form with following data:
          | Field       | Value              |
          | PhoneNumber | 380670000000       |
          | Email       | test@automation.ui |
        Then user verifies additional services screen

    Scenario: Verify Data privacy and Security policy
        When user search rooms and click book
        Given user fill Your details form with following data:
          | Field       | Value              |
          | PhoneNumber | 380670000000       |
          | Email       | test@automation.ui |
        Given user skip user guid for "Additional Services" screen
        Then user "skip" additional services
        Given user clicks on the "ConfirmButton" in the "SummaryScreen" screen
        Given user skip user guid for "Payment" screen
        Given user clicks on the "DataPrivacyAndSecurityPolicy" in the "PaymentScreen" screen
        Then user verifies term and condition header "PRIVACY POLICY"

    Scenario: Verify that user not be able to choose more than 5 rooms
        Given user selects the number of rooms "6"
        Then user verifies error message "If you are Booking 6 rooms or more, reservations will be personally arranged by our staff through email or phone."

    Scenario: Verify that user not be able to choose more than 10 adults
        Given user selects the number of rooms "5"
        Given user clicks on the "DialogButtonOk" in the "Dialog" screen
        And user selects the number of adults "11"
        Then user verifies error message "You can select max 10 Adults."

    Scenario: Verify that user not be able to choose more than 2 children
        Given user selects the number of children "3"
        Then user verifies error message "You can select max  2 Children"

    Scenario: Verify that 1 room can only accommodate 2 adults, 2 children
        Given user selects the number of rooms "1"
        Given user clicks on the "DialogButtonOk" in the "Dialog" screen
        And user selects the number of adults "3"
        Given user clicks on the "DialogButtonOk" in the "Dialog" screen
        And user selects the number of children "2"
        Given user clicks on the "DialogButtonOk" in the "Dialog" screen
        Given user clicks on the "SearchRoomsButton" in the "RoomsScreen" screen
        Then user verifies dialog message "The number of rooms you have selected can only accommodate 2 adults comfortably. Would you like to proceed with 2 rooms?"
        Given user clicks on the "DialogButtonCancel" in the "Dialog" screen

    Scenario: Verify that user is not able fill Your details form without requiered fields
        When user search rooms and click book
        Given user fill Your details form with following data:
          | Field | Value              |
          | Email | test@automation.ui |
        Then user verifies error message "Please enter valid phone number"
        Given user fill Your details form with following data:
          | Field       | Value        |
          | PhoneNumber | 380670000000 |
        Then user verifies error message "Please enter valid email address"

    Scenario: Verify that user is not able fill Payment form with invalid data
        When user search rooms and click book
        Given user fill Your details form with following data:
          | Field       | Value              |
          | PhoneNumber | 380670000000       |
          | Email       | test@automation.ui |
        Given user skip user guid for "Additional Services" screen
        Then user "skip" additional services
        Given user clicks on the "ConfirmButton" in the "SummaryScreen" screen
        Given user skip user guid for "Payment" screen
        Given user clicks on the "AddNewCardSection" in the "PaymentScreen" screen
        Given user fill payment form with following data:
          | Field           | Value            |
          | CardNumber      | 0000000011112222 |
          | NameOnCard      | UI Automation    |
          | BillingAddress  | test             |
          | City            | test             |
          | StateProvince   | test             |
          | PostalZipCode   | 49000            |
          | ExpirationMonth | Jul              |
          | ExpirationYear  | 2026             |
        Then user verifies error message "This card is not supported,Please enter valid card details."
        Given user fill payment form with following data:
          | Field           | Value            |
          | CardNumber      | 3562000011112222 |
          | BillingAddress  | test             |
          | City            | test             |
          | StateProvince   | test             |
          | PostalZipCode   | 49000            |
          | ExpirationMonth | Jul              |
          | ExpirationYear  | 2026             |
        Then user verifies error message "Please enter card holder name"
        Given user fill payment form with following data:
          | Field           | Value            |
          | CardNumber      | 3562000011112222 |
          | NameOnCard      | UI Automation    |
          | City            | test             |
          | StateProvince   | test             |
          | PostalZipCode   | 49000            |
          | ExpirationMonth | Jul              |
          | ExpirationYear  | 2026             |
        Then user verifies error message "Please enter billing address"
        Given user fill payment form with following data:
          | Field           | Value            |
          | CardNumber      | 3562000011112222 |
          | NameOnCard      | UI Automation    |
          | BillingAddress  | test             |
          | StateProvince   | test             |
          | PostalZipCode   | 49000            |
          | ExpirationMonth | Jul              |
          | ExpirationYear  | 2026             |
        Then user verifies error message "Please provide City of residence"

    Scenario: Verify that user able to click and view “Other Packages”
        Given user clicks on the "SearchPackagesButton" in the "RoomsScreen" screen
        Given user skip user guid for "Search Package" screen
        And user clicks on the "OtherPackageButton" in the "SearchPackageScreen" screen
        Then user verifies that screen title is "Room Type"

    Scenario: Verify that user able to click and view “Features”
        Given user clicks on the "SearchPackagesButton" in the "RoomsScreen" screen
        Given user skip user guid for "Search Package" screen
        And user clicks on the "FeaturesButton" in the "SearchPackageScreen" screen
        Then user verifies that screen title is "Features"

    Scenario: Verify that user able to click and view “Rate Details”
        Given user clicks on the "SearchPackagesButton" in the "RoomsScreen" screen
        Given user skip user guid for "Search Package" screen
        And user clicks on the "RateDetailsButton" in the "SearchPackageScreen" screen
        Then user verifies that screen title is "Rate Details"