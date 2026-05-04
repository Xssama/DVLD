# DVLD - Driving License Management System

![.NET Framework 4.8](https://img.shields.io/badge/.NET%20Framework-4.8-blue)
![Build](https://img.shields.io/badge/build-passing-brightgreen)
![License](https://img.shields.io/badge/license-MIT-green)

## What the project does

**DVLD** is a Windows Forms application designed to streamline the management of driving license operations. It provides a comprehensive solution for handling driving license applications, scheduling and tracking tests, issuing and renewing licenses, managing detained licenses, and supporting user and role management for licensing authorities.

## Why the project is useful

- Centralizes all driving license processes in one application
- Supports local and international license workflows
- Manages test scheduling, results, and retakes
- Handles license detainment, release, and replacement
- Provides user authentication and role-based access
- Modular, maintainable, and extensible architecture

## How users can get started

### Prerequisites
- Windows OS
- Visual Studio 2019 or later
- .NET Framework 4.8
- SQL Server (for data storage)

### Installation
1. Clone the repository:
   ```sh
   git clone <repository-url>
   ```
2. Open the solution in Visual Studio.
3. Restore NuGet packages if required.
4. Configure the database connection string in `DVLD_DataAccess/clsDataAccessSettings.cs`.
5. Build the solution.
6. Run the application (the main entry point is `Program.cs`).

### Usage Example
- Log in using your credentials.
- Navigate through the main menu to manage applications, licenses, tests, and users.
- Example: To issue a new local driving license, go to **Applications > Local Driving License > Add New**.

## Where users can get help

- For issues or questions, open an issue in this repository.

## Who maintains and contributes

- Maintained by the project contributors.
- Contributions are welcome!.

---

*This project is provided under the MIT License. See [LICENSE](LICENSE) for details.*
