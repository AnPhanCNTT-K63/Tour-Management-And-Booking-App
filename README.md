# Tour Management and Booking System
View Swagger API Document at: http://tourmanagementapp.somee.com/swagger/index.html

## Overview
With the development of the tourism industry, travel agencies and companies need a professional system to manage their services effectively. Issues such as managing tour lists, customers, payments, and traditional reservations are often time-consuming and error-prone. The Tour Management and Booking System is designed to optimize this process.

![image](https://github.com/user-attachments/assets/7d7cd182-85db-4a09-a2b6-2825d5ed4a36)

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
 
 ![image](https://github.com/user-attachments/assets/458a1df5-c24e-4ef0-aa95-ee400c10b0c3) ![image](https://github.com/user-attachments/assets/80997169-2f63-4561-a0ec-f6efb8d9e9ff)

#### Add Tour Package
- After entering basic tour information, the manager can add detailed tour packages such as:
  - Accompanying activities
  - Tour duration
  - Additional services
  - Special combos
    
![image](https://github.com/user-attachments/assets/669c30e7-f040-4391-b558-1cb1a509021b) ![image](https://github.com/user-attachments/assets/c2d87283-af56-4b0b-8df2-9281fe5c4843)

#### Exit
- The manager can exit the add tour screen when data entry is complete.

#### Reset Information
- Provides an option to clear entered data and restart if there are errors.

### 2. Tour Booking Management
#### Search Tour
- **Search by name, location, and time:** Users can enter keywords to find suitable tours.
- **Dynamic filtering:** The system will display results that match the entered keywords.

![image](https://github.com/user-attachments/assets/f73171b6-0dc9-4098-b6c9-5d6254fdc05c)

#### View Tour Details
- **Display tour description, location, and schedule:** Full information about the tour, including description, location, start and end time.
- **Display available tour packages:** Users can view and select different packages with various activities and prices.

![image](https://github.com/user-attachments/assets/79365f77-abe2-4c6b-9759-fd3636af5ef5)

#### Book a Tour Package
- **Enter payer information:** Users must provide personal details for booking.
- **Select payment method:** Multiple payment options available (credit card, e-wallet, bank transfer, etc.).
- **Select number of participants:** Users can specify the number of people joining the tour.
- **Apply promotional voucher:** Users can enter discount codes to reduce costs.
- **Payment verification:** After entering details and choosing a payment method, the system verifies and confirms the payment.

![image](https://github.com/user-attachments/assets/75ea23c7-3194-4b75-a9d5-7013cf51a7da)

### 3. User Information Management
#### Add User Information
- **Enter user name:** The administrator enters the full name of the user.
- **Enter address and country code:** The user’s current address and country code are recorded in the system.

![image](https://github.com/user-attachments/assets/3d07f4f0-36e3-4fa8-81f5-57d0205ba3a1)

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

