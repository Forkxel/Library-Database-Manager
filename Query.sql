CREATE TABLE Author (
    id INT IDENTITY(1,1) PRIMARY KEY,
    firstName VARCHAR(50) NOT NULL,
    lastName VARCHAR(50) NOT NULL
);

CREATE TABLE Category (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);

CREATE TABLE Members (
    id INT IDENTITY(1,1) PRIMARY KEY,
    firstName VARCHAR(50) NOT NULL,
    lastName VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL
);

CREATE TABLE Book (
    Id INT IDENTITY(1,1) PRIMARY KEY,
	title VARCHAR(100) NOT NULL,
	categoryId INT FOREIGN KEY (categoryId) REFERENCES Category(id),
	authorId int foreign key (authorId) references Author(id),
	isAvailable BIT NOT NULL,    
    price DECIMAL(10,2) NOT NULL,                  

    state VARCHAR(10) NOT NULL           
        CHECK (state IN ('New', 'Damaged', 'Used')),
);

CREATE TABLE Loan (
    Id INT IDENTITY(1,1) PRIMARY KEY,
	memberId int foreign key (memberId) REFERENCES Members(id),
	bookId int foreign key (bookId) REFERENCES Book(id),
    loanDate DATETIME NOT NULL,
    returnDate DATETIME NULL,
);


INSERT INTO Author (firstName, lastName)
VALUES ('George', 'Orwell');

INSERT INTO Category (name)
VALUES ('Dystopia');

INSERT INTO Book (title, categoryId, authorId, isAvailable, price, state)
VALUES ('1984', 1, 1, 1, 299.90, 'New');

CREATE VIEW authorLoanStats AS
SELECT
    a.firstName + ' ' + a.lastName AS AuthorName,
    COUNT(l.id) AS LoanCount,
    MIN(l.loanDate) AS FirstLoan,
    MAX(l.loanDate) AS LastLoan
FROM Author a
JOIN Book b ON b.authorId = a.id
JOIN Loan l ON l.bookId = b.id
GROUP BY a.firstName, a.lastName;

CREATE VIEW bookLoanStats AS
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
