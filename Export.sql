-- ========================================
-- Project name: Library database manager
-- Author name: Pavel Halík
-- Email: pavel.halik06@gmail.com
-- ========================================

USE master;
GO

IF DB_ID('library') IS NULL
BEGIN
    CREATE DATABASE [library];
END
GO

USE [library];
GO

-- =====================
-- DATABASE SETTINGS
-- =====================
ALTER DATABASE [library] SET ANSI_NULL_DEFAULT OFF;
ALTER DATABASE [library] SET ANSI_NULLS OFF;
ALTER DATABASE [library] SET ANSI_PADDING OFF;
ALTER DATABASE [library] SET ANSI_WARNINGS OFF;
ALTER DATABASE [library] SET ARITHABORT OFF;
ALTER DATABASE [library] SET AUTO_CLOSE OFF;
ALTER DATABASE [library] SET AUTO_SHRINK OFF;
ALTER DATABASE [library] SET AUTO_UPDATE_STATISTICS ON;
ALTER DATABASE [library] SET CURSOR_CLOSE_ON_COMMIT OFF;
ALTER DATABASE [library] SET CURSOR_DEFAULT GLOBAL;
ALTER DATABASE [library] SET CONCAT_NULL_YIELDS_NULL OFF;
ALTER DATABASE [library] SET NUMERIC_ROUNDABORT OFF;
ALTER DATABASE [library] SET QUOTED_IDENTIFIER OFF;
ALTER DATABASE [library] SET RECURSIVE_TRIGGERS OFF;
ALTER DATABASE [library] SET DISABLE_BROKER;
ALTER DATABASE [library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF;
ALTER DATABASE [library] SET DATE_CORRELATION_OPTIMIZATION OFF;
ALTER DATABASE [library] SET TRUSTWORTHY OFF;
ALTER DATABASE [library] SET ALLOW_SNAPSHOT_ISOLATION OFF;
ALTER DATABASE [library] SET PARAMETERIZATION SIMPLE;
ALTER DATABASE [library] SET READ_COMMITTED_SNAPSHOT OFF;
ALTER DATABASE [library] SET HONOR_BROKER_PRIORITY OFF;
ALTER DATABASE [library] SET RECOVERY FULL;
ALTER DATABASE [library] SET MULTI_USER;
ALTER DATABASE [library] SET PAGE_VERIFY CHECKSUM;
ALTER DATABASE [library] SET DB_CHAINING OFF;
ALTER DATABASE [library] SET TARGET_RECOVERY_TIME = 60 SECONDS;
ALTER DATABASE [library] SET DELAYED_DURABILITY = DISABLED;
ALTER DATABASE [library] SET ACCELERATED_DATABASE_RECOVERY = OFF;
GO

-- =====================
-- TABLES
-- =====================

IF OBJECT_ID('Author', 'U') IS NULL
CREATE TABLE Author (
    id INT IDENTITY(1,1) PRIMARY KEY,
    firstName VARCHAR(50) NOT NULL,
    lastName VARCHAR(50) NOT NULL
);
GO

IF OBJECT_ID('Category', 'U') IS NULL
CREATE TABLE Category (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);
GO

IF OBJECT_ID('Members', 'U') IS NULL
CREATE TABLE Members (
    id INT IDENTITY(1,1) PRIMARY KEY,
    firstName VARCHAR(50) NOT NULL,
    lastName VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL
);
GO

IF OBJECT_ID('Book', 'U') IS NULL
CREATE TABLE Book (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    categoryId INT NULL,
    authorId INT NULL,
    isAvailable BIT NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    state VARCHAR(10) NOT NULL,
    CONSTRAINT CK_Book_State CHECK (state IN ('Used','Damaged','New'))
);
GO

IF OBJECT_ID('Loan', 'U') IS NULL
CREATE TABLE Loan (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    memberId INT NULL,
    bookId INT NULL,
    loanDate DATETIME NOT NULL,
    returnDate DATETIME NULL
);
GO

-- =====================
-- FOREIGN KEYS
-- =====================

ALTER TABLE Book
ADD CONSTRAINT FK_Book_Author
FOREIGN KEY (authorId) REFERENCES Author(id);
GO

ALTER TABLE Book
ADD CONSTRAINT FK_Book_Category
FOREIGN KEY (categoryId) REFERENCES Category(id);
GO

ALTER TABLE Loan
ADD CONSTRAINT FK_Loan_Book
FOREIGN KEY (bookId) REFERENCES Book(Id);
GO

ALTER TABLE Loan
ADD CONSTRAINT FK_Loan_Member
FOREIGN KEY (memberId) REFERENCES Members(id);
GO

-- =====================
-- VIEWS
-- =====================

CREATE OR ALTER VIEW authorLoanStats AS
SELECT
    a.firstName + ' ' + a.lastName AS AuthorName,
    COUNT(l.id) AS LoanCount,
    MIN(l.loanDate) AS FirstLoan,
    MAX(l.loanDate) AS LastLoan
FROM Author a
JOIN Book b ON b.authorId = a.id
JOIN Loan l ON l.bookId = b.id
GROUP BY a.firstName, a.lastName;
GO

CREATE OR ALTER VIEW bookLoanStats AS
SELECT
    b.title AS BookTitle,
    c.name AS Category,
    COUNT(l.id) AS LoanCount,
    MIN(l.loanDate) AS FirstLoan,
    MAX(l.returnDate) AS LastReturn
FROM Book b
JOIN Category c ON b.categoryId = c.id
LEFT JOIN Loan l ON l.bookId = b.id
GROUP BY b.title, c.name;
GO
