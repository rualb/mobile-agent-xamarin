SELECT
	ITEMS.LOGICALREF,
	ITEMS.CODE,
	ITEMS.NAME,
	ITEMS.PRICE1,
	ITEMS.PRICE2,
	ITEMS.PRICE3,
	ITEMS.PRICE4,
	ITEMS.PRICE5,
	ITEMS.ONHAND,
	ITEMS.ONHANDIO,
	ITEMS.ONMAIN,
	ITEMS.SPE_REMAIN,
	ITEMS.SPE_PRICE
FROM
LG_$FIRM$_ITEMS ITEMS
$WHERE$
$ORDER$
$LIMIT$
