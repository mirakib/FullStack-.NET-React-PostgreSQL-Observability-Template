# FullStack .NET React PostgreSQL Observability Template
A production-grade dotnet new template that scaffolds a complete full-stack application with .NET 8 Web API, React frontend, PostgreSQL database, and Nginx reverse proxy, including turnkey monitoring stack (Prometheus, Grafana, cAdvisor, Node Exporter) with Alpine-based multistage Docker builds, security hardening, and CI/CD-ready configuration.

# Features
- **Backend**: .NET 8 Web API with Entity Framework Core for PostgreSQL
- **Frontend**: React application created with Create React App
- **Database**: PostgreSQL with Docker Compose setup
- **Reverse Proxy**: Nginx for serving the React app and proxying API requests
- **Observability**: Integrated monitoring stack with Prometheus, Grafana, cAdvisor, and Node Exporter
- **Dockerized**: Multistage Docker builds for optimized images

# Project Structure
```
react-postgres-nginx-template/
├── .template.config/
│   └── template.json
├── src/
│   ├── backend/
│   │   ├── Controllers/
│   │   │   └── ItemsController.cs
│   │   ├── Data/
│   │   │   └── AppDbContext.cs
│   │   ├── Models/
│   │   │   └── Item.cs
│   │   ├── Dockerfile
│   │   ├── Program.cs
│   │   ├── appsettings.json
│   │   └── Backend.csproj
│   └── frontend/
│       ├── public/
│       ├── src/
│       │   ├── App.jsx
│       │   ├── main.jsx
│       │   └── api.js
│       ├── Dockerfile
│       ├── nginx.conf
│       ├── package.json
│       └── vite.config.js
├── monitoring/
│   ├── prometheus.yml
│   └── grafana/
│       └── provisioning/
│           ├── datasources/
│           │   └── datasource.yml
│           └── dashboards/
│               └── dashboards.yml
├── docker-compose.yml
├── docker-compose.override.yml
├── .dockerignore
├── .gitignore
└──  README.md
```

# Getting Started
1. Clone the repository:
   ```bash
   git clone https://github.com/mirakib/FullStack-.NET-React-PostgreSQL-Observability-Template.git
   cd FullStack-.NET-React-PostgreSQL-Observability-Template
   ```
2. Build and run the application using Docker Compose:
   ```bash
   docker-compose up -d --build
   ```
3. Access the application at 
   
    Application: http://localhost
    Prometheus: http://localhost:9090
    Grafana: http://localhost:3000 (admin/admin123)
    cAdvisor: http://localhost:8080
    Node Exporter: http://localhost:9100
    PostgreSQL: localhost:5432

# Contributing
Contributions are welcome! Please open issues and submit pull requests for any improvements or bug fixes. 

