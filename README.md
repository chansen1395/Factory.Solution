# Eau Claire's Salon

#### This web application utilizes a database to manage and display information for a hair salon.

#### By Connor Hansen

## Technologies Used

* C#
* .NET
* Razor
* HTML
* MySQL
* Linq
* Entity Framework

## Description

_This is an MVC web application to manage a hair salon's stylists and their clients. The user can add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see belong to a single stylist.._

## Setup/Installation Requirements

- _To clone and run from [GitHub Repo](https://github.com/chansen1395/HairSalon.Solution):_

- _Use a program such as VSCode to view, run, and test the program._
  
- _Database Setup:_

- Create a file named "appsettings.json" in the HairSalon directory
  * add the following code to the appsettings.json file:

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=connor_hansen;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
  * replace [YOUR-PASSWORD-HERE] with your unique MySql password
* Launch the MySql server:
  - In the terminal, run the command "$ mySql -uroot -p[YOUR-PASSWORD-HERE]", replacing [YOUR-PASSWORD-HERE] with your unique MySql password
* To Import the required database:
  - Open MySql Workbench
  - Select your preferred server(default is root)
  - In the "Navigator > Administration" window, select "Data Import/ Restore"
  - In "Import Options", select "Import From Self-Contained File"
  - Navigate to "HairSalon.Solutions/connor_hansen.sql" in the search input
  - Under "Default Schema to be Imported to" select the "New" button
  - Enter "best_restaurants" and click "OK"
  - Navigate to the "Import Progress" tab and click "Start Import" in the bottom right corner of the window
  - Reopen the "Navigator>Schemas" tab, Right click and select "refresh all" to see the imported database

- _In order to set up the project environment:_
  - _In bash at a folder of your choice, type the following:_
    1. $ git clone https://github.com/chansen1395/HairSalon.Solution.git
    2. $  code .
    3. Install packages if not already installed:
      i. $ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
      ii. $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
      iii. $ dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
    4. cd PROJECT/APPFOLDER
    5. $ dotnet restore
- _In order to run the program, follow along with the previous steps. After step 4, navigate to the HairSalon directory:_
    1. $ cd ..HairSalon
    2. $ dotnet watch run
    3. _Navigate to http://localhost:5000/ in your browser.

## Known Bugs

* _No Known Bugs._

## License

{Let me know if you run into any issues or have questions, ideas or concerns. I encourage you to contact me or make a contribution to the code.}

## Contact Information

- Connor Hansen: _{<chansen13@georgefox.edu>}_
- _{[GitHub Repo - main](https://github.com/chansen1395/HairSalon.Solution)}_