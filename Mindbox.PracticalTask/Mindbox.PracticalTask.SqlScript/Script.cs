/*
 
CREATE TABLE Products (
    Id INT PRIMARY KEY,
    "Name" TEXT
);

INSERT INTO Products
VALUES (1, 'Product1'), (2, 'Product2'), (3, 'Product3');

CREATE TABLE Categories (
    Id INT PRIMARY KEY,
    "Name" TEXT
);

INSERT INTO Categories
VALUES (1, 'Category1'), (2, 'Category2'), (3, 'Category3');

CREATE TABLE ProductCategories (
    ProductId INT FOREIGN KEY REFERENCES Products(Id),
    CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
    PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES (1, 1), (2, 3), (3, 3);

SELECT P."Name", C."Name"
FROM Products P 
LEFT JOIN ProductCategories PC ON P.Id = PC.ProductId
LEFT JOIN Categories C ON PC.CategoryId = C.Id;

*/