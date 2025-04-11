# Payment Platform

A .NET Core payment platform supporting multiple payment providers (Stripe, Strex, Vipps).

## Setup

1. Clone the repository
2. Install the .NET SDK 9.0 or later
3. Install PostgreSQL 17 or later
4. Set up your user secrets:
   ```bash
   dotnet user-secrets init
   dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Database=paymentplatform;Username=your_username;Password=your_password"
   ```
5. Update the database:
   ```bash
   dotnet ef database update
   ```
6. Run the application:
   ```bash
   dotnet run
   ```

## Development

The application uses:
- Entity Framework Core with PostgreSQL
- OpenAPI/Swagger for API documentation
- Repository pattern for data access

## API Documentation

When running in development mode, access the Swagger UI at:
- https://localhost:5001/swagger
- http://localhost:5000/swagger 


## Vipps
Requires a business agreement
Platform:
https://portal.vippsmobilepay.com/
Docs:
https://developer.vippsmobilepay.com/