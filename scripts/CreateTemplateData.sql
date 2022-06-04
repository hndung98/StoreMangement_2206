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


INSERT INTO TBL_Supplier
     VALUES (N'Bách Hóa Xanh', N'bhx@gmail.com', 0909777333, 1, N'', N'', N'')


INSERT INTO TBL_Item
     VALUES (1, 1, N'Xúc xích Đức', 6000, 9000)
INSERT INTO TBL_Item
     VALUES (2, 1, N'Cocacola lon 330ml', 9200, 12000)
INSERT INTO TBL_Item
     VALUES (2, 1, N'Pepsi lon 330', 9000, 12000)

INSERT INTO TBL_Employee
     VALUES (2, N'Nguyễn Văn A', '1994-07-02', 1, 0905110402, '2022-05-02', 1, 14000000, 1, 1, 1, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (2, N'Trần Văn B', '1996-03-22', 1, 0905036402, '2022-06-02', 1, 14000000, 1, 1, 2, N'192 Lê Văn Sỹ')
INSERT INTO TBL_Employee
     VALUES (2, N'Lê Văn C', '1997-01-02', 1, 0905016632, '2022-06-02', 1, 14000000, 1, 1, 3, N'192 Lê Văn Sỹ')

	 
INSERT INTO TBL_Customer
     VALUES ( N'Tuấn Tài', '2001-01-01', 1, 0355521188, 1, 1, 1, N'18/10 đường 147')
INSERT INTO TBL_Customer
     VALUES ( N'Quang Hải', '1997-01-01', 1, 0355521112, 1, 1, 2, N'18/10 đường 147')
INSERT INTO TBL_Customer
     VALUES ( N'Công Phượng', '1995-01-01', 1, 0355521283, 1, 1, 3, N'18/10 đường 147')

GO

