# 🚀 VetHealth

> 🐾 A social platform that connects pet lovers, petshops, and veterinary clinics — think **Instagram for pets**, but smarter.  
> Built collaboratively by a student team passionate about software, pets, and innovation.

---

## 🧠 About the Project

**VetHealth** aims to create an ecosystem where pet owners can share their pets’ best moments — photos, stories, and videos — while connecting with **trusted petshops and veterinary services**.

This project is being developed incrementally to serve as both a **learning experience** and a **real-world application** integrating multiple technologies.

---

## 🧰 Tech Stack

| Layer        | Technology Stack                         |
|---------------|------------------------------------------|
| **Frontend**  | React + Next.js (TypeScript)             |
| **Backend**   | ASP.NET Core Web API                     |
| **ORM**       | Entity Framework Core (Code First) + Dapper |
| **Database**  | SQLite (development)                     |
| **Mobile**    | .NET MAUI (in progress)                  |
| **Versioning**| Git + GitHub                             |
| **DevOps**    | GitHub Actions (CI/CD planned)           |

---

## 📁 Project Structure

```bash
vethealth.sln
│
├── vethealth.API/              
│   ├── Controllers/         # Web API endpoints
│   ├── Data/                # EF Core context and configuration
│   ├── Models/              # Domain models/entities
│   ├── Migrations/          # EF Core migrations
│   ├── Program.cs           # App entry point
│   ├── appsettings.json     # Configurations
│   └── ...
│
├── vethealth.db             # Local SQLite database
└── README.md
```

## ⚙️ Getting Started Locally

```bash
git clone https://github.com/DavidEd300/vet-health.git
cd vet-health/vethealth.API
```

# Restore dependencies
```bash
dotnet restore
dotnet run
```

## 🧪 Database Setup

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
##📄 License

This project is open source under the MIT License, feel free to contribute and build with us!
