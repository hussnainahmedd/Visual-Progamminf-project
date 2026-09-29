<div align="center">

# MindfulJournal 📝

### *A mood-tracking journal web app — built as a Visual Programming course project.*

[![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Blazor Server](https://img.shields.io/badge/Blazor-Server-512BD4?style=for-the-badge&logo=blazor&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![ASP.NET Identity](https://img.shields.io/badge/ASP.NET-Identity-2b579a?style=for-the-badge&logo=dotnet&logoColor=white)](https://learn.microsoft.com/aspnet/core/security/authentication/identity)
[![EF Core](https://img.shields.io/badge/EF%20Core-10.0-6b4fbb?style=for-the-badge&logo=nuget&logoColor=white)](https://learn.microsoft.com/ef/core/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-LocalDB-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)

<br/>

![MindfulJournal preview](assets/hero.webp)

> A full-stack **emotion-based journaling web application** built with Blazor Server and .NET 10.
> Write daily journal entries, log your mood with each one, browse your history,
> and see your emotional patterns visualized as charts — with rule-based wellness
> suggestions tied to your mood habits.

---

[Features](#-features) ·
[Tech Stack](#-tech-stack) ·
[Getting Started](#-getting-started) ·
[Project Structure](#-project-structure)

</div>

---

## ✨ Features

Everything below is in the code — nothing invented:

- **📝 Journal entries** — create, view, and edit dated journal entries with a title, content, and a mood attached to each one.
- **🎭 Mood tracking** — five moods to choose from: Happy 😄, Calm 😌, Anxious 😰, Sad 😢, Angry 😡; moods (with emoji + color) are stored in the database.
- **💡 Wellness suggestions** — rule-based suggestions pulled from the database (e.g. tips that trigger after a mood shows up N days in a week), plus a "How suggestions work" reference explaining each rule.
- **📊 Mood analytics** — weekly mood summaries and Chart.js charts (pie + line) showing your mood distribution and trends over time.
- **🔎 Journal history** — browse and revisit all your past entries.
- **👤 Profile & settings** — manage your account details.
- **🔐 Secure authentication** — ASP.NET Identity login/register, 6+ character passwords with a digit required.

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Frontend | Blazor Server (Interactive Server components), Bootstrap 5, custom CSS |
| Backend | ASP.NET Core / .NET 10 |
| Auth | ASP.NET Identity |
| Database | SQL Server (LocalDB), Entity Framework Core code-first migrations |
| Charts | Chart.js (via `wwwroot/charts.js`) |

---

## 🚀 Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server LocalDB (comes with Visual Studio 2022/2025)
- Visual Studio 2022/2025 or any editor

### Run it

```bash
git clone https://github.com/hussnainahmedd/Visual-Progamminf-project.git
cd Visual-Progamminf-project
```

Apply the database migrations (creates `MindfulJournalDB` on LocalDB):

```bash
dotnet ef database update --project MindfulJournal
```

Run the app:

```bash
dotnet run --project MindfulJournal
```

Open **http://localhost:5175** (or https://localhost:7204) in your browser, register an account, and start journaling.

---

## 📂 Project Structure

```
MindfulJournal/
├── Program.cs                    # DI setup, Identity, EF Core, JournalService
├── MindfulJournal.csproj         # .NET 10, Identity + EF Core SqlServer packages
├── appsettings.json              # LocalDB connection string
├── Models/                       # ApplicationUser, JournalEntry, Mood, Suggestion
├── Data/                         # ApplicationDbContext
├── Migrations/                   # EF Core code-first migrations
├── Services/JournalService.cs    # Entry CRUD, weekly mood counts, suggestions
├── Components/Pages/            # Dashboard, Add/Edit/View entries, Analytics,
│                                 # Suggestions, Profile, Settings, Login/Register
└── wwwroot/                      # charts.js (Chart.js helpers), CSS, Bootstrap
```

---

<div align="center">

Built by **[Hussnain Ahmad](https://github.com/hussnainahmedd)** — BSCS student building full-stack apps to learn.

⭐ *Star this repo if you liked it.*

</div>
