

<!-- ABOUT THE PROJECT -->
## About The Project
A group project for the Cloudbased Applications course for the .NET developer program at Teknikhögskolan Göteborg
We received a ready made .NET project with the task of migrating it to Azure in order to learn how to move a project to the cloud
as well as gaining familiarity with Azure


### Built With
The project is built as a Controller Service Repository architecture with 
* Entity Framework
* AspNetCore
* QuestPDF
* SMTP

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

* .NET 8.0 or later
  ```sh
  https://learn.microsoft.com/en-us/dotnet/core/install/
  ```
* Entity Framework
  ```sh
  dotnet tool install --global dotnet-ef
  dotnet add package Microsoft.EntityFrameworkCore.Design
  ```
### Installation

_Below is an example of how you can instruct your audience on installing and setting up your app. This template doesn't rely on any external dependencies or services._

1. Clone the repo
   ```sh
   git clone https://github.com/github_username/repo_name.git
   ```
2. Install NPM packages
   ```sh
   npm install
   ```
3. In `appsettings.json` change to your own azure keyvault or default connection string
   ```js
   "keyVaultName": "ENTER YOUR KEYVAULT NAME";
   ```
4. Delete migrations and run
   ```sh
   dotnet ef database update
   ```
   to enable moving your database to a different provider, from Postgres to SQL Server for example
5. Change git remote url to avoid accidental pushes to base project
   ```sh
   git remote set-url origin github_username/repo_name
   git remote -v # confirm the changes
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- LICENSE -->
## License
The project itself is not licensed however it is using the QuestPDF community license which stipulates "for commercial projects of individuals or businesses with less than 1 million USD annual gross revenue"

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- ACKNOWLEDGMENTS -->
## Acknowledgments
This readme was created using the template from: 
https://github.com/othneildrew/Best-README-Template/tree/main

<p align="right">(<a href="#readme-top">back to top</a>)</p>



