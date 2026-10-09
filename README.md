# Hotel Booking RESTful API in ASP.NET Core 8

A clean, modern RESTful Web API for managing hotel room bookings built with **ASP.NET Core 8** and **Entity Framework Core In-Memory Database**.

---

## 🚀 Features

- **CRUD Operations**: Full support for creating, retrieving, updating, and deleting hotel bookings.
- **In-Memory Database**: Zero-configuration persistence using Entity Framework Core InMemory provider (`BookingDB`).
- **Interactive Swagger Documentation**: Built-in OpenAPI explorer via Swagger UI.
- **HTTP Request Tests**: Includes `HotelBookingAPI.http` for fast API endpoint testing inside Visual Studio or VS Code.

---

## 🛠️ Technology Stack

- **Framework**: .NET 8.0 / ASP.NET Core Web API
- **ORM / Database**: Entity Framework Core In-Memory (`Microsoft.EntityFrameworkCore.InMemory`)
- **API Documentation**: Swashbuckle OpenAPI (`Swashbuckle.AspNetCore`)
- **IDE**: Visual Studio 2022 / Visual Studio Code

---

## 📁 Project Structure

```
HotelBookingAPI/
├── Controllers/
│   └── HotelBookingController.cs   # API controller for booking endpoints
├── Data/
│   └── ApiContext.cs               # EF Core DbContext for database operations
├── Models/
│   └── HotelBooking.cs             # Booking entity model
├── Properties/
│   └── launchSettings.json         # Development server launch profiles
├── Program.cs                      # Application entry point and DI configuration
├── HotelBookingAPI.csproj          # Project file and package dependencies
├── HotelBookingAPI.http            # HTTP requests for testing endpoints
└── appsettings.json                # Application configuration settings
```

---

## 📡 API Endpoints

| HTTP Method | Endpoint | Description |
| :--- | :--- | :--- |
| `GET` | `/api/HotelBooking/GetAll` | Retrieve all hotel bookings |
| `GET` | `/api/HotelBooking/Get?id={id}` | Retrieve a specific booking by ID |
| `POST` | `/api/HotelBooking/CreateEdit` | Create a new booking (`Id = 0`) or update existing (`Id > 0`) |
| `DELETE` | `/api/HotelBooking/Delete?id={id}` | Delete a booking by ID |

### Sample JSON Payloads

#### Create Booking (`POST /api/HotelBooking/CreateEdit`)
```json
{
  "roomNumber": 101,
  "clientName": "John Doe"
}
```

#### Update Booking (`POST /api/HotelBooking/CreateEdit`)
```json
{
  "id": 1,
  "roomNumber": 102,
  "clientName": "John Doe"
}
```

---

## 🏃 Getting Started

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or Visual Studio Code

### Running with Visual Studio
1. Open `HotelBookingAPI.slnx` in Visual Studio 2022.
2. Press **F5** or click the green **Run** button (https / http profile).
3. The browser will automatically open the Swagger UI at `https://localhost:7254/swagger`.

### Running with .NET CLI
```bash
# Clone the repository
git clone https://github.com/Tonmoy51480/RESTful-API-in-ASP.NET-.git

# Navigate to the project directory
cd RESTful-API-in-ASP.NET-/HotelBookingAPI

# Run the API
dotnet run
```
Navigate to `https://localhost:7254/swagger` or `http://localhost:5139/swagger` to explore the API.
