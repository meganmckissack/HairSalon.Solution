#### By _**Megan McKissack**_

## Description

An MVC app for a salon owner to manage their stylist's and clients. Data is stored in an SQL database using a one to many model.

## Technologies Used

- _C#_
- _.NET 5_
- _ASP.NET Core MVC_
- _MySQL_
- _Entity Framework Core_
- _HTML_
- _CSS_

Database schema
![database schema](/schema-img.png)

## Setup/Installation Requirements

### File and Package installation

- using your terminal, clone or download this repository to your computer
- Open files in your favorite text editor or IDE
- cd into the HairSalon.Solution/HairSalon folder and run the command `dotnet restore` to install the necessary packages to run the program

### Database Setup

- to connect the app to the database you'll need to have [MySQL](https://dev.mysql.com/doc/mysql-installation-excerpt/5.7/en/) and [MySQL Workbench](https://www.mysql.com/products/workbench/) installed.
- select _Data Import/Restore_ in the Admistration menu in MySQL Workbench.
- then select the _Import from Self-Contatained File_ option in Import Options
- then in the _Default Schema to be Imported to_ option, select the _New_ button and enter the database file, included in this repo, titled `megan_mckissack.sql` and click ok
- navigate to the _Import Progress_ tab and click the _Start Import_ button at the bottom right corner of the window
- to verify the database import, navigate to the Schemas tab, right click and select the option _Refresh All_, the new database name should show up in the list of databases

### Connecting the Database to the App

- in your local repository, create a `appsettings.json` in the main project folder `HairSalon` to store your database login so that app can connect to the database and retrieve/add information
  - then add this code to the file:
    `{ "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=megan_mckissack;uid=[YOUR-USER-ID];pwd=[YOUR-PASSWORD-HERE];" } }`
- also update your `.gitignore` file with `*/appsettings.json` so that you don't accidently make your database login information public if you push your projected to a remote repository

### Interacting with the app

- To view and use the application, navigate to the `HairSalon` folder and use the command `dotnet run` to start your local server and navigate to [http://localhost:5000](http://localhost:5000) in your web browser and interact with the application

## Known Bugs

_none_

## License

_MIT_

Copyright (c) _July 27, 2022_ _Megan McKissack_
