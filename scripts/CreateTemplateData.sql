USE [StoreManagement]
GO

/*
DECLARE @sql NVARCHAR(max)=''

SELECT @sql += ' Delete from ' + QUOTENAME(TABLE_SCHEMA) + '.'+ QUOTENAME(TABLE_NAME) + '; '
FROM   INFORMATION_SCHEMA.TABLES
WHERE  TABLE_TYPE = 'BASE TABLE'

SELECT @sql

Exec Sp_executesql @sql
*/

INSERT INTO TBL_Control
     VALUES ( N'Gender', 1, N'Nam')
INSERT INTO TBL_Control
     VALUES ( N'Gender', 2, N'Nữ')
INSERT INTO TBL_Control
     VALUES ( N'Gender', 3, N'Khác')
INSERT INTO TBL_Control
     VALUES ( N'Province', 1, N'TP Hồ Chí Minh')
INSERT INTO TBL_Control
     VALUES ( N'TP Hồ Chí Minh', 1, N'Quận 3')
INSERT INTO TBL_Control
     VALUES ( N'TP Hồ Chí Minh', 2, N'Quận 10')
INSERT INTO TBL_Control
     VALUES ( N'TP Hồ Chí Minh', 3, N'TP Thủ Đức')
INSERT INTO TBL_Control
     VALUES ( N'TP Hồ Chí Minh', 4, N'Quận Tân Bình')
INSERT INTO TBL_Control
     VALUES ( N'Quận 3', 1, N'Phường 1')
INSERT INTO TBL_Control
     VALUES ( N'Quận 3', 2, N'Phường 2')
INSERT INTO TBL_Control
     VALUES ( N'Quận 3', 3, N'Phường 3')
INSERT INTO TBL_Control
     VALUES ( N'ItemType', 1, N'Đồ ăn')
INSERT INTO TBL_Control
     VALUES ( N'ItemType', 2, N'Đồ uống')


INSERT INTO TBL_Store
VALUES (N'Sài Gòn 1', 0909121333, N'saigon1@gmail.com', null, 10000000, '2022-06-01', null, 1, 1, 1, N'278 Tô Hiến Thành')
INSERT INTO TBL_Store
VALUES (N'Sài Gòn 2', 0909121333, N'saigon2@gmail.com', null, 10000000, '2022-06-01', null, 1, 1, 2, N'')
INSERT INTO TBL_Store
VALUES (N'Sài Gòn 3', 0909121333, N'saigon3@gmail.com', null, 10000000, '2022-06-01', null, 1, 1, 3, N'')


INSERT INTO TBL_ItemType
     VALUES (N'Đồ ăn')
INSERT INTO TBL_ItemType
     VALUES (N'Đồ uống')
INSERT INTO TBL_ItemType
     VALUES (N'Khác')


INSERT INTO TBL_Supplier
     VALUES (N'Bách Hóa Xanh', N'bhx@gmail.com', 0909777333, 1, N'', N'', N'')


INSERT INTO TBL_Item
     VALUES (1, 1, N'Mì tôm hảo hảo', 3000, 5000)
INSERT INTO TBL_Item
     VALUES (2, 1, N'Cocacola lon 330ml', 9200, 12000)
INSERT INTO TBL_Item
     VALUES (2, 1, N'Pepsi lon 330', 9000, 12000)
INSERT INTO TBL_Item
     VALUES (1, 1, N'Xúc xích heo vissan', 18000, 22000)
INSERT INTO TBL_Item
     VALUES (1, 1, N'Cá viên hộp', 29000, 33000)
INSERT INTO TBL_Item
     VALUES (1, 1, N'Khô gà', 53000, 61000)
INSERT INTO TBL_Item
     VALUES (1, 1, N'Khô bò', 130000, 150000)
INSERT INTO TBL_Item
     VALUES (2, 1, N'Nước ép cam', 10000, 12000)
INSERT INTO TBL_Item
     VALUES (2, 1, N'Nước ép vải', 10000, 12000)
INSERT INTO TBL_Item
     VALUES (2, 1, N'Trà đào', 9000, 11000)


INSERT INTO [dbo].[TBL_StoreItem]
     VALUES (1,1,5000)
INSERT INTO [dbo].[TBL_StoreItem]
     VALUES (1,2,12000)
INSERT INTO [dbo].[TBL_StoreItem]
     VALUES (1,3,12000)
INSERT INTO [dbo].[TBL_StoreItem]
     VALUES (1,4,22000)
INSERT INTO [dbo].[TBL_StoreItem]
     VALUES (1,5,33000)
INSERT INTO [dbo].[TBL_StoreItem]
     VALUES (1,6,61000)

INSERT INTO [dbo].[TBL_StoreItem]
     VALUES (2,1,5000)
INSERT INTO [dbo].[TBL_StoreItem]
     VALUES (2,2,12000)
INSERT INTO [dbo].[TBL_StoreItem]
     VALUES (2,3,12000)
INSERT INTO [dbo].[TBL_StoreItem]
     VALUES (2,4,22000)
INSERT INTO [dbo].[TBL_StoreItem]
     VALUES (2,5,33000)
INSERT INTO [dbo].[TBL_StoreItem]
     VALUES (2,6,61000)


INSERT INTO [dbo].[TBL_Inventory]
     VALUES (1, 1, 50, 10)
INSERT INTO [dbo].[TBL_Inventory]
     VALUES (1, 2, 50, 10)
INSERT INTO [dbo].[TBL_Inventory]
     VALUES (1, 3, 50, 10)
INSERT INTO [dbo].[TBL_Inventory]
     VALUES (1, 4, 50, 10)
INSERT INTO [dbo].[TBL_Inventory]
     VALUES (1, 5, 50, 10)
INSERT INTO [dbo].[TBL_Inventory]
     VALUES (1, 6, 50, 10)
	 
INSERT INTO [dbo].[TBL_Inventory]
     VALUES (2, 1, 50, 10)
INSERT INTO [dbo].[TBL_Inventory]
     VALUES (2, 2, 50, 10)
INSERT INTO [dbo].[TBL_Inventory]
     VALUES (2, 3, 50, 10)
INSERT INTO [dbo].[TBL_Inventory]
     VALUES (2, 4, 50, 10)
INSERT INTO [dbo].[TBL_Inventory]
     VALUES (2, 5, 50, 10)
INSERT INTO [dbo].[TBL_Inventory]
     VALUES (2, 6, 50, 10)

INSERT INTO TBL_Employee
     VALUES (2, N'Nguyễn Văn A', '1994-07-02', 1, 0905110402, '2022-05-02', 1, 16000000, 1, 1, 1, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (2, N'Trần Văn B', '1996-03-22', 1, 0905036402, '2022-06-02', 1, 7000000, 1, 1, 2, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (2, N'Lê Văn C', '1997-01-02', 1, 0905016632, '2022-06-02', 1, 7400000, 1, 1, 3, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (2, N'Lê Văn X', '1997-01-02', 1, 0905016632, '2022-06-02', 1, 7200000, 1, 1, 3, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (3, N'Nguyễn Văn D', '1994-07-02', 1, 0905110402, '2022-05-02', 1, 15000000, 1, 1, 1, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (3, N'Trần Văn E', '1996-03-22', 1, 0905036402, '2022-06-02', 1, 7700000, 1, 1, 2, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (3, N'Lê Văn F', '1997-01-02', 1, 0905016632, '2022-06-02', 1, 7200000, 1, 1, 3, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (3, N'Lê Văn G', '1997-01-02', 1, 0905016632, '2022-06-02', 1, 7200000, 1, 1, 3, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (1, N'Nguyễn Văn D', '1994-07-02', 1, 0905110402, '2022-05-02', 1, 15000000, 1, 1, 1, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (1, N'Trần Văn E', '1996-03-22', 1, 0905036402, '2022-06-02', 1, 7700000, 1, 1, 2, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (1, N'Lê Văn F', '1997-01-02', 1, 0905016632, '2022-06-02', 1, 7200000, 1, 1, 3, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (1, N'Lê Văn G', '1997-01-02', 1, 0905016632, '2022-06-02', 1, 7200000, 1, 1, 3, N'192 Lê Văn Sỹ')

	 
INSERT INTO TBL_Customer
     VALUES ( N'Tuấn Tài', '2001-01-01', 1, 0355521188, 1, 1, 1, N'18/10 đường 147')
INSERT INTO TBL_Customer
     VALUES ( N'Quang Hải', '1997-01-01', 1, 0355521112, 1, 1, 2, N'18/10 đường 147')
INSERT INTO TBL_Customer
     VALUES ( N'Công Phượng', '1995-01-01', 1, 0355521283, 1, 1, 3, N'18/10 đường 147')

	 
INSERT INTO [dbo].[TBL_SalesHeader]
     VALUES ( 1, 12, 1, null, null, 0, null, 1 , '2022-06-11')
INSERT INTO [dbo].[TBL_SalesHeader]
     VALUES ( 1, 13, null, null, null, 0, null, 1 , '2022-06-11')
INSERT INTO [dbo].[TBL_SalesHeader]
     VALUES ( 1, 13, null, null, null, 0, null, 1 , '2022-06-11')
INSERT INTO [dbo].[TBL_SalesHeader]
     VALUES ( 1, 12, null, null, null, 0, null, 1 , '2022-06-11')
INSERT INTO [dbo].[TBL_SalesHeader]
     VALUES ( 2, 2, 1, null, null, 0, null, 1 , '2022-06-11')
INSERT INTO [dbo].[TBL_SalesHeader]
     VALUES ( 2, 3, null, null, null, 0, null, 1 , '2022-06-11')
INSERT INTO [dbo].[TBL_SalesHeader]
     VALUES ( 2, 3, null, null, null, 0, null, 1 , '2022-06-11')
INSERT INTO [dbo].[TBL_SalesHeader]
     VALUES ( 2, 2, null, null, null, 0, null, 1 , '2022-06-11')


INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 1, 1, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 1, 2, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 1, 3, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 2, 4, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 2, 5, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 2, 6, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 3, 1, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 3, 2, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 4, 3, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 4, 4, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 4, 5, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 4, 6, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 5, 1, 7)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 5, 2, 7)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 5, 3, 7)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 6, 4, 7)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 6, 5, 7)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 6, 6, 7)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 7, 1, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 7, 2, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 4, 3, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 7, 4, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 7, 5, 5)
INSERT INTO [dbo].[TBL_SalesDetails]
     VALUES ( 8, 6, 5)


INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 1, '2022-06-01', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 1, '2022-06-02', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 1, '2022-06-03', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 1, '2022-06-04', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 1, '2022-06-05', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 1, '2022-06-06', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 1, '2022-06-07', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 1, '2022-06-08', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 1, '2022-06-09', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 1, '2022-06-10', '08:00:00.0', '17:00:00.0', null)


INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 2, '2022-06-01', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 2, '2022-06-02', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 2, '2022-06-03', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 2, '2022-06-04', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 2, '2022-06-05', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 2, '2022-06-06', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 2, '2022-06-07', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 2, '2022-06-08', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 2, '2022-06-09', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 2, '2022-06-10', '08:00:00.0', '17:00:00.0', null)


INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 3, '2022-06-01', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 3, '2022-06-02', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 3, '2022-06-03', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 3, '2022-06-04', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 3, '2022-06-05', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 3, '2022-06-06', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 3, '2022-06-07', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 3, '2022-06-08', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 3, '2022-06-09', '08:00:00.0', '17:00:00.0', null)
INSERT INTO [dbo].[TBL_WorkHour]
     VALUES ( 3, '2022-06-10', '08:00:00.0', '17:00:00.0', null)

GO

