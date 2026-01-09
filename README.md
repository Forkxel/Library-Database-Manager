# Library database

Windows Forms application for managing library database.

## Features

1. Inserting, delete, print and update data to 5 different tables.
2. Importing data from CSV file to 2 different tables.
3. Two statistics reports for authors and books.
4. Clearing all tables in database.

## Getting Started

### Dependencies

<ul>
    <li>.NET SDK latest recommended</li>
    <li>SQL Database for data storage (ideally MSSQL)</li>
    <li>
        NuGet packages:
        <ul>
            <li>System.Data.SqlClient</li>
        </ul>
    </li>
</ul>

### Installing

1. Download the zip file from the GitHub here: https://github.com/Forkxel/Library-Database-Manager.git.
2. Extract the zip file and open LibraryDatabaseManager-exe folder.
3. Create new json file in the folder called appsettings.json.
4. Open the file and copy the following.
```
{
  "ConnectionString": "Server=SERVER_EXAMPLE;Database=DATABASE_EXAMPLE;User Id=USER_EXAMPLE;Password=PASSWORD_EXAMPLE;"
}
```
5. Change following to:
<ul>
    <ul>
        <li>Server - Your server.</li>
        <li>Database - Enter name of your database.</li>
        <li>User Id - Your username.</li>
        <li>Password - Your password.</li>
    </ul>
</ul>

6. Run the exe file.

## Running the program

First you will see the main menu with buttons to access all tables and reports.

### Tables

<ol>
    <li><a href="#1-books-table">Books table</a></li>
    <li><a href="#2-authors-table">Authors table</a></li>
    <li><a href="#3-categories-table">Categories table</a></li>
    <li><a href="#4-members-table">Members table</a></li>
    <li><a href="#5-loans-table">Loans table</a></li>
</ol>
 
#### 1. Books table

Table showing all of the books in the database. You can add, update and delete books. In the update only fill the values you want to update leave others empty.

#### 2. Authors table

Table showing all of the authors in the database. You can add, update and delete authors. In the update only fill the values you want to update leave others empty. This table also supports importing data from the CSV file that looks like this:

```
firstName,lastName
ExampleFirstName,ExampleLastName
```

#### 3. Categories table

Table showing all of the categories in the database. You can add, update and delete categories. This table also supports importing data from the CSV file that looks like this:

```
name
ExampleName
```

#### 4. Members table

Table showing all of the members in the database. You can add, update and delete members. In the update only fill the values you want to update leave others empty.

#### 5. Loans table

Table showing all of the loans in the database. You can borrow books here and return books. You borrow books by inserting id of the member and id of the book.

### Reports

Reports are views from the database that show statistics for authors and books.

#### 1. Author report

This report show statistics of author like count of loans, first loan and last loan.

#### 2. Exit application

This report show statistics of book like count of loans, first loan and last return.


## Help

If you do not use MSSQL server, this app might not work.

If you need anything from me about this application contact me at:
* pavel.halik06@gmail.com
