CREATE function [dbo].[SearchItemByName](@keyword nvarchar(50))
returns @returnTable table(
	StoreId int,
	StoreName nvarchar(50),
	ItemId int,
	ItemName nvarchar(50),
	Cost decimal(12),
	SuggestedPrice decimal(12),
	Price decimal(12)
)
as
begin
	insert into @returnTable
	select store.StoreID, store.StoreName, sitem.StoreItemID, item.ItemName, item.Cost, item.SuggestedPrice, sitem.Price
	from TBL_StoreItem as sitem
	join TBL_Store as store on sitem.StoreID = store.StoreID
	join TBL_Item as item on item.ItemID = sitem.ItemID
	where ItemName like '%'+ @keyword +'%';
	return;
end;