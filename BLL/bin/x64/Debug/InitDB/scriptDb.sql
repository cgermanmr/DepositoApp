USE [master]
go
IF DB_ID('DepositoDB') IS NOT NULL
BEGIN
    DROP DATABASE [DepositoDB]
END
go
CREATE DATABASE [DepositoDB]
go
