ALTER PROCEDURE [dbo].[addEmployee](
@StoreId AS int,
@EmployeeName AS nvarchar(50),
@Birthday AS date,
@Gender AS tinyint,
@PhoneNumber AS int,
@StartingDate AS date,
@WorkingStatus AS tinyint,
@Salary AS decimal(12),
@Username AS nvarchar(30),
@Password AS nvarchar(30),
@Province AS tinyint,  
@District AS tinyint,
@Ward AS tinyint,
@Details AS nvarchar(50)
)
AS
BEGIN
	DECLARE @allow AS bit
	DECLARE @createdDate AS date
	SET @allow = 1
	SET @createdDate = convert(date, getdate())
	IF (@EmployeeName is null 
	or @Birthday is null 
	or @Gender is null 
	or @PhoneNumber is null 
	or @StartingDate is null 
	or @WorkingStatus is null 
	or @Salary is null)
	BEGIN
		SET @allow = 0
		print 'EmployeeName, Birthday, Gender, PhoneNumber, StartingDate, WorkingStatus, Salary must be not null.'
	END
	ELSE IF (@EmployeeName = '')
	BEGIN
		SET @allow = 0
		print 'Employee name is empty.'
	END
	ELSE IF (@Username = '')
	BEGIN
		SET @allow = 0
		print 'Username is empty.'
	END	 
	ELSE IF (@Password = '')
	BEGIN
		SET @allow = 0
		print 'Password is empty.'
	END
	ELSE
	BEGIN
		IF @Gender not in (SELECT ControlValue FROM TBL_Control WHERE ControlGroup = 'Gender')
		BEGIN
			SET @allow = 0
			print 'Gender is invalid.'
		END
		ELSE IF @PhoneNumber in (SELECT PhoneNumber FROM TBL_Employee)
		BEGIN
			SET @allow = 0
			print 'Phone number already exists.'
		END	  
		ELSE IF @Username in (SELECT Username FROM TBL_Employee)
		BEGIN
			SET @allow = 0
			print 'Username already exists.'
		END	  
		ELSE IF @Province is not null and @Province not in (SELECT ControlValue FROM TBL_Control WHERE ControlGroup = 'Province')
		BEGIN
			SET @allow = 0
			print 'Province is invalid.'
		END	   
		ELSE IF @District is not null and @District not in (SELECT y.ControlValue FROM TBL_Control as x
															JOIN TBL_Control as y on x.ControlName = y.ControlGroup
															WHERE x.ControlGroup = 'Province' 
																AND x.ControlValue = @Province)
		BEGIN
			SET @allow = 0
			print 'District is invalid.'
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
			print 'Ward is invalid.'
		END
	END

	IF @allow = 1
	BEGIN
		INSERT INTO TBL_Employee
		VALUES (
			@StoreId,
			@EmployeeName,
			@Birthday,
			@Gender,
			@PhoneNumber,
			@StartingDate,
			@WorkingStatus,
			@Salary,
			@Username,
			@Password,
			@Province,  
			@District,
			@Ward,
			@Details
		)
	END
END--EXECUTE @RC = [dbo].[addEmployee] 
--   1
--  , N'Bruno Guimares'
--  , '2000-03-15'
--  , 1
--  , 0362514578
--  , '2022-06-03'
--  , 1
--  , 24000
--  , 'bruno3'
--  , '123'
--  , 1
--  , 1
--  , 3
--  , null
--GO