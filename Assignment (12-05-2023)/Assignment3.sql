

CREATE PROCEDURE ProductRankings
	@Location INT

As
Begin
select ProductID,LocationID,Quantity,
Rank() over(partition by LocationID order by Quantity desc) as Rank
from Production.ProductInventory where LocationID=@Location;
End;

Exec ProductRankings 50;


--------------------------------------------------------------------------
--------------------------------------------------------------------------

GO

CREATE PROCEDURE ProductRankings1
	
As
Begin
select ProductID,LocationID,Quantity,
Rank() over(partition by LocationID order by Quantity desc) as Rank
from Production.ProductInventory;
End;

Exec ProductRankings1;