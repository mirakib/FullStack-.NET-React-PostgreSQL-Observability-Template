<div style="display: flex; align-items: center; gap: 10px;">
  <img src="https://skillicons.dev/icons?i=dotnet,react,postgres,nginx,prometheus,grafana,docker" style="height: 40px;"/>
</div>

# FullStack .NET React PostgreSQL Observability Template
A production-grade dotnet new template that scaffolds a complete full-stack application with .NET 8 Web API, React frontend, PostgreSQL database, and Nginx reverse proxy, including turnkey monitoring stack (Prometheus, Grafana, cAdvisor, Node Exporter) with Alpine-based multistage Docker builds, security hardening, and CI/CD-ready configuration.

## Features
- **Backend**: .NET 8 Web API with Entity Framework Core for PostgreSQL
- **Frontend**: React application created with Create React App
- **Database**: PostgreSQL with Docker Compose setup
- **Reverse Proxy**: Nginx for serving the React app and proxying API requests
- **Observability**: Integrated monitoring stack with Prometheus, Grafana, cAdvisor, and Node Exporter
- **Dockerized**: Multistage Docker builds for optimized images

## Technologies Used

| Technology | Version | Purpose |
|-------------|----------|----------|
| **DotNet** | 8.x | Framework for building the web application |
| **EF Core** | 8.x | Object-Relational Mapper (ORM) framework  for data access.|
| **React** | 19.x | Frontend library for building user interfaces |
| **PostgreSQL** | 16.x | Database for storing contact information |
| **Nginx** | 1.2.x | Reverse proxy server |
| **Docker** | 28.x+ | Containerization platform |


## Project Structure
```
.
├── docker-compose.yml
├── init-db.sql
├── monitoring
│   ├── grafana
│   │   └── provisioning
│   │       ├── dashboards
│   │       └── datasources
│   └── prometheus.yml
├── README.md
└── src
    ├── backend
    │   ├── appsettings.json
    │   ├── Backend.csproj
    │   ├── Controllers
    │   │   └── ItemsController.cs
    │   ├── Data
    │   │   └── AppDbContext.cs
    │   ├── Dockerfile
    │   ├── Models
    │   │   └── Item.cs
    │   └── Program.cs
    ├── frontend
    │   ├── Dockerfile
    │   ├── eslint.config.js
    │   ├── index.html
    │   ├── nginx.conf
    │   ├── package.json
    │   ├── package-lock.json
    │   ├── public
    │   │   └── vite.svg
    │   ├── README.md
    │   ├── src
    │   │   ├── api.js
    │   │   ├── App.css
    │   │   ├── App.jsx
    │   │   ├── assets
    │   │   ├── index.css
    │   │   └── main.jsx
    │   └── vite.config.js
    └── package-lock.json

```

## Getting Started
1. Clone the repository:
   ```bash
   git clone https://github.com/mirakib/FullStack-.NET-React-PostgreSQL-Observability-Template.git
   cd FullStack-.NET-React-PostgreSQL-Observability-Template
   ```
2. Build and run the application using Docker Compose:
   ```bash
   docker compose up -d --build
   ```
3. Access the application at 
   
    - Application: http://localhost:80

    - Prometheus: http://localhost:9090

    - Grafana: http://localhost:3000
    - cAdvisor: http://localhost:8080

    - Node Exporter: http://localhost:9100

    - PostgreSQL: http://localhost:5432

## Screenshots
Frontend Application
![Frontend Application](./screenshots/frontend-application.png)
cAdvisor Metrics
![cAdvisor Metrics](./screenshots/cadvisor-metrics.png)
Node Exporter Metrics
![Node Exporter Metrics](./screenshots/node-exporter-metrics.png)

## Contributing
Contributions are welcome! Please open issues and submit pull requests for any improvements or bug fixes. 
