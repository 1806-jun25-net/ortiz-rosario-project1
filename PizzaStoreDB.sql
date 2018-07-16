CREATE SCHEMA Pizza; 
GO

CREATE TABLE Pizza.Users 
(
	User_IDs INT PRIMARY KEY IDENTITY,
	LastName VARCHAR(255) NOT NULL, 
	FirstName VARCHAR (255) NOT NULL, 
	Store_ID INT NOT NULL 
	
);

SELECT * FROM Pizza.Users; 

CREATE TABLE Pizza.Locations
(
	Store_ID INT PRIMARY KEY NOT NULL, 
	Store_Location VARCHAR (255) NOT NULL,
	User_IDs INT
	CONSTRAINT FK_Store_ID FOREIGN KEY (User_IDs) REFERENCES Pizza.Users(User_IDs) 
);

SELECT * FROM Pizza.Locations; 


CREATE TABLE Pizza.Orders
(
	Order_ID INT PRIMARY KEY NOT NULL,
	OrderTime DATETIME NOT NULL, 
	Total_Price DECIMAL(2,2) NOT NULL,
	Topping_Price DECIMAL(2,2) NOT NULL,  
	Pizza_ID INT NOT NULL
);

SELECT * FROM Pizza.Orders; 

CREATE TABLE Pizza.Pizzas
(
	Pizza_ID  INT PRIMARY KEY NOT NULL IDENTITY, 
	Pizza_Price DECIMAL(2,2) NOT NULL, 
	Pizza_Sizes VARCHAR NOT NULL, 
	ToppingPrice DECIMAL(2,2) NOT NULL, 
	Ingredient_ID INT NOT NULL,
	Order_ID INT
	CONSTRAINT FK_Pizza_ID_to_Orders FOREIGN KEY (Order_ID) REFERENCES Pizza.Orders(Order_ID)

);

SELECT * FROM Pizza.Pizzas; 


CREATE TABLE Pizza.Inventory
(
	Ingredient_ID INT PRIMARY KEY IDENTITY, 
	Ingredient_Name VARCHAR NOT NULL, 
	Quantity_Ingredients INT NOT NULL, 
	Store_ID INT NOT NULL
	CONSTRAINT FK_Inventory_to_Store_ID FOREIGN KEY(Store_ID) REFERENCES Pizza.Locations(Store_ID)
);

SELECT * FROM Pizza.Inventory; 


-- Altering and Updating DB
ALTER TABLE Pizza.Locations DROP CONSTRAINT FK_Store_ID;

ALTER TABLE Pizza.Pizzas DROP CONSTRAINT FK_Pizza_ID_to_Orders; 

ALTER TABLE Pizza.Inventory DROP CONSTRAINT FK_Inventory_to_Store_ID; 

DROP TABLE Pizza.Users;

DROP TABLE Pizza.Inventory;

DROP TABLE Pizza.Locations; 

DROP TABLE Pizza.Orders;

DROP TABLE Pizza.Pizzas;


--Creating table for Pizza Store DB
-- Version 2.0 
CREATE TABLE Pizza.Users
(
	User_Ids int IDENTITY NOT NULL PRIMARY KEY, 
	First_Name varchar(255) NOT NULL, 
	Last_Name varchar(255) NOT NULL, 
	PhoneNumber varchar(255) NOT NULL,
	Store_ID INT
);


Create TABLE Pizza.Locations
(
	Store_ID int NOT NULL PRIMARY KEY, 
	Order_ID INT, 
	Store_Location VARCHAR(255) NOT NULL,
	User_Ids int FOREIGN KEY REFERENCES Pizza.Users(User_Ids) 
);

CREATE TABLE Pizza.Orders
(
	Order_ID int NOT NULL IDENTITY PRIMARY KEY,
	Order_TimeStamp DATETIME, 
	Total_Price DECIMAL(2,2) NOT NULL, 
	User_Ids int FOREIGN KEY REFERENCES Pizza.Users(User_Ids),
	Store_ID INT FOREIGN KEY REFERENCES Pizza.Locations(Store_ID),

);

CREATE TABLE Pizza.PizzasTypes
(
	Pizza_ID int IDENTITY NOT NULL PRIMARY KEY, 
	Pizza_Sizes VARCHAR(255) NOT NULL, 
	Pizza_Name VARCHAR(255) NOT NULL, 
	Order_ID int FOREIGN KEY References Pizza.Orders(Order_ID),
	Pizzas_Quantity int NOT NULL, 
	CHECK (Pizzas_Quantity >= 0)
);

SELECT * FROM Pizza.Users; 

SELECT * FROM Pizza.Locations;

SELECT * FROM Pizza.Orders; 

SELECT * FROM Pizza.PizzasTypes; 

