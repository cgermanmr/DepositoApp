USE [master]
GO

/****** Object:  StoredProcedure [dbo].[SPU_RESTAURAR_BD_DEPOSITO]    Script Date: 20/09/2016 22:25:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SPU_RESTAURAR_BD_DEPOSITO] 
	-- Add the parameters for the stored procedure here
	@PATH_BACKUP NVARCHAR(MAX)
AS
BEGIN
	EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'Deposito';
	ALTER DATABASE [Deposito] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE [Deposito];
	RESTORE DATABASE [Deposito] FROM  DISK = @PATH_BACKUP WITH  FILE = 1,  MOVE N'Deposito_Data' TO N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Deposito.mdf',  MOVE N'Deposito_Log' TO N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Deposito.ldf',  NOUNLOAD,  STATS = 5;

END

GO


