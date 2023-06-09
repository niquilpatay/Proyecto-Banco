USE [banco]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 18/03/2023 16:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
 CONSTRAINT [pk_clientes] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cuentas]    Script Date: 18/03/2023 16:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cuentas](
	[cbu] [int] NOT NULL,
	[saldo] [money] NULL,
	[id_tipo_cuenta] [int] NULL,
	[ultimoMovimiento] [date] NULL,
	[estado] [bit] NULL,
	[dni] [int] NULL,
 CONSTRAINT [pk_cuentas] PRIMARY KEY CLUSTERED 
(
	[cbu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoCuentas]    Script Date: 18/03/2023 16:23:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoCuentas](
	[id_tipo_cuenta] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [pk_tipoCuentas] PRIMARY KEY CLUSTERED 
(
	[id_tipo_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[clientes] ([dni], [nombre], [apellido]) VALUES (1560248, N'Tirano', N'Rexo')
INSERT [dbo].[clientes] ([dni], [nombre], [apellido]) VALUES (12345618, N'Elpibe', N'Valderrama')
INSERT [dbo].[clientes] ([dni], [nombre], [apellido]) VALUES (17892356, N'Gonzalo', N'Riego')
INSERT [dbo].[clientes] ([dni], [nombre], [apellido]) VALUES (17923190, N'Víctor', N'Kilpay')
INSERT [dbo].[clientes] ([dni], [nombre], [apellido]) VALUES (24569781, N'Patito', N'Feo')
INSERT [dbo].[clientes] ([dni], [nombre], [apellido]) VALUES (45244598, N'Nahuel Ignacio', N'Quilpatay')
INSERT [dbo].[clientes] ([dni], [nombre], [apellido]) VALUES (45347414, N'Mario', N'Bechler')
INSERT [dbo].[clientes] ([dni], [nombre], [apellido]) VALUES (45644698, N'Pancho', N'Pincha')
INSERT [dbo].[clientes] ([dni], [nombre], [apellido]) VALUES (45899756, N'Pablo', N'Lescano')
INSERT [dbo].[clientes] ([dni], [nombre], [apellido]) VALUES (48986235, N'Sara', N'Conor')
INSERT [dbo].[clientes] ([dni], [nombre], [apellido]) VALUES (88965214, N'José', N'San Martín')
INSERT [dbo].[clientes] ([dni], [nombre], [apellido]) VALUES (89236457, N'Neo', N'Tokyo')
GO
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (11147893, 900.0000, 3, CAST(N'2019-05-16' AS Date), 0, 45244598)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (11560248, 9000000.0000, 3, CAST(N'1989-01-17' AS Date), 1, 1560248)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (11560289, 987520.0000, 2, CAST(N'2022-02-08' AS Date), 1, 1560248)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (112345618, 250000.0000, 4, CAST(N'2022-10-10' AS Date), 1, 12345618)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (117892356, 698960.0000, 1, CAST(N'2022-10-03' AS Date), 1, 17892356)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (117923190, 350000.0000, 2, CAST(N'2022-09-07' AS Date), 1, 17923190)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (145244598, 386000.0000, 2, CAST(N'2022-09-07' AS Date), 1, 45244598)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (145244599, 9000.0000, 3, CAST(N'2022-09-05' AS Date), 1, 17923190)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (145347414, 10000000.0000, 3, CAST(N'2022-09-11' AS Date), 1, 45347414)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (145644698, 55000.0000, 3, CAST(N'2022-10-30' AS Date), 1, 45644698)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (145666984, 78000.0000, 4, CAST(N'2022-08-01' AS Date), 1, 45244598)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (145899756, 420000.0000, 3, CAST(N'2006-07-13' AS Date), 1, 45899756)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (148986235, 1000000000.0000, 3, CAST(N'2022-10-30' AS Date), 1, 48986235)
INSERT [dbo].[cuentas] ([cbu], [saldo], [id_tipo_cuenta], [ultimoMovimiento], [estado], [dni]) VALUES (188965214, 2.0000, 2, CAST(N'2000-02-03' AS Date), 1, 88965214)
GO
INSERT [dbo].[tipoCuentas] ([id_tipo_cuenta], [nombre]) VALUES (1, N'Cuenta corriente')
INSERT [dbo].[tipoCuentas] ([id_tipo_cuenta], [nombre]) VALUES (2, N'Caja de ahorro ARS')
INSERT [dbo].[tipoCuentas] ([id_tipo_cuenta], [nombre]) VALUES (3, N'Caja de ahorro USD')
INSERT [dbo].[tipoCuentas] ([id_tipo_cuenta], [nombre]) VALUES (4, N'Cuenta sueldo')
GO
ALTER TABLE [dbo].[cuentas]  WITH CHECK ADD  CONSTRAINT [fk_clientes_cuentas] FOREIGN KEY([dni])
REFERENCES [dbo].[clientes] ([dni])
GO
ALTER TABLE [dbo].[cuentas] CHECK CONSTRAINT [fk_clientes_cuentas]
GO
ALTER TABLE [dbo].[cuentas]  WITH CHECK ADD  CONSTRAINT [fk_cuentas_tipoCuentas] FOREIGN KEY([id_tipo_cuenta])
REFERENCES [dbo].[tipoCuentas] ([id_tipo_cuenta])
GO
ALTER TABLE [dbo].[cuentas] CHECK CONSTRAINT [fk_cuentas_tipoCuentas]
GO
/****** Object:  StoredProcedure [dbo].[actualizar_Cliente]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_Cliente]
@dni int,
@nombre varchar(50),
@apellido varchar(50)
as
update clientes set nombre=@nombre, apellido=@apellido where dni=@dni
return
GO
/****** Object:  StoredProcedure [dbo].[actualizar_Cuenta]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_Cuenta]
@cbu int,
@saldo money,
@ultimoMovimiento datetime
as
update cuentas set saldo=@saldo, ultimoMovimiento=@ultimoMovimiento WHERE cbu=@cbu
return
GO
/****** Object:  StoredProcedure [dbo].[actualizar_Cuenta2]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_Cuenta2]
@cbu int,
@saldo money,
@ultimoMovimiento datetime
as
update cuentas set saldo=@saldo,ultimoMovimiento=@ultimoMovimiento WHERE cbu=@cbu
return
GO
/****** Object:  StoredProcedure [dbo].[actualizarCuenta3]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizarCuenta3]
@cbu int,
@saldo money,
@id_tipo_cuenta int,
@ultimoMovimiento datetime,
@estado bit
as
update cuentas set saldo=@saldo, id_tipo_cuenta=@id_tipo_cuenta,ultimoMovimiento=@ultimoMovimiento,estado=@estado WHERE cbu=@cbu
return
GO
/****** Object:  StoredProcedure [dbo].[cargar_Cliente]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargar_Cliente]
as
select dni,nombre,apellido
from clientes
return
GO
/****** Object:  StoredProcedure [dbo].[cargar_COMBO]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cargar_COMBO]
as 
SELECT * FROM tipoCuentas
GO
/****** Object:  StoredProcedure [dbo].[cargar_Cuenta]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[cargar_Cuenta]
as
select cbu,saldo,nombre,ultimoMovimiento
from cuentas c join tipoCuentas t on t.id_tipo_cuenta=c.id_tipo_cuenta
return
GO
/****** Object:  StoredProcedure [dbo].[cargar_Cuenta2]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[cargar_Cuenta2]
as
select cbu,saldo,t.nombre as tipo,ultimoMovimiento
from cuentas c join tipoCuentas t on t.id_tipo_cuenta=c.id_tipo_cuenta
return
GO
/****** Object:  StoredProcedure [dbo].[cargar_lista]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cargar_lista]
as 
SELECT * FROM clientes
GO
/****** Object:  StoredProcedure [dbo].[cargar_tipoCuenta]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[cargar_tipoCuenta]
as
begin
 select * from tipoCuentas
end
GO
/****** Object:  StoredProcedure [dbo].[cargarCuentasActivas]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargarCuentasActivas]
as
select c.cbu,c.dni,saldo,t.nombre as tipo,ultimoMovimiento
from cuentas c join tipoCuentas t on t.id_tipo_cuenta=c.id_tipo_cuenta
join clientes cl on c.dni=cl.dni
where estado = 1
return
GO
/****** Object:  StoredProcedure [dbo].[cargarCuentasInactivas]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargarCuentasInactivas]
as
select c.cbu,c.dni,saldo,t.nombre as tipo,ultimoMovimiento
from cuentas c join tipoCuentas t on t.id_tipo_cuenta=c.id_tipo_cuenta
join clientes cl on c.dni=cl.dni
where estado = 0
return
GO
/****** Object:  StoredProcedure [dbo].[desactivarCuenta]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[desactivarCuenta]
@cbu int,
@estado bit
as
update cuentas set estado=@estado WHERE cbu=@cbu
return
GO
/****** Object:  StoredProcedure [dbo].[eliminar_Cliente]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminar_Cliente]
@dni int
as
delete from clientes where dni=@dni
return
GO
/****** Object:  StoredProcedure [dbo].[eliminar_Cuenta]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminar_Cuenta]
@cbu int
as
delete from cuentas where cbu=@cbu
return
GO
/****** Object:  StoredProcedure [dbo].[insertar_Cliente]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Cliente]
@dni int,
@nombre varchar(50),
@apellido varchar(50)
as
insert into clientes (dni,nombre,apellido) values (@dni,@nombre,@apellido)
return
GO
/****** Object:  StoredProcedure [dbo].[insertar_Cuenta]    Script Date: 18/03/2023 16:23:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Cuenta]
@cbu int,
@dni int,
@saldo money,
@id_tipo_cuenta int,
@ultimoMovimiento datetime,
@estado bit
as
insert into cuentas (cbu,dni,saldo,id_tipo_cuenta,ultimoMovimiento,estado) values (@cbu,@dni,@saldo,@id_tipo_cuenta,@ultimoMovimiento,@estado)
return
GO
