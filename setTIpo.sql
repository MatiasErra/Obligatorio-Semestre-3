USE [obligatorioProg]
GO

/****** Object:  Trigger [dbo].[SetTipo]    Script Date: 14/07/2022 18:59:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[SetTipo]
   ON  [dbo].[Reparacion]
   Instead of  INSERT
AS 
BEGIN
	declare @Tipo varchar(20)
	declare @fchEntrada varchar(20)
	declare @salida varchar(20)
	

	set @fchEntrada = (select fchaEntrada from inserted)
	set @salida = (select fchaSalida from inserted)




	if(@fchEntrada is null)
	begin
	set @Tipo = 'Agendado'
	end

	else if( @fchEntrada is not null and @salida is null)
	begin
	set @Tipo = 'En Reparacion'
	end

	else if (@salida is not null)
	begin
	set @Tipo = 'Reparado'
	end


	Delete from  Reparacion 
	where idVehiculo = (select idVehiculo from inserted) 
	and fchaReservada = (select fchaReservada from inserted) 

	
	insert into Reparacion ( fchaEntrada, fchaSalida, horas, fchaReservada, descripcion, fchaAgendada, idVehiculo, idMecanico, Tipo, costo)
	values
   (


   @fchEntrada,
   @salida,
 (select horas from inserted),
   (select fchaReservada from inserted),
   (select descripcion from inserted),
   (select fchaAgendada from inserted),
   (select idVehiculo from inserted),
   (select idMecanico from inserted),
   @Tipo,
   0
   
   )





END
GO

ALTER TABLE [dbo].[Reparacion] ENABLE TRIGGER [SetTipo]
GO

