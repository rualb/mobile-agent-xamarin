SELECT
SUM(GNTOTCL.DEBIT) DEBIT,SUM(GNTOTCL.CREDIT) CREDIT
FROM
LG_$FIRM$_$PERIOD$_GNTOTCL GNTOTCL INNER JOIN LG_$FIRM$_CLCARD CLCARD ON GNTOTCL.CARDREF = CLCARD.LOGICALREF
$WHERE$
$ORDER$