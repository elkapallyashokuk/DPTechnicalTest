# DPTechnicalTest
To run the tests using Selenium Page Object Model with SpecFlow in C#, you can follow these steps:

Install Git if not already installed.
Open a terminal and navigate to the desired directory.
Clone the repository using git clone https://github.com/elkapallyashokuk/DPTechnicalTest.git
Use git pull command to fetch and merge the latest changes.

Install Visual Studio: Download and install Visual Studio, which is an integrated development environment (IDE) for C#. You can download Visual Studio from the official Microsoft website.
Install Selenium WebDriver NuGet package: Right-click on your project in the Solution Explorer and select "Manage NuGet Packages". In the NuGet Package Manager, search for "Selenium.WebDriver" and install the package.
Install Selenium WebDriver ChromeDriver NuGet package: Similarly, search for "Selenium.WebDriver.ChromeDriver" and install this package if you plan to use Chrome as your browser.
Build the solution: Open your project in Visual Studio and build the solution to ensure that all the dependencies are resolved and the project compiles without errors.
Configure SpecFlow bindings: Open the App.config file in your project and add the necessary SpecFlow configuration settings. Specify the paths to your feature files and step definitions file in the <specFlow> section.
Open the Test Explorer: In Visual Studio, go to Test > Windows > Test Explorer. The Test Explorer window will open, displaying the available tests in your project.
Filter by tag: In the Test Explorer window, click on the "Filter" button (usually represented by a funnel icon) or use the shortcut Ctrl+T, F. This will open the filter options.
Enter the tag filter: In the filter options, enter @Sample in the search box or select the @Sample tag from the available tags list. This will filter the displayed tests to only show the ones marked with the @Sample tag.
Run tests: Once you find the desired test in the Test Explorer window, right-click on it and click the "Run" button to execute the test.
View test results: After running the tests, the Test Explorer window will display the results, indicating whether the test passed or failed. You can click on a test to view more detailed information about the test execution and any associated errors or exceptions.
Note: Remember to ensure that the appropriate WebDriver is properly configured in your tests to interact with the chosen browser (Chrome). You may need to specify the WebDriver path and other settings, depending on your test environment.

