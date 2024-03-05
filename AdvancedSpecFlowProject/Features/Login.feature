Feature: Login functionality
    
    @GUI
    Scenario: Successful Login
        Given open the login page
        When user enter "jonirz55@gmail.com" to the email field
        * user enter "Qwerty12345." password field
        * user click the log in button
        Then user is successful logged in
        
    @GUI
    Scenario: Incorrect email
        Given open the login page
        When user enter "jonirz5@gmail.com" to the email field
        * user enter "Qwerty12345." password field
        * user click the log in button
        Then error "Email/Login or Password is incorrect. Please try again." is displayed
    
    @GUI    
    Scenario: Incorrect password
        Given open the login page
        When user enter "jonirz55@gmail.com" to the email field
        * user enter "werty12345." password field
        * user click the log in button
        Then error "Email/Login or Password is incorrect. Please try again." is displayed