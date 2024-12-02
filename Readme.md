# Library Management System

This is a simple web-based Library Management System built with ASP.NET Core MVC. The system allows users to manage books and authors, including creating, updating, deleting, and viewing records.

---

## Features

### Author Management
- **Create**: Add a new author with details like first name, last name, and date of birth.
- **Update**: Edit existing author details.
- **Delete**: Remove an author from the system.

### Book Management
- **Create**: Add a new book with attributes such as title, author, genre, publish date, ISBN, and available copies.
- **Update**: Modify book information.
- **Delete**: Delete a book from the system.

---

## Technologies Used
- **ASP.NET Core MVC**: Framework for building web applications.
- **Bootstrap**: Responsive design and styling.
- **C#**: Backend logic.
- **HTML/CSS**: Frontend structure and design.

---

## Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/Oruccu/LibraryManagementSystem.git
    ```

2. Navigate to the project directory:
    ```bash
    cd LibraryManagementSystem
    ```

3. Restore dependencies:
    ```bash
    dotnet restore
    ```

4. Run the project:
    ```bash
    dotnet run
    ```

5. Access the application in your browser:
    ```
    http://localhost:5000
    ```

---

## Project Structure

### Controllers
- **LibraryController.cs**: Handles the business logic for managing authors and books.

### Views
- **Authors**:
  - `AuthorCreate.cshtml`: Form for adding a new author.
  - `AuthorUpdate.cshtml`: Form for updating author details.
  - `AuthorDelete.cshtml`: Confirmation page for deleting an author.
- **Books**:
  - `BookCreate.cshtml`: Form for adding a new book.
  - `BookUpdate.cshtml`: Form for updating book details.
  - `BookDelete.cshtml`: Confirmation page for deleting a book.
- **Shared**:
  - `Layout.cshtml`: Main layout for consistent design across pages.

### Models
- **NewAuthor**: Model for creating a new author.
- **NewBook**: Model for creating a new book.
- **BookUpdateViewModel**: Model for updating book details.
- **LibraryViewModel**: View model for displaying books and authors on the index page.

---

## Example Data

### Example Author Data
```csharp
public static List<Author> Authors = new List<Author>
{
    new Author { Id = 1, FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(1980, 5, 12) },
    new Author { Id = 2, FirstName = "Jane", LastName = "Smith", DateOfBirth = new DateTime(1975, 8, 22) }
};
```
## Screenshots
### Home Screen
![Home Screen](/Assets/Home.png)

### Library Screen
![Library Screen](/Assets/Library.png)

### Author Screen
![Library Screen](/Assets/Author.png)

### Book Add Screen
![Library Screen](/Assets/AddBook.png)

### Author Add Screen
![Library Screen](/Assets/AddAuthor.png)

### Delete Screen
![Library Screen](/Assets/DeleteCheck.png)


### Contact
For any questions or suggestions, feel free to contact:

**Email:** ayseoruccu@gmail.com
**GitHub:** oruccu