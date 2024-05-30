# Authentication API

This project is an OAuth login API for a mobile game, providing authentication and authorization features. The API validates users and generates JWT tokens containing user roles and system regions.

## Features
- OAuth login
- Role-based access control
- Static user data for demonstration

## System Regions
1. **Board game (`b_game`)**: Default for all logged-in users
2. **VIP Character modification (`vip_chararacter_personalize`)**: For VIP users

## System Roles
1. **Player (`player`)**
2. **Administrator (`admin`)**

## Getting Started

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Running the Project

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/Ammar653/auth-api.git
   cd auth-api
2.  **Clone the Repository:**
   dotnet build
dotnet run
3.  **Clone the Repository:**
The API will be accessible at https://localhost:7275/auth/login.

**API Endpoints**
POST /auth/login
This endpoint allows users to log in and receive a JWT token if their credentials are valid.

**Request**
URL: https://localhost:5001/auth/login
Method: POST
Headers: Content-Type: application/json
**Body:**
{
  "username": "string",
  "password": "string"
}
**Response**
Success (200):
{
  "token": "string"
}
**Unauthorized (401):**
{
  "message": "Unauthorized"
}

