# Dr. Sillystringz's Factory

Created: 10/16/2020
 By Johnny Duverseau

# Description

This backend application is for Dr. Sillystringz's Factory. The application allows the manager to see a list of Machines, view the Engineers of each Machines, and add new Engineers to the application. 

## Specifications

1. When a user loads the web application, he or she will see a splash page that has a link to see all the engineers and a link to see all the machines.

2. When a user clicks "See all Engineers," they are taken to a page that includes the first and last name of each engineer and a link to a form to add a new engineer. 

3. When a user clicks an engineers name such as "Shawna," they are taken to page with the engineers name, hire date, pay rate and a list of the machines she is licensed to repair.

4. A user can delete or edit the profile "Shawna" by clicking the link on the engineer's page and making the change or deleting. 

5. When a user clicks "See all Machines," they are taken to a page that includes the a list of machines. They can also click to add a new machine. 

6. When a user clicks one of the machine names "Bentley," they are taken to a page where the engineers assigned to work on that machine are listed. The user can delete or add more engineers to the list. 

7. When a user clicks "Add New Machine," they are taken to a form where can add a new machine including the machine name and the engineer's name who is licensed to work on it. The user has the option not to assign the machine to any engineer too. 


## Setup/Installation Requirements
_To set up and install, follow the instructions to clone the repository._ 

* To clone: 
- Visit GitHub and clone the repository 
- Open your terminal 
- Type “git clone” in the terminal, paste the GitHub URL, and press enter
- Type “code .” and the folder will open in your VScode
- Type “dotnet restore” and press enter 
- Type” dotnet  build” and press enter
- Type “dotnet run” in GitBash and your program will run 
 ## Database Setup
To set up the database, follow the instructions below. 

* To set up: 

_Create an appsettings.json file and add the code in the image below; don’t forget to change your password_

```
 {
 "ConnectionStrings": 
  {
     "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=root;pwd=password;"
  }
 }
 ```

- Open your terminal and type “dotnet restore”
- dotnet build 
- dotnet ef migrations add Initial
- dotnet ef database update
- Then, type “dotnet run” 

## Support and contact details
- Discord: duverseaujohnny21 #2298
- Email: duverseaujohnny21@gmail.com
## Technologies Used
- Visual Studio Code
- C#
- .Net
_ Mvc
- Asp.NetCore
## License
Copyright (c) 2020 Johnny Duverseau

This software is licensed under the MIT license.