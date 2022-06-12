ALTER function [dbo].[getSalesHeaderFromDetails](@salesHeaderId int)
returns @returnTable table(
	SalesDate date,
	HeaderId int,
	StoreItemId int,
	ItemName nvarchar(50),
	Price int,
	Quantity int,
	TotalPrice decimal(12, 0)
)
as
begin
	if @salesHeaderId < 1
	begin
		return
	end
	declare @temp table(
		headerId int,
		storeItemId int,
		quantity int
	)
	declare @headerId as int, @storeItemId as int, @quantity as int;
	declare cur cursor for
		select SalesHeaderID, StoreItemID, Quantity from TBL_SalesDetails
	open cur
	fetch next from cur into @headerId, @storeItemId, @quantity
	while @@FETCH_STATUS = 0
	begin
		if @quantity > 0
		begin
			if @headerId = @salesHeaderId
			begin
				insert into @temp
					values(@headerId, @storeItemId, @quantity)
			end
			fetch next from cur into @headerId, @storeItemId, @quantity
		end
	end
	close cur
	deallocate cur

	insert into @returnTable
	select header.CreatedDate as SalesDate, t.headerId as HeaderId, t.storeItemId as StoreItemId, item.ItemName as ItemName, sitem.Price as Price, t.quantity as Quantity, sitem.Price * t.quantity as TotalPrice from @temp as t
	join TBL_SalesHeader as header on header.SalesHeaderID = t.headerId
	join TBL_StoreItem as sitem on sitem.StoreItemID = t.storeItemId
	join TBL_Item as item on item.ItemID = sitem.ItemID

	return

end;