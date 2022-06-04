
------------------ CREATE TABLES ------------------

CREATE TABLE TBL_Control
(
	ControlID			INT IDENTITY(1,1) NOT NULL,
	ControlGroup		NVARCHAR(10) NOT NULL,
	ControlValue		TINYINT NOT NULL,
	ControlName			NVARCHAR(50) NOT NULL,

	PRIMARY KEY (ControlID),
	UNIQUE (ControlGroup, ControlValue)
);

CREATE TABLE TBL_Supplier
(
	SupplierID			INT IDENTITY(1,1) NOT NULL,
	SupplierName		NVARCHAR(50) NOT NULL,
	Email				NVARCHAR(50) NOT NULL,
	PhoneNumber			INT NOT NULL,
	Province			TINYINT NULL,
	District			TINYINT NULL,
	Ward				TINYINT NULL,
	NumberWithStreet	NVARCHAR(50) NULL,

	PRIMARY KEY (SupplierID),
	UNIQUE (Email, PhoneNumber)
);	

CREATE TABLE TBL_Shipper
(
	ShipperID			INT IDENTITY(1,1) NOT NULL,
	ShipperName			NVARCHAR(50) NOT NULL,
	Email				NVARCHAR(50) NOT NULL,
	PhoneNumber			VARCHAR(15) NOT NULL,
	Province			TINYINT NULL,
	District			TINYINT NULL,
	Ward				TINYINT NULL,
	NumberWithStreet	NVARCHAR(50) NULL,

	PRIMARY KEY (ShipperID),
	UNIQUE (Email, PhoneNumber)
);

CREATE TABLE TBL_Voucher
(
	VoucherID			INT IDENTITY(1,1) NOT NULL,
	StartingDate		DATE NOT NULL,
	EndingDate			DATE NULL,
	DiscountRate		SMALLINT NOT NULL,
	MaximumAmount		DECIMAL(12) NULL,
	CurrentStatus		TINYINT NOT NULL,

	PRIMARY KEY (VoucherID),
);

CREATE TABLE TBL_Customer
(
	CustomerID			INT IDENTITY(1,1) NOT NULL,
	CustomerName		NVARCHAR(50) NOT NULL,
	Birthday			DATE NULL,
	Gender				TINYINT NOT NULL,
	PhoneNumber			INT NOT NULL,
	Province			TINYINT NULL,
	District			TINYINT NULL,
	Ward				TINYINT NULL,
	NumberWithStreet	NVARCHAR(50) NULL,

	PRIMARY KEY (CustomerID),
	UNIQUE (PhoneNumber),
);

CREATE TABLE TBL_Store
(
	StoreID				INT IDENTITY(1,1) NOT NULL,
	StoreName			NVARCHAR(50) NOT NULL,
	PhoneNumber			INT NOT NULL,
	Email				NVARCHAR(50) NOT NULL,
	ManagerID			INT NULL,
	MonthlyRentalCost	DECIMAL(12) NULL,
	OpeningDate			DATE NULL,						-- ClosingDate must after ClosingDate
	ClosingDate			DATE NULL,
	Province			TINYINT NULL,
	District			TINYINT NULL,
	Ward				TINYINT NULL,
	NumberWithStreet	NVARCHAR(50) NULL,

	PRIMARY KEY (StoreID),
	UNIQUE (PhoneNumber, Email),
);

CREATE TABLE TBL_ItemType
(
	ItemTypeID			INT IDENTITY(1,1) NOT NULL,
	ItemTypeName		NVARCHAR(50) NOT NULL,

	PRIMARY KEY (ItemTypeID),
);

CREATE TABLE TBL_Item
(
	ItemID				INT IDENTITY(1,1) NOT NULL,
	ItemTypeID			INT NULL,
	SupplierID			INT NULL,
	ItemName			NVARCHAR(50) NOT NULL,
	Cost				DECIMAL(12) NOT NULL,
	SuggestedPrice		DECIMAL(12) NULL,				-- SuggestedPrice >= Cost

	PRIMARY KEY (ItemID),
	FOREIGN KEY (ItemTypeID) REFERENCES TBL_ItemType(ItemTypeID),
	FOREIGN KEY (SupplierID) REFERENCES TBL_Supplier(SupplierID)
);

CREATE TABLE TBL_StoreItem
(
	StoreItemID			INT IDENTITY(1,1) NOT NULL,
	StoreID				INT NOT NULL,
	ItemID				INT NOT NULL,
	Price				DECIMAL(12) NOT NULL,

	PRIMARY KEY (StoreItemID),
	FOREIGN KEY (StoreID) REFERENCES TBL_Store(StoreID),
	FOREIGN KEY (ItemID) REFERENCES TBL_Item(ItemID)
);

CREATE TABLE TBL_Employee
(
	EmployeeID			INT IDENTITY(1,1) NOT NULL,
	StoreID				INT NOT NULL,
	EmployeeName		NVARCHAR(50) NOT NULL,
	Birthday			DATE NOT NULL,
	Gender				TINYINT NOT NULL,
	PhoneNumber			INT NOT NULL,
	StartingDate		DATE NOT NULL,
	WorkingStatus		TINYINT NOT NULL,
	Salary				DECIMAL(12) NOT NULL,
	Province			TINYINT NULL,
	District			TINYINT NULL,
	Ward				TINYINT NULL,
	NumberWithStreet	NVARCHAR(50) NULL,

	PRIMARY KEY (EmployeeID),
	FOREIGN KEY (StoreID) REFERENCES TBL_Store(StoreID)
);

CREATE TABLE TBL_WorkHour
(
	WorkHourID			INT IDENTITY(1,1) NOT NULL,
	EmployeeID			INT NOT NULL,
	WorkDate			DATE NOT NULL,
	StartingTime		TIME NOT NULL,
	EndingTime			TIME NOT NULL,
	Note				NVARCHAR(100) NULL,

	PRIMARY KEY (WorkHourID),
	FOREIGN KEY (EmployeeID) REFERENCES TBL_Employee(EmployeeID)

);

CREATE TABLE TBL_Inventory
(
	InventoryID			INT IDENTITY(1,1) NOT NULL,
	StoreID				INT NOT NULL,
	StoreItemID			INT NOT NULL,
	Quantity			SMALLINT NOT NULL,
	MinimumQuantity		SMALLINT NULL,

	PRIMARY KEY (InventoryID),
	FOREIGN KEY (StoreID) REFERENCES TBL_Store(StoreID),
	FOREIGN KEY (StoreItemID) REFERENCES TBL_StoreItem(StoreItemID)
);

CREATE TABLE TBL_SalesHeader
(
	SalesHeaderID		INT IDENTITY(1,1) NOT NULL,
	StoreID				INT NOT NULL,
	EmployeeID			INT NOT NULL,
	CustomerID			INT NULL,
	VoucherID			INT NULL,
	ShipperID			INT NULL,
	TotalPrice			DECIMAL(12) NOT NULL,
	Discount			SMALLINT NULL,
	CurrentStatus		TINYINT NOT NULL,
	CreatedDate			DATE NOT NULL,
	PRIMARY KEY (SalesHeaderID),
	FOREIGN KEY (StoreID) REFERENCES TBL_Store(StoreID),
	FOREIGN KEY (EmployeeID) REFERENCES TBL_Employee(EmployeeID),
	FOREIGN KEY (CustomerID) REFERENCES TBL_Customer(CustomerID),
	FOREIGN KEY (VoucherID) REFERENCES TBL_Voucher(VoucherID),
	FOREIGN KEY (ShipperID) REFERENCES TBL_Shipper(ShipperID)
);

CREATE TABLE TBL_SalesDetails
(
	SalesDetailsID		INT IDENTITY(1,1) NOT NULL,
	SalesHeaderID		INT NOT NULL,
	StoreItemID			INT NOT NULL,
	Quantity			SMALLINT NOT NULL,

	PRIMARY KEY (SalesDetailsID),
	FOREIGN KEY (SalesHeaderID) REFERENCES TBL_SalesHeader(SalesHeaderID),
	FOREIGN KEY (StoreItemID) REFERENCES TBL_StoreItem(StoreItemID),
);

CREATE TABLE TBL_InputHeader
(
	InputHeaderID		INT IDENTITY(1,1) NOT NULL,
	EmployeeID			INT NOT NULL,
	CreatedDate			DATE NOT NULL,

	PRIMARY KEY (InputHeaderID),
	FOREIGN KEY (EmployeeID) REFERENCES TBL_Employee(EmployeeID),

);

CREATE TABLE TBL_InputDetails
(
	InputDetailsID		INT IDENTITY(1,1) NOT NULL,
	InputHeaderID		INT NOT NULL,
	StoreItemID			INT NOT NULL,
	Quantity			SMALLINT NOT NULL,

	PRIMARY KEY (InputDetailsID),
	FOREIGN KEY (StoreItemID) REFERENCES TBL_StoreItem(StoreItemID),
);

CREATE TABLE TBL_CancelHeader
(
	CancelHeaderID		INT IDENTITY(1,1) NOT NULL,
	EmployeeID			INT NOT NULL,
	CreatedDate			DATE NOT NULL,

	PRIMARY KEY (CancelHeaderID),
	FOREIGN KEY (EmployeeID) REFERENCES TBL_Employee(EmployeeID),
);

CREATE TABLE TBL_CancelDetails
(
	CancelDetailsID		INT IDENTITY(1,1) NOT NULL,
	CancelHeaderID		INT NOT NULL,
	StoreItemID			INT NOT NULL,
	Quantity			SMALLINT NOT NULL,

	PRIMARY KEY (CancelDetailsID),
	FOREIGN KEY (CancelHeaderID) REFERENCES TBL_CancelHeader(CancelHeaderID),
	FOREIGN KEY (StoreItemID) REFERENCES TBL_StoreItem(StoreItemID),
);


/* DROP TABLES


DECLARE @sql nvarchar(max) = N'';

;WITH x AS 
(
  SELECT DISTINCT obj = 
      QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id)) + '.' 
    + QUOTENAME(OBJECT_NAME(parent_object_id)) 
  FROM sys.foreign_keys
)
SELECT @sql += 'ALTER TABLE [' +  OBJECT_SCHEMA_NAME(parent_object_id) +
    '].[' + OBJECT_NAME(parent_object_id) + 
    '] DROP CONSTRAINT [' + name + ']'
FROM sys.foreign_keys
WHERE referenced_object_id = object_id('StoreManagement')
    
EXEC sys.sp_executesql @sql;


DECLARE @sql NVARCHAR(max)=''

SELECT @sql += ' Drop table ' + QUOTENAME(TABLE_SCHEMA) + '.'+ QUOTENAME(TABLE_NAME) + '; '
FROM   INFORMATION_SCHEMA.TABLES
WHERE  TABLE_TYPE = 'BASE TABLE'

Exec Sp_executesql @sql

*/