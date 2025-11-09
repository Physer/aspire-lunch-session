# Aspire Lunch Session

A showcase project demonstrating .NET Aspire fundamentals and preview features, including publishing and deployment capabilities.

## 🎯 Overview

This repository contains a demonstration of .NET Aspire, Microsoft's opinionated stack for building observable, production-ready cloud-native applications. The project covers:

- **Aspire Basics**: Service discovery, orchestration, and local development
- **Preview Features**: Publishing and deployment workflows
- **Best Practices**: Configuration, observability, and cloud-native patterns

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- [.NET Aspire workload](https://learn.microsoft.com/dotnet/aspire/fundamentals/setup-tooling)
- Docker Desktop (for container support)

### Installation

Install the .NET Aspire workload:

```bash
dotnet workload update
dotnet workload install aspire
```

### Running the Application

1. Clone the repository:
```bash
git clone https://github.com/Physer/aspire-lunch-session.git
cd aspire-lunch-session
```

2. Run the AppHost project:
```bash
dotnet run --project <AppHostProjectName>
```

3. Open the Aspire dashboard (typically at `http://localhost:15xxx`) to view:
   - Service topology
   - Distributed tracing
   - Logs and metrics
   - Container status

## 📦 Features Demonstrated

### Core Aspire Features
- **Service Orchestration**: Managing multiple services and their dependencies
- **Service Discovery**: Automatic service-to-service communication
- **Observability**: Built-in telemetry, logging, and distributed tracing
- **Resource Management**: Container and database lifecycle management

### Preview Features
- **Publishing**: Generating deployment manifests
- **Deployment Workflows**: Azure Container Apps integration
- **Infrastructure as Code**: Bicep template generation

## 🔧 Project Structure

The solution follows the standard Aspire project structure:
- **AppHost**: Orchestration and service discovery configuration
- **ServiceDefaults**: Shared configuration for observability and resilience
- **Application Projects**: Your services and APIs
- **Infrastructure**: Bicep templates for Azure deployment

## 📚 Learn More

- [.NET Aspire Documentation](https://learn.microsoft.com/dotnet/aspire/)
- [Aspire GitHub Repository](https://github.com/dotnet/aspire)
- [Aspire Samples](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview)

## 🤝 Contributing

Contributions, issues, and feature requests are welcome! This is a learning and demonstration project.

## 📝 License

This project is for educational and demonstration purposes.

---

**Note**: This is a showcase project for learning .NET Aspire. Some features demonstrated may be in preview and subject to change.