--RESTORE FILELISTONLY
--FROM DISK = 'C:\Users\i770005\Desktop\DepositoInteligente\Backup Full 2018-04-04 000613.bak'

RESTORE DATABASE Deposito
FROM DISK = 'C:\Users\i770005\Desktop\DepositoInteligente\Backup Full 2018-04-04 000613.bak'

WITH MOVE 'Deposito_Data' TO 'C:\Users\i770005\Desktop\DepositoInteligente\DAL\Deposito.mdf',
MOVE 'Deposito_Log' TO 'C:\Users\i770005\Desktop\DepositoInteligente\DAL\Deposito.ldf',
REPLACE;