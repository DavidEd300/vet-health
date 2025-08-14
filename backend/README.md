# 🧠 Vet Health

**Vet Health** is a collaborative project to create a social platform for pet lovers.  
Think *Instagram for pets* a place where owners can share their pets' best moments through photos, stories, and videos.  

## 📌 About

We aim to integrate pet shops and veterinary clinics into the platform, building a unique ecosystem that connects pet owners with trusted services..  
This project is built incrementally, showcasing practical implementation:

- ASP.NET Core Web API
- React + Next.js
- JavaScript / TypeScript
- Entity Framework Core (Code First)
- Organized folder structure: Models, Controllers, Data.
- SQLite as a lightweight development database
- Git flow, branching and pull requests

## 🚀 Stack

| Layer         | Tech                                       |
|---------------|--------------------------------------------|
| Frontend      | Next.js + TypeScript                       |
| Backend       | ASP.NET Core (Web API)                     |
| ORM           | EF Core + Dapper                           |
| Database      | SQLite                                     |
| Version Ctrl. | Git + GitHub                               |

## 📂 Project Sctructure

```bash
vethealth.sln
│
├── vethealth.API/              
│   ├── Controllers/             
│   ├── Data/                    
│   ├── Models/                  
│   ├── Program.cs               
│   ├── appsettings.json
|   └── Migrations/         
│                  
├── vethealth.db                
└── README.md                    
```

## ⚙️ Getting Started Locally

```bash
# Clone the repo
git clone https://github.com/carloslk18/vet-health.git

cd vet-health/vethealth.API

# Restore dependencies
dotnet restore

# Run the API
dotnet run
```

## 🧪 Database Setup

```bash
dotnet ef migrations add SomeMigrationName
dotnet ef database update
```
