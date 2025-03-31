# Tour Management and Booking System

## Overview
With the development of the tourism industry, travel agencies and companies need a professional system to manage their services effectively. Issues such as managing tour lists, customers, payments, and traditional reservations are often time-consuming and error-prone. The Tour Management and Booking System is designed to optimize this process.

## Technologies Used
- **Backend:** ASP.NET Core Web API
- **Frontend:** WinForms
- **Database:** SQL Server
- **Storage**: AWS S3
- **CDN**: AWS CloudFront

## Features

### 1. Tour Management
#### Add Tour
- Enter basic tour information such as:
  - Tour name
  - Location
  - Duration
  - Maximum number of people
  - Ticket price
  - Other related details

#### Add Tour Package
- After entering basic tour information, the manager can add detailed tour packages such as:
  - Accompanying activities
  - Tour duration
  - Additional services
  - Special combos

#### Exit
- The manager can exit the add tour screen when data entry is complete.

#### Reset Information
- Provides an option to clear entered data and restart if there are errors.

### 2. Tour Booking Management
#### Search Tour
- **Search by name, location, and time:** Users can enter keywords to find suitable tours.
- **Dynamic filtering:** The system will display results that match the entered keywords.

#### View Tour Details
- **Display tour description, location, and schedule:** Full information about the tour, including description, location, start and end time.
- **Display available tour packages:** Users can view and select different packages with various activities and prices.

#### Book a Tour Package
- **Enter payer information:** Users must provide personal details for booking.
- **Select payment method:** Multiple payment options available (credit card, e-wallet, bank transfer, etc.).
- **Select number of participants:** Users can specify the number of people joining the tour.
- **Apply promotional voucher:** Users can enter discount codes to reduce costs.
- **Payment verification:** After entering details and choosing a payment method, the system verifies and confirms the payment.

### 3. User Information Management
#### Add User Information
- **Enter user name:** The administrator enters the full name of the user.
- **Enter address and country code:** The user’s current address and country code are recorded in the system.

## Branch Structure
- `api`: Contains the ASP.NET Core Web API backend.
- `app`: Contains the WinForms frontend.

## Installation and Setup
### Prerequisites
- .NET 6.0+ installed
- SQL Server installed and configured
- Visual Studio or Visual Studio Code
- Git installed

### Steps to Run the Project
#### Clone the repository
```sh
git clone https://github.com/AnPhanCNTT-K63/Tour-Management-And-Booking-App.git
cd your-repo-url
```

#### Setting up the API (`api` branch)
```sh
git checkout api
cd api
dotnet restore
dotnet build
dotnet run
```

#### Setting up the WinForms App (`app` branch)
```sh
git checkout app
cd app
dotnet build
dotnet run
```

## Contribution
If you want to contribute to this project, follow these steps:
1. Fork the repository.
2. Create a new feature branch: `git checkout -b feature-branch-name`.
3. Commit your changes: `git commit -m "Describe changes"`.
4. Push to the branch: `git push origin feature-branch-name`.
5. Open a Pull Request.

## License
This project is licensed under the [MIT License](LICENSE).

