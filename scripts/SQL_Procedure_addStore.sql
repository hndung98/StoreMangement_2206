--IF EXISTS ( SELECT * 
--            FROM   sysobjects 
--            WHERE  id = object_id(N'[dbo].[addStore]') 
--                   and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
--BEGIN
--    DROP PROCEDURE [dbo].[addStore]
--END

CREATE OR ALTER PROCEDURE [dbo].[addStore](
@StoreName AS nvarchar(50),
@PhoneNumber AS int,
@Email AS nvarchar(50),
@ManagerID AS int,
@RentalCost AS decimal(12),
@OpenningDate AS date,
@ClosingDate AS date,
@Province AS tinyint,  
@District AS tinyint,
@Ward AS tinyint,
@Details AS nvarchar(50),
@MessageResult AS nvarchar(100) OUT
)
AS
BEGIN
	DECLARE @allow AS bit
	DECLARE @createdDate AS date
	SET @allow = 1
	SET @createdDate = convert(date, getdate())
	IF (@StoreName is null 
	or @PhoneNumber is null 
	or @Email is null)
	BEGIN
		SET @allow = 0
		SET @MessageResult = N'StoreName, PhoneNumber, Email must be not null.'
		print @MessageResult 
		
	END
	ELSE IF (@StoreName = '')
	BEGIN
		SET @allow = 0
		SET @MessageResult = N'StoreName is empty.'
		print @MessageResult 
	END
	ELSE IF (@PhoneNumber = 0)
	BEGIN
		SET @allow = 0
		SET @MessageResult = N'PhoneNumber is empty.'
		print @MessageResult 
	END
	ELSE IF @PhoneNumber in (SELECT PhoneNumber FROM TBL_Store)
	BEGIN
		SET @allow = 0
		SET @MessageResult = N'PhoneNumber already exists.'
		print @MessageResult 
	END  
	ELSE IF (@Email = '')
	BEGIN
		SET @allow = 0
		SET @MessageResult = N'Email is empty.'
		print @MessageResult 
	END
	ELSE IF @Email in (SELECT Email FROM TBL_Store)
	BEGIN
		SET @allow = 0
		SET @MessageResult = N'Email already exists.'
		print @MessageResult 
	END  
	ELSE
	BEGIN
		IF @Email LIKE '%@%.%'
			AND CHARINDEX(' ',@Email) = 0
			AND CHARINDEX('.@',@Email) = 0
			AND CHARINDEX(',',@Email) = 0
			AND CHARINDEX('..',@Email) = 0
			AND @Email NOT LIKE '%@%@%'
		BEGIN
			IF @ManagerID is not null
			BEGIN
				IF @ManagerID = 0
				BEGIN
					SET @ManagerID = null
				END
				ELSE IF @ManagerID not in (SELECT EmployeeID FROM TBL_Employee)
				BEGIN
					SET	@allow = 0
					SET @MessageResult = N'ManagerID is invalid.'
					print @MessageResult 
				END
			END
			ELSE IF @Province is not null and @Province not in (SELECT ControlValue FROM TBL_Control WHERE ControlGroup = 'Province')
			BEGIN
				SET @allow = 0
				SET @MessageResult = N'Province is invalid.'
				print @MessageResult 
			END
			ELSE IF @District is not null and @District not in (SELECT y.ControlValue FROM TBL_Control as x
															JOIN TBL_Control as y on x.ControlName = y.ControlGroup
															WHERE x.ControlGroup = 'Province' 
																AND x.ControlValue = @Province)
			BEGIN
				SET @allow = 0
				SET @MessageResult = N'District is invalid.'
				print @MessageResult 
			END  
			ELSE IF @Ward is not null and @Ward not in ( SELECT z.ControlValue FROM TBL_Control as x
															JOIN TBL_Control as y
																ON y.ControlGroup = x.ControlName
															JOIN TBL_Control as z
																ON z.ControlGroup = y.ControlName
															WHERE x.ControlValue = @Province
															AND x.ControlGroup = 'Province'
															AND y.ControlValue = @District)
			BEGIN
				SET @allow = 0
				SET @MessageResult = N'Ward is invalid.'
				print @MessageResult 
			END
		END
		ELSE 
		BEGIN
			SET @allow = 0
			SET @MessageResult = N'Email is invalid.'
			print @MessageResult 
		END   
		
	END

	IF @allow = 1
	BEGIN
		INSERT INTO TBL_Store
		VALUES (
			@StoreName,
			@PhoneNumber,
			@Email,
			@ManagerID,
			@RentalCost,
			@OpenningDate,
			@ClosingDate,
			@Province,
			@District,
			@Ward,
			@Details
		)
		
		SET @MessageResult = N'Success.'
		print @MessageResult 
	END
END/*DECLARE @msg as nvarchar(100)EXECUTE [dbo].[addStore] 
   N'ABC Store'
  , 909121335
  , 'hdung.222@gmail.com'
  , null
  , 11000000
  , '2022-06-01'
  , null
  , 1
  , 1
  , 3
  , null
  , @msg OUTPUT
SELECT @msg as msg*/