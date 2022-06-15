CREATE OR ALTER function [dbo].[GetSalaryByStore](@StoreId int, @Month int)
returns @returnTable table(
	EmployeeId int,
	EmployeeName nvarchar(50),
	WorkingHours int,
	Total decimal(12)
)
as
begin
	declare @temp table(
		EmployeeId int,
		WorkingHours int
	)
	declare @employeeId as int, @date as date, @stime as time, @etime as time, @hours as int;
	declare cur cursor for
		select w.EmployeeID, w.WorkDate, w.StartingTime, w.EndingTime from TBL_WorkHour as w
			join TBL_Employee as e on w.EmployeeID = e.EmployeeID
			join TBL_Store as s on s.StoreID  = e.StoreID
			where s.StoreID = @StoreId
				and MONTH(w.WorkDate) = @Month
	open cur
	fetch next from cur into @employeeId, @date, @stime, @etime
	while @@FETCH_STATUS = 0
	begin
		set @hours = DATEDIFF(HOUR, 
					(CONVERT(varchar(10), @date) + ' ' + CONVERT(varchar(10), @stime)), 
					(CONVERT(varchar(10), @date) + ' ' + CONVERT(varchar(10), @etime))) 
		if @employeeId in (select EmployeeId from @temp)
		begin
			update @temp
			set WorkingHours = WorkingHours + @hours
			where EmployeeId = @employeeId
		end
		else
		begin
			insert into @temp
				values(@employeeId, @hours)
		end
		fetch next from cur into @employeeId, @date, @stime, @etime
	end
	close cur
	deallocate cur

	insert into @returnTable
	select e.EmployeeId as EmployeeId, e.EmployeeName as EmployeeName, t.WorkingHours as WorkingHours, t.WorkingHours * e.Salary as Total from @temp as t
	join TBL_Employee as e on e.EmployeeID = t.EmployeeId

	return

end;