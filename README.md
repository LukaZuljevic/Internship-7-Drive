# Internship-7-Drive
**Seventh DUMP internship homework**

![.NET](https://img.shields.io/badge/.NET-6.0-blueviolet)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-13%2B-blue)

## ✅ Prerequisites
Make sure you have the following installed before getting started:

- [PostgreSQL](https://www.postgresql.org/download/) (version 13 or newer)
- [pgAdmin](https://www.pgadmin.org/download/) (optional but recommended)
- [.NET SDK 6.0](https://dotnet.microsoft.com/en-us/download) or newer
- Run this command in your terminal to install EF Core CLI Tools:
  dotnet tool install --global dotnet-ef

## 🚀 Getting Started

git clone https://github.com/LukaZuljevic/Internship-7-Drive.git
cd Internship-7-Drive

Open pgAdmin (or any PostgreSQL tool you prefer).
Create a new database named DriveApp.

In the presentation project folder, locate and open the App.config file.
Update the connection string with your PostgreSQL username, password and port.

<add name="Drive" connectionString="Server=127.0.0.1;Port=5432;Database=DriveApp;User Id="youruser";Password="yourpassword";" />

Replace youruser with your PostgreSQL username.
Replace yourpassword with your PostgreSQL password.

Run this command to create tables in your DriveApp database:
dotnet ef database update --startup-project Presentation --project Data

Run the app:
dotnet run --project Presentation
