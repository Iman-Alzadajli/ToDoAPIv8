# ✅ ToDoAPIv8 - Practice Project using ASP.NET Core & EF Core

## 📌 Overview

This is a practice RESTful API project built using **ASP.NET Core** and **Entity Framework Core**. It provides CRUD operations for managing categories and todo items in a simple To-Do list system.

---

## 🧠 Features

- 📁 Category management:
  - Get all categories
  - Get category by ID
  - Create, update, and delete categories
- ✅ Todo management:
  - Todos are linked to categories via a foreign key
- 🔄 Uses Entity Framework Core with Code First approach
- 🔧 Swagger UI enabled for testing the API

---

## 🛠️ Technologies

- ASP.NET Core 7
- Entity Framework Core
- SQL Server (via connection string)
- Swagger (OpenAPI)

---

## 📂 Project Structure

ToDoAPIv8/
├── Models/
│ ├── Category.cs
│ └── Todo.cs
├── Context/
│ └── ApplicationDbContext.cs
├── Controllers/
│ └── CategoryController.cs
├── Program.cs
├── appsettings.json

---

1. Clone the project.
2. Add your SQL Server connection string in `appsettings.json` under `"DefaultConnection"`.
3. update-database
