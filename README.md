
# **Eau Claire's Salon**

#### _This is an Independent Project at Epicodus using web application framework called ASP.NET Core MVC and Entity Framework Core._

#### Made By **Nitun Data_**
#### May 29, 2020

### Description

__A web application where the owner is able to add a list of the stylists, and for each stylist, add clients who see that stylist. The stylists work independently, so each client only belongs to a single stylist..__

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. Make sure that C#/.netcore2.2 is installed on your computer.  
4. For launching the program navigate to the _HairSalon_ directory and run _dotnet build_.
5. Next,run _dotnet run_ command in the same directory to to open a live server w/auto updated viewing.Then navigate to localhost:5000/.

#### If you need to install and configure MySQL:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)
5. Open Local instance 3306 with the password you set.
6. Within the BestRestaurant directory add your MySQL password to the appsettings.json file on line 3.
* "Server=localhost;Port=3306;database=nitun_datta;uid=root;pwd=YOURPASSWORDHERE;"
* Make any other changes needed if you have an alternative server, port, or uid selected. These are the default settings.

#### To create a local version of the database:
1. Open MySQL Workbench and Local Instance 3306.
2. Select the SQL + button in the top left of the navigation bar.
3. Paste the following in the query section to create the database:

CREATE DATABASE `nitun_datta` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `nitun_datta`

CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `StylistName` varchar(255) DEFAULT NULL,
  `StylistPhoneNum` varchar(45) DEFAULT NULL,
  `Experince` int DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `StylistId` int DEFAULT '0',
  `ClientName` varchar(255) DEFAULT NULL,
  `ClientPhoneNum` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `appointments` (
  `AppointmentId` int NOT NULL AUTO_INCREMENT,
  `StylistId` int DEFAULT NULL,
  `ClientId` int DEFAULT NULL,
  `AppointmentDate` varchar(50) DEFAULT NULL,
  `AppointmentTime` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`AppointmentId`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



4. Press the lightning bolt button to run this command.
5. If the database does not appear, right click in the schemas bar and select Refresh All.

### Known Bugs

No bugs have been identified at the time of this update.

### Support and Contact Information

Please contact me with any suggestions or questions at nitun.2@gmail.com. Thank you for your input!  

### Technologies Used

* C#
* ASP.NET Core
* ASP.NET Core MVC
* MySQL
* Entity Framework Core
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User enters home page** | User Input:"URL: localhost:5000/" | Output: “Welcome!” |
| **User can navigate to a Stylists Page** | User Input:"Click: View Stylists" | Output: “Name PhoneNumber Experience” |
| **If no Stylist have been added a message appears** | User Input:"Click: View Stylists" | Output: “You have no Stylists listed!” |
| **User can navigate to an Add Stylists Page** | User Input:"Click: Add Stylists" | Output: “Create a new Stylist.” |
| **User can fill out the Add Stylist Form** | User Input:"Enter New Stylist Name: "Abc" Phone# "1234" Experience 2 years  | Output: “Name PhoneNumber Experience” |
| **User can click on a specific Stylist to view their Clients** | User Input:"Click: Abc" | Output: “Clients: Efg” |
| **If no Client have been added a message appears** | User Input:"Click: View Clients" | Output: “You have no Clients listed.” |
| **User can navigate to a create new Clients page for each Stylist** | User Input:"Click: Abc Click: Add Client" | Output: “Client Form" |
| **User can add a new Client for each Stylist** | User Input:"Name: Efg, Phone# 6789" | Output: “Name Phone#” |
| **User can view Client details when clicked** | User Input:"Click: Efg" | Output: “Client Details: Efg 6789 ” |
| **User can delete all Stylists** | User Input:"Click: Delete All" | Output: “You have no Stylists listed!” |
| **User can delete single Stylist** | User Input:"Click: Delete Stylist" | Output: “You have removed this Stylist!” |
| **User can delete all Clients** | User Input:"Click: Delete All" | Output: “You have no Clients list" |
| **User can delete single Client** | User Input:"Click: Delete Client" | Output: “You have removed this Client!” |


#### License

This software is licensed under the MIT license.

Copyright © 2020 **_Nitun Datta_**
