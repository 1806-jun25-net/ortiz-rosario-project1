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
