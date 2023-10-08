# BookService
## Introduction
Simple Book Service is a basic IT application developed for Reading Corp to maintain a catalog of books. This repository contains the source code and documentation for the Simple Book Service. It is implemented using ASP.NET Core Web API and includes a simple client application for interacting with the Web API. The application allows users to create and update book records and stores the data in a non-text file-based structure.

## Requirements
The Simple Book Service fulfills the following requirements:

1. **Data Structure:** The solution captures the following information for each book:
   - Book ID
   - Book Name
   - Author
   - Registration Timestamp
   - Category (thriller, history, drama, or biography)
   - Description

2. **Web API Methods:**
   - `POST /api/book/create`: Allows clients to create a new book. It returns the new book ID to the client.
   - `PUT /api/book/{bookId}/update`: Allows clients to update an existing book. It returns the entire book structure to the client. Partial updates are supported, allowing clients to update specific fields.

3. **Client Application:** The repository includes a simple client application that facilitates interaction with the Web API. This client application can be a console application or a basic HTML and JavaScript application.

4. **Persistence:** Books are persisted in a non-text file-based structure.

## Implementation Details

### Technologies Used
- ASP.NET Core Web API
- Visual Studio 2022 Community Edition
- GitHub for version control

### Project Structure
The project is organized as follows:
- `SimpleBookService.API`: Contains the ASP.NET Core Web API implementation.
- `SimpleBookService.Client`: Contains the client application for interacting with the API.
- `SimpleBookService.Data`: Manages the data and storage.
- `SimpleBookService.Tests`: Includes unit tests for the application.

### Getting Started
To run the Simple Book Service locally, follow these steps:

1. Clone the repository from GitHub:

   ```
   git clone https://github.com/your-username/simple-book-service.git
   ```

2. Open the solution in Visual Studio 2022.
3. Install Entity Framework Core:

You need to install Entity Framework Core and the appropriate database provider (e.g., SQL Server, SQLite, PostgreSQL, etc.) for your project. You can do this using NuGet Package Manager or by adding dependencies to your project file (csproj).
Configuration:

Configure the database connection string and other options in the appsettings.json on your environment.

Migrations and Database Initialization:

Generate migrations and apply them to create or update the database schema. Use Entity Framework Core tools like dotnet ef migrations add and dotnet ef database update to perform these tasks.

4. Build and run the API project.

5. Build and run the client application(BookServiceApp) to interact with the API(BookService).

### Source Code
The source code for this project is available on GitHub: [Simple Book Service Repository](https://github.com/your-username/simple-book-service)

### References
EFCore : https://learn.microsoft.com/en-us/ef/core/
Cross Origin Request : https://learn.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-7.0
JQuery : https://api.jquery.com/

Thank you for using the Simple Book Service!
