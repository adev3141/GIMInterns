
# Library Management System Exercise 
## Overview
 This exercise involves creating a Library Management System using C#. The application allows users to manage books within a library, offering functionality to add, remove, borrow, return, and find books. It also distinguishes between regular and premium users, with additional features available to premium users.
 ## Code Description:
    
**MainWindow Class**: 
 - Contains the main entry point of the application. 
 - Handles user input and interactions through a console-based menu. 
 -  Creates a `Library` object and manages user actions based on the input.

**Library Class**: 
-  Provides methods to add, remove, borrow, return, and find books.

**User and PremiumUser Classes**: 
Represent different types of users.
 - `PremiumUser` inherits from `User` and includes additional functionality for borrowing multiple books.

### Features:
 
 **User Type Determination**: Users are prompted to specify if they are a premium user. 
 
 **Book Management**: 
 - Add a new book to the library. 
 -  Remove an existing book from the library. 
 - Borrow and return books. 
 -  Find books by title or author. 
 
 **Premium Features**: Premium users can borrow multiple books at once.
## Instructions
 1. **Running the Application**: 
  - Compile and run the `MainWindow` class. 
  -  Follow the on-screen prompts to specify if you are a premium user. 
  -  Choose from the menu options to perform different library operations.

2. **Menu Options**: 
- `1`: Add a book 
- `2`: Remove a book 
-  `3`: Borrow a book 
- `4`: Return a book 
- `5`: Find a book 
- `6`: Borrow multiple books (premium users only) 
-  `7`: Exit the application
