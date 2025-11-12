
# BuzzLock

A secure desktop password manager built with C# and WinForms that helps you store and manage your passwords safely.


## Features
* Argon2id Password Hashing
* Windows DPAPI Encryption
* SHA256 Email Hashing
* PIN Protection 
* Secure Password Generator 
* Password Vault 
* Graphical User Interface (GUI)
* Database Management
* Login (via Email or Username)
* Error Handling and Validation
* Usability and Performance


## System Architecture
| Layer | Class | Purpose/Responsibility |
| :------ | :--------- | :----- |
| Models        | Session           | Maintains logged-in user state |
| Controllers   | EmailHasher       | Handles email hashing |
|               | EncryptionHelper  | Handles string encryption and decryption |
|               | PasswordHasher    | Handles password hashing |
| Views         | AddAccountForm    | Add new credentials to the vault |
|               | ConfirmEmail      | Verify email address |
|               | CustomBorder      | Provides custom rounded border styling for UI components |
|               | CustomBorderForm  | Base form class with gradient border styling |
|               | CustomMessageBox  | Custom dialog boxes for user notifications |
|               | EnterPinForm      | Verify Pin before decrypting sensitive data |
|               | ForgotPassword    | Handles password reset with security validation |
|               | GeneratorForm1    | Generate strong passwords with custom complexity |
|               | RegistrationPage  | Email registration, password hashing, validation |
|               | SetupPin          | Configure a secondary PIN for multi-factor protection |
|               | StartPage         | User login view username or email |
|               | VaultForm         | View and manage stored credentials |
|               | ViewAccountForm   | Securely display account details |


## Installation & Setup

### Prerequisites
* **Windows 10/11** (uses Windows DPAPI)
* **.NET 6.0 Runtime** or later
* **SQLite** (automatically handled by application)

### Installation Steps
**1. Download the Application**
``` # Clone the repository
git clone https://github.com/<yourusername>/BuzzLock.git
cd BuzzLock
```

**2. Build the Solution**
```
# Using .NET CLI
dotnet build
# Or open in Visual Studio and build
```

**3. Run the Application**
``` 
dotnet run
# Or launch from Visual Studio
```

## Usage Guide
### Creating an Account
1. Click "Register" on the login screen**
2. Enter your email and a strong master password
3. Set up your security PIN (4-6) digits
4. Log in with your credentials

### Adding Passwords
1. Click the "+" button in the vault
2. Fill in account details (service, username, password)
3. Use the password generator if needed
4. Click "Save" to encrypt and store

### Generating Strong Passwords
1. Click the generator icon in the vault or add form
2. Customize character sets:
* Uppercase letters (A-Z)
* Lowercase letters (a-z)
* Numbers (0-9)
* Special characters (!@#$% etc.)
3. Set desired password length (4-130 characters)
4. Click "Generate" and "Copy" to use

### Accessing Saved Passwords
1. Click any account in your vault
2. Enter your PIN for verification
3. View, edit, or copy the password
4. Passwords are automatically hidden for security






