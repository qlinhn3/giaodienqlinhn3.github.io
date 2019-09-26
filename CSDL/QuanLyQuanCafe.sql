CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

--food
--table
--foodcategory
--acoount
--bill
--billinfor
CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) DEFAULT N'Bàn chưa đặt tên' ,
	status NVARCHAR(100) NOT NULL,
)
GO

CREATE TABLE Account
(
	--id INT IDENTITY PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL,
	UserName NVARCHAR(100) PRIMARY KEY,
	PassWord NVARCHAR(1000) NOT NULL,
	Type INT DEFAULT 0,
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) DEFAULT N'Chưa đặt tên' ,
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0, 
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckin DATE DEFAULT GETDATE(),
	DateCheckout DATE ,
	status INT NOT NULL DEFAULT 0,
	idTable INT NOT NULL,
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfor
(
id INT IDENTITY PRIMARY KEY,
idBill INT NOT NULL ,
idFood INT NOT NULL,
count INT NOT NULL,
 FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
 FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
go