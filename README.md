# Environment
- .NET version - v6.0.202
- SQL Server version - v14.0.2037.2

# Database Setup
- Create a new database named 'Employees'.
- Run the scripts in numerical order (1, then 2, then 3, etc.).
- Load any seed data you want into the database.

# Api Setup
- Update the connection string in the appsettings.json to match the connection string to your database

# Running
- Press run in Visual Studio
- Your broswer should open to the swagger page. It will probably complain about the certificate, but accept and continue.
- From the swagger page you can test the API, or you can use Insomnia or Postman or something else.

# Thoughts
- The linking between the different types of employees in code is not right. This was my first attempt at a database first approach with EF Core. I'm more familiar with Code first.
  - The models in the database project were generated using EF Core's cli scaffolding command. I didn't touch those models at all.
- Lacking more unit tests. Could always have more.
- I'd probably use a dacpac over plain script files normally.