# FAQ Web Application – ASP.NET Core MVC

This is a Frequently Asked Questions (FAQ) Web App built with **ASP.NET Core MVC** and **Entity Framework Core**. It allows users to view and filter FAQs by topic and category using custom routes and Bootstrap styling. It uses Code First migration with seed data and responsive design.

---

## 🚀 Features

- View all FAQs on initial load
- Filter FAQs by **Topic** (via top Bootstrap navbar)
- Filter FAQs by **Category** (via left Bootstrap list group)
- Combine both filters (topic + category)
- Custom lowercase URLs with trailing slashes
- Bootstrap layout and styling
- Uses Code First migration
- Seed data for Topics, Categories, and FAQs

---

## 🛠 Technologies Used

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- Razor Pages / Views
- Bootstrap 5
- SQL Server LocalDB
- Visual Studio 2022+

---

## ⚙️ How to Run This Project

Follow these exact steps:

---

### 1. Clone the Repository

```bash
git clone https://github.com/kishankumar2607/FAQ_Web_Application-ASP.NET-Core-MVC.git
cd FAQ_Web_Application-ASP.NET-Core-MVC
```

---

### 2. Restore and Build the Project

Make sure you have the latest .NET SDK installed.

```bash
dotnet restore
dotnet build
```

---

### 3. Apply Migrations and Seed the Database

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

OR

```bash
Add-Migrations InitialCreate
Update-Database
```

If you see build errors like `DirectoryNotFoundException`, follow these:

- Close Visual Studio
- Delete `bin/` and `obj/` folders manually
- Open project again and rebuild

---

### 4. Run the Application

```bash
dotnet run
```

Once it starts, open this URL in your browser:

```
https://localhost:5001/
```

---

## 🧭 Routing and Filtering

| Action             | Example URL                                     |
|--------------------|--------------------------------------------------|
| View All FAQs      | `/` or `/home/index/`                            |
| Filter by Topic    | `/home/index/topic/javascript/`                 |
| Filter by Category | `/home/index/category/general/`                 |
| Filter Both        | `/home/index/topic/javascript/category/history/`|

All URLs are lowercase with trailing slashes.

---

## 📁 Project Structure

```
/Controllers
    HomeController.cs

/Models
    Faq.cs
    Topic.cs
    Category.cs
    AppDbContext.cs

/Views
    /Home
        Index.cshtml
    /Shared
        _Layout.cshtml
        _ViewStart.cshtml
    _ViewImports.cshtml

/wwwroot
    (static CSS/JS if any)

Program.cs
appsettings.json
KishanKumarDas_Assignment2.csproj
README.md
```

---

## 📂 Git Ignore List

To keep your repo clean, ignore the following:

```plaintext
# Build artifacts
bin/
obj/

# User-specific files
.vs/
*.user
*.suo

# Logs
*.log

# OS files
*.DS_Store

# Databases
*.db

# Environment configs
.env
```

---

## 👨‍💻 Author

**Kishan Kumar Das**  
Semester 4 – Advanced Programming with .NET  
Conestoga College – Canada
