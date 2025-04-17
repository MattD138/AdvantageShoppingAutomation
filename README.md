# Advantage Shopping Automation

## Overview

The **Advantage Shopping Automation Framework** is a scalable and maintainable test automation framework built using:

- **C#** with **.NET 8**
- **Selenium WebDriver** for browser automation
- **NUnit** for test execution and assertions

This framework follows the **Page Object Model (POM)** design pattern to ensure separation of concerns, reusability, and ease of maintenance.

## Features

- **Page Object Model (POM)**: Encapsulates page-specific logic in dedicated classes.
- **Reusable Wait Helpers**: Provides utility methods for waiting on elements, ensuring robust and reliable tests.
- **Externalized Test Data**: Test data is stored in JSON files for flexibility and scalability.
- **Logging**: Logs actions and waits for better debugging and traceability.
- **Cross-Browser Support**: Compatible with multiple browsers via Selenium WebDriver.

## Project Structure

```
AdvantageShoppingAutomation/
├── Pages/                   # Page Object Model classes
│   ├── BasePage.cs          # Base class for common page functionality
│   ├── HomePage.cs          # Represents the home page
│   ├── RegistrationPage.cs  # Represents the registration page
├── Tests/                   # Test classes
│   ├── BaseTest.cs          # Base class for test setup and teardown
│   ├── RegistrationTests.cs # Test cases for registration functionality
├── Utilities/               # Utility classes
│   ├── WaitHelper.cs        # Helper methods for waiting on elements
├── TestData/                # Test data files
│   ├── TestConfig.json      # Configuration data
│   ├── UserData.json        # User data for tests
├── AdvantageShoppingAutomation.csproj # Project file
```

## Setup Instructions

1. **Clone the Repository**:

```
  git clone https://github.com/MattD138/AdvantageShoppingAutomation.git
  cd AdvantageShoppingAutomation
```

2. **Install Dependencies**:
   Ensure you have the following installed:

   - .NET 8 SDK

3. **Restore NuGet Packages**:
   Run the following command to restore dependencies:

```
  dotnet restore
```

4. **Configure Test Data**:
   Update the `TestData/TestConfig.json` and `TestData/UserData.json` files with the appropriate values for your environment.

5. **Run Tests**:
   Execute the tests using the following command:

```
  dotnet test
```
