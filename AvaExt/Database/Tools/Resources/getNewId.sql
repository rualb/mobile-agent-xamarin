UPDATE $ID_SOURCE$ SET LASTLREF = LASTLREF + 1 WHERE ID = 1
SELECT LASTLREF FROM $ID_SOURCE$ WHERE ID = 1