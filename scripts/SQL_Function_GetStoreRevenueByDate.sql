ALTER function [dbo].[GetStoreRevenueByDate](@SalesDate date)
returns @returnTable table(
	SalesDate date,
	StoreId int,
	StoreName nvarchar(50),
	Total decimal(12, 0)
)
as
begin
	declare @temp table(
		StoreId int,
		Total decimal(12, 0)
	)
	declare @createDate as date, @storeId as int, @totalPrice as decimal(12, 0), @discount as int;
	declare cur cursor for
		select CreatedDate, StoreID, TotalPrice, Discount from TBL_SalesHeader
	open cur
	fetch next from cur into @createDate, @storeId, @totalPrice, @discount
	while @@FETCH_STATUS = 0
	begin
		if @createDate = @SalesDate
		begin
			if @storeId in (select StoreId from @temp)
			begin
				update @temp
				set Total = Total + @totalPrice - @discount
				where StoreId = @storeId
			end
			else
			begin
				insert into @temp
					values(@storeId, @totalPrice - @discount)
			end
			fetch next from cur into @createDate, @storeId, @totalPrice, @discount
		end
	end
	close cur
	deallocate cur

	insert into @returnTable
	select @SalesDate as SalesDate, t.StoreId as StoreId, store.StoreName as StoreName, t.Total as Total from @temp as t
	join TBL_Store as store on store.StoreID = t.StoreId

	return

end;