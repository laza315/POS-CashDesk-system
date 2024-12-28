DROP TABLE IF EXISTS Guest_Table;
DROP TABLE IF EXISTS Billing_History;
DROP TABLE IF EXISTS Article;
DROP TABLE IF EXISTS Category;
DROP TABLE IF EXISTS Users;

CREATE TABLE Users (
    ID INT PRIMARY KEY IDENTITY(1,1), 
    username VARCHAR(255) NOT NULL,
    u_password VARCHAR(255) NOT NULL,
    is_active TINYINT NOT NULL,
    u_role VARCHAR(10) NOT NULL CHECK (u_role IN ('waiter', 'manager'))
);

CREATE TABLE Guest_Table (
    ID INT PRIMARY KEY IDENTITY(1,1), 
    table_number INT NOT NULL,
    UsersID INT,
    FOREIGN KEY (UsersID) REFERENCES Users(ID)
);

CREATE TABLE Billing_History (
    ID INT PRIMARY KEY IDENTITY(1,1), 
    amount DECIMAL(10, 2) NOT NULL, 
    order_status VARCHAR(10) NOT NULL CHECK (order_status IN ('billed', 'not-billed')),
    created_at DATETIME,
    GuestTableID INT, 
    FOREIGN KEY (GuestTableID) REFERENCES Guest_Table(ID)
);

CREATE TABLE Category (
    ID INT PRIMARY KEY IDENTITY(1,1), 
    name VARCHAR(50)
);

CREATE TABLE Article (
    ID INT PRIMARY KEY IDENTITY(1,1), 
    article_name VARCHAR(50),
    purchase_price INT,
    retail_price INT,
    CategoryID INT,  
    FOREIGN KEY (CategoryID) REFERENCES Category(ID)
);
