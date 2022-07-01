Feature: Forgot_User_Data

    Scenario: Click Forgot your Account Number
        Given user clicks on the "ForgotAccountNumber" in the "LoginScreen" screen
        Then user verifies Account retrieval screen

    Scenario: Click Forgot your PIN
        Given user click Back button
        Given user clicks on the "ForgotPin" in the "LoginScreen" screen
        Then user verifies Pin reset screen
