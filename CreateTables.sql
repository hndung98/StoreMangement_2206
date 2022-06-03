
------------------ CREATE TABLES ------------------

CREATE TABLE Store
(
	StoreID				INT IDENTITY(1,1) NOT NULL,
	StoreName			NVARCHAR(50) NOT NULL,
	PhoneNumber			INT NOT NULL,
	Email				NVARCHAR(50) NOT NULL,
	ManagerID			INT NULL,
	MonthlyRentalCost	DECIMAL(12) NULL,
	OpeningDate			DATE NULL,						-- ClosingDate must after ClosingDate
	ClosingDate			DATE NULL,
	FullAddress			NVARCHAR(100) NOT NULL,

	PRIMARY KEY (StoreID),
	UNIQUE (PhoneNumber, Email),
);


CREATE TABLE Item
(
	ItemID				INT IDENTITY(1,1) NOT NULL,
	SupplierID			INT NOT NULL,
	ItemType			INT NULL,
	ItemName			NVARCHAR(40) NOT NULL,
	Cost				DECIMAL(12) NOT NULL,
	SuggestedPrice		DECIMAL(12) NULL,

	PRIMARY KEY (ItemID),
);

CREATE TABLE StoreItem
(
	StoreItemID			INT IDENTITY(1,1) NOT NULL,
	StoreID				INT NOT NULL,
	ItemID				INT NOT NULL,
	Price				DECIMAL(12) NOT NULL,

	PRIMARY KEY (StoreItemID),
	FOREIGN KEY (StoreID) REFERENCES Store(StoreID),
	FOREIGN KEY (ItemID) REFERENCES Item(ItemID)
);

CREATE TABLE Employee
(
	EmployeeID			INT IDENTITY(1,1) NOT NULL,
	StoreID				INT NOT NULL,
	EmployeeName		NVARCHAR(50) NOT NULL,
	Birthday			DATE NOT NULL,
	Gender				CHAR(1) NOT NULL,		--convention
	PhoneNumber			INT	UNIQUE NOT NULL,
	StartingDate		DATE NOT NULL,
	WorkingStatus		CHAR(1) NOT NULL,		--convention
	Salary				DECIMAL(12) NOT NULL,
	FullAddress			NVARCHAR(50) NOT NULL,

	PRIMARY KEY (EmployeeID),
	FOREIGN KEY (StoreID) REFERENCES Store(StoreID)
);

CREATE TABLE WorkHour
(
	WorkHourID			INT IDENTITY(1,1) NOT NULL,
	EmployeeID			INT NOT NULL,
	WorkDate			DATE NOT NULL,
	StartingTime		TIME NOT NULL,
	EndingTime			TIME NOT NULL,
	Note				NVARCHAR(100) NULL,

	PRIMARY KEY (WorkHourID),

);

CREATE TABLE Customer
(
	CustomerID			INT IDENTITY(1,1) NOT NULL,
	CustomerName		NVARCHAR(50) NOT NULL,
	Birthday			DATE NULL,
	Gender				NVARCHAR(5) NOT NULL,
	PhoneNumber			INT NOT NULL,
	FullAddress			NVARCHAR(50) NOT NULL,
);

CREATE TABLE Inventory
(
	InventoryID			INT IDENTITY(1,1) NOT NULL,
	StoreID				INT NOT NULL,
	StoreItemID			INT NOT NULL,
	Quantity			smallint NOT NULL,
	MinimumQuantity		smallint NOT NULL,

	PRIMARY KEY (InventoryID),
);

CREATE TABLE SalesHeader
(
	SalesHeaderID		INT IDENTITY(1,1) NOT NULL,
	StoreID				INT NOT NULL,
	EmployeeID			INT NOT NULL,
	CustomerID			INT NOT NULL,
	VoucherID			INT NOT NULL,
	ShipperID			INT NOT NULL,
	TotalPrice			DECIMAL(12) NOT NULL,
	Discount			smallint NOT NULL,		--unit %
	CurrentStatus		CHAR(1) NOT NULL,
	CreatedDate			DATE NOT NULL,
	PRIMARY KEY (SalesHeaderID),
);

CREATE TABLE SalesDetails
(
	SalesDetailsID		INT IDENTITY(1,1) NOT NULL,
	SalesHeaderID		INT NOT NULL,
	StoreItemID			INT NOT NULL,
	Quantity			smallint NOT NULL,
	PRIMARY KEY (SalesDetailsID),
);

CREATE TABLE InputHeader
(
	InputHeaderID		INT IDENTITY(1,1) NOT NULL,
	InventoryID			INT NOT NULL,
	EmployeeID			INT NOT NULL,
	CreatedDate			DATE NOT NULL,
	PRIMARY KEY (InputHeaderID),

);

CREATE TABLE InputDetails
(
	InputDetailsID		INT IDENTITY(1,1) NOT NULL,
	StoreItemID			INT NOT NULL,
	Quantity			smallint NOT NULL,
	PRIMARY KEY (InputDetailsID),
);

CREATE TABLE CancelHeader
(
	CancelHeaderID		INT IDENTITY(1,1) NOT NULL,
	InventoryID			INT NOT NULL,
	EmployeeID			INT NOT NULL,
	CreatedDate			DATE NOT NULL,
	PRIMARY KEY (CancelHeaderID),
);

CREATE TABLE CancelDetails
(
	CancelDetailsID		INT IDENTITY(1,1) NOT NULL,
	StoreItemID			INT NOT NULL,
	Quantity			smallint NOT NULL,
	PRIMARY KEY (CancelDetailsID),
);

CREATE TABLE Voucher
(
	VoucherID			INT IDENTITY(1,1) NOT NULL,
	StartingDate		DATE NOT NULL,
	EndingDate			DATE NOT NULL,
	DiscountRate		smallint NOT NULL,	--unit %
	MaximumAmount		smallint NOT NULL,
	CurrentStatus		CHAR(1) NOT NULL,

	PRIMARY KEY (VoucherID),
);

CREATE TABLE Supplier
(
	SupplierID			INT IDENTITY(1,1) NOT NULL,
	SupplierName		NVARCHAR(40) NOT NULL,
	Email				NVARCHAR(40) NOT NULL,
	PhoneNumber			INT NOT NULL,
	FullAddress			NVARCHAR(50) NOT NULL,

	PRIMARY KEY (SupplierID),
);	

CREATE TABLE Shipper
(
	ShipperID			INT IDENTITY(1,1) NOT NULL,
	ShipperName			NVARCHAR(50) NOT NULL,
	Email				NVARCHAR(50) NOT NULL,
	PhoneNumber			VARCHAR(15) NOT NULL,
	FullAddress			NVARCHAR(50) NOT NULL,

	PRIMARY KEY (ShipperID),
);


-- DROP TABLES
DECLARE @sql NVARCHAR(max)=''

SELECT @sql += ' Drop table ' + QUOTENAME(TABLE_SCHEMA) + '.'+ QUOTENAME(TABLE_NAME) + '; '
FROM   INFORMATION_SCHEMA.TABLES
WHERE  TABLE_TYPE = 'BASE TABLE'

Exec Sp_executesql @sql
