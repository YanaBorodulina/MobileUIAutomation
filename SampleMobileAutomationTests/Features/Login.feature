Feature: Login

    Scenario:5 Login with valid data
        Given user login to app with following data:
          | Field      | Value     |
          | UserNumber | 300912907 |
          | Pin        | 2022      |
        Then user verifies that home screen opened

    Scenario:4 Login with invalid Pin
        Given user login to app with following data:
          | Field      | Value     |
          | UserNumber | 300912907 |
          | Pin        | 0000      |
        Then user verifies inline message "Invalid Pin"

    Scenario:3 Login with invalid Number
        Given user login to app with following data:
          | Field      | Value     |
          | UserNumber | 000000000 |
          | Pin        | 2022      |
        Then user verifies inline message "Patron Number not Found"
        Given user login to app with following data:
          | Field      | Value  |
          | UserNumber | 000.21 |
          | Pin        | 2022   |
        Then user verifies inline message "Please enter valid Account Number and PIN"

    Scenario:2 Login without required field
        Given user login to app with following data:
          | Field | Value |
          | Pin   | 2022  |
        Then user verifies inline message "Please enter valid Account Number and PIN"
        Given user login to app with following data:
          | Field      | Value     |
          | UserNumber | 300912907 |
        Then user verifies inline message "Please enter valid Account Number and PIN"
        Given user login to app with following data:
          | Field      | Value |
          | UserNumber |       |
          | Pin        |       |
        Then user verifies inline message "Please enter valid Account Number and PIN"

    Scenario:1 Verify fields length
        Given user enters "1234567890" to the "UserNumberFiled" field on the "LoginScreen" screen
        Then user verifies that "11" characters are in the field "UserNumberFiled" on the "LoginScreen" screen
        Given user enters "12345" to the "PinField" field on the "LoginScreen" screen
        Then user verifies that "4" characters are in the field "PinField" on the "LoginScreen" screen
        
        Scenario: Test SMS
            Given user recive the SMS 
        
