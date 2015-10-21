/*------------------------------------------*/
USE GD2C2015
GO
/*------------------------------------------*/

--CREATE SCHEMA [THE-CVENGERS] AUTHORIZATION [gd]
--GO


CREATE TABLE ROL(
	ROL_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	ROL_NOMBRE NVARCHAR(255) NOT NULL,
	ROL_ESTADO BIT NOT NULL,
	ROL_FUNCIONALIDADES NUMERIC(18,0) NOT NULL
)
GO

CREATE TABLE FUNCIONALIDAD(
	FUNC_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	FUNC_NOMBRE NVARCHAR(255) NOT NULL,
	FUNC_DESCRIPCION NVARCHAR(1024) NOT NULL
)

CREATE TABLE FUNCIONXROL(
	FXR_ROL_ID NUMERIC(18,0) NOT NULL,
	FXR_FUNC_ID NUMERIC(18,0) NOT NULL,
	FXR_PK NUMERIC(18,0) IDENTITY PRIMARY KEY,
	CONSTRAINT FK_FXR_1 FOREIGN KEY (FXR_ROL_ID) REFERENCES ROL (ROL_ID),
	CONSTRAINT FK_FXR_2 FOREIGN KEY (FXR_FUNC_ID) REFERENCES FUNCIONALIDAD (FUNC_ID)
)
GO

ALTER TABLE ROL
ADD CONSTRAINT FK_ROL_2 FOREIGN KEY (ROL_FUNCIONALIDADES) REFERENCES FUNCIONXROL (FXR_PK)
GO

CREATE TABLE USUARIO(
	USR_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	USR_USERNAME NVARCHAR(255) UNIQUE NOT NULL,
	USR_PASS CHAR(4) NOT NULL,
	USR_ROL_ID NUMERIC(18,0) NOT NULL,
	USR_ESTADO BIT NOT NULL,
	CONSTRAINT FK_USR_1 FOREIGN KEY (USR_ROL_ID) REFERENCES ROL (ROL_ID)
)
GO

CREATE TABLE LOGUEO(
	LOG_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	LOG_USUARIO NUMERIC(18,0) NOT NULL, 
	LOG_FECHA DATETIME NOT NULL,
	LOG_RESULTADO BIT NOT NULL
	CONSTRAINT FK_LOG_1 FOREIGN KEY (LOG_USUARIO) REFERENCES USUARIO (USR_ID)
)
GO

CREATE TABLE CIUDAD(
	CIUDAD_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	CIUDAD_NOMBRE NVARCHAR(255) NOT NULL
)
GO

CREATE TABLE FABRICANTE(
	FABRICANTE_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	FABRICANTE_NOMBRE NVARCHAR(255) NOT NULL
)
GO

CREATE TABLE SERVICIO(
	SERVICIO_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	SERVICIO_PORCENTAJE NUMERIC(18,2) /*NOT NULL*/,
	SERVICIO_NOMBRE NVARCHAR(255) NOT NULL
)
GO

CREATE TABLE AERONAVE(
	AERONAVE_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	AERONAVE_CANTIDAD_BUTACAS NUMERIC(18,0) /*NOT NULL*/,
	AERONAVE_FABRICANTE_AVION NUMERIC(18,0) NOT NULL,
	AERONAVE_ESPACIO_ENCOMIENDAS NUMERIC(18,2) NOT NULL,
	AERONAVE_ESTADO BIT /*NOT NULL*/,
	AERONAVE_MATRICULA_AVION NVARCHAR(255) NOT NULL,
	AERONAVE_MODELO_AVION NVARCHAR(255) NOT NULL,
	AERONAVE_SERVICIO NUMERIC(18,0) NOT NULL,
	CONSTRAINT FK_AERONAVE_1 FOREIGN KEY (AERONAVE_FABRICANTE_AVION) REFERENCES FABRICANTE (FABRICANTE_ID),
	CONSTRAINT FK_AERONAVE_2 FOREIGN KEY (AERONAVE_SERVICIO) REFERENCES SERVICIO (SERVICIO_ID)
)
GO

CREATE TABLE RUTA(
    RUTA_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	RUTA_CODIGO NUMERIC(18,0) NOT NULL,
	RUTA_ORIGEN NUMERIC(18,0) NOT NULL,
	RUTA_DESTINO NUMERIC(18,0) NOT NULL,
	RUTA_PRECIO_BASE_POR_KILO NUMERIC(18,2) NOT NULL,
	RUTA_PRECIO_BASE_POR_PASAJE NUMERIC(18,2) NOT NULL,
	CONSTRAINT FK_RUTA_1 FOREIGN KEY (RUTA_ORIGEN) REFERENCES CIUDAD (CIUDAD_ID),
	CONSTRAINT FK_RUTA_2 FOREIGN KEY (RUTA_DESTINO) REFERENCES CIUDAD (CIUDAD_ID),
	CONSTRAINT CK_RUTA_1 CHECK(RUTA_DESTINO NOT LIKE RUTA_ORIGEN)
)
GO

CREATE TABLE VIAJE(
	VIAJE_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	VIAJE_CANTIDAD_BUTACAS_DISPONIBLES NUMERIC(18,0) /*NOT NULL*/,
	VIAJE_FECHA_SALIDA DATETIME NOT NULL,
	VIAJE_FECHA_LLEGADA DATETIME,
	VIAJE_FECHA_LLEGADA_ESTIMADA DATETIME NOT NULL,
	VIAJE_AERONAVE NUMERIC(18,0) NOT NULL,
	VIAJE_RUTA NUMERIC(18,0) NOT NULL,
	CONSTRAINT FK_VIAJE_1 FOREIGN KEY (VIAJE_AERONAVE) REFERENCES AERONAVE (AERONAVE_ID),
	CONSTRAINT FK_VIAJE_2 FOREIGN KEY (VIAJE_RUTA) REFERENCES RUTA (RUTA_ID)
)
GO

CREATE TABLE CLIENTE(
	CLIENTE_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	CLIENTE_ROL NUMERIC(18,0) /*NOT NULL*/,
	CLIENTE_NOMBRE NVARCHAR(255) NOT NULL,
	CLIENTE_APELLIDO NVARCHAR(255) NOT NULL,
	CLIENTE_DNI NUMERIC(18,0) NOT NULL,
	CLIENTE_DIR NVARCHAR(255) NOT NULL,
	CLIENTE_TELEFONO NUMERIC(18,0) NOT NULL,
	CLIENTE_MAIL NVARCHAR(255),
	CLIENTE_FECHA_NAC DATETIME NOT NULL,
	CONSTRAINT FK_CLIENTE_1 FOREIGN KEY (CLIENTE_ROL) REFERENCES ROL (ROL_ID)
)
GO

CREATE TABLE PASAJE(
    PASAJE_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	PASAJE_CODIGO_PASAJE NUMERIC(18,0) NOT NULL,
	PASAJE_CLI_ID NUMERIC(18,0) NOT NULL,
	PASAJE_VIAJE_ID NUMERIC(18,0) NOT NULL,
	PASAJE_PRECIO_PASAJE NUMERIC(18,2) NOT NULL,
	PASAJE_FECHA_COMPRA DATETIME NOT NULL,
	CONSTRAINT FK_PASAJE_1 FOREIGN KEY (PASAJE_CLI_ID) REFERENCES CLIENTE (CLIENTE_ID),
	CONSTRAINT FK_PASAJE_2 FOREIGN KEY (PASAJE_VIAJE_ID) REFERENCES VIAJE (VIAJE_ID)
)
GO

CREATE TABLE BUTACA(

	BUTACA_NRO NUMERIC(18,0) NOT NULL,
	BUTACA_VIAJE_ID NUMERIC(18,0) NOT NULL,
	BUTACA_PASAJE_ID NUMERIC(18,0) NOT NULL,
	BUTACA_TIPO NVARCHAR(255) NOT NULL,
	BUTACA_PISO NUMERIC(18,0) NOT NULL,
	PRIMARY KEY(BUTACA_NRO, BUTACA_VIAJE_ID),
	CONSTRAINT FK_BUTACA_1 FOREIGN KEY (BUTACA_VIAJE_ID) REFERENCES VIAJE (VIAJE_ID),
	CONSTRAINT FK_BUTACA_2 FOREIGN KEY (BUTACA_PASAJE_ID) REFERENCES PASAJE (PASAJE_ID)
)
GO

CREATE TABLE ENCOMIENDA(
	ENCOMIENDA_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	ENCOMIENDA_CODIGO NUMERIC(18,0) NOT NULL,
	ENCOMIENDA_CLI_ID NUMERIC(18,0) NOT NULL,
	ENCOMIENDA_VIAJE_ID NUMERIC(18,0) NOT NULL,
	ENCOMIENDA_PRECIO NUMERIC(18,2) NOT NULL,
	ENCOMIENDA_KG  NUMERIC(18,0) NOT NULL,
	ENCOMIENDA_FECHA_COMPRA DATETIME NOT NULL,
	CONSTRAINT FK_ENCOMIENDA_1 FOREIGN KEY (ENCOMIENDA_CLI_ID) REFERENCES CLIENTE (CLIENTE_ID),
	CONSTRAINT FK_ENCOMIENDA_2 FOREIGN KEY (ENCOMIENDA_VIAJE_ID) REFERENCES VIAJE (VIAJE_ID)
)
GO

CREATE TABLE TARJETACREDITO(
	TARJETA_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	TARJETA_TIPO NVARCHAR(255) NOT NULL,
	TARJETA_COD_SEGURIDAD NUMERIC(18,0) NOT NULL,
	TARJETA_FECHA_VENCIMIENTO DATETIME NOT NULL
)
GO

CREATE TABLE COMPRA(
	COMPRA_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	COMPRA_PASAJE NUMERIC(18,0),
	COMPRA_ENCOMIENDA NUMERIC(18,0),
	COMPRA_TARJETA NUMERIC(18,0),
	COMPRA_FECHA DATETIME NOT NULL,
	COMPRA_MONTO NUMERIC(18,2) NOT NULL,
	CONSTRAINT FK_COMPRA_1 FOREIGN KEY (COMPRA_PASAJE) REFERENCES PASAJE (PASAJE_ID),
	CONSTRAINT FK_COMPRA_2 FOREIGN KEY (COMPRA_ENCOMIENDA) REFERENCES ENCOMIENDA (ENCOMIENDA_ID),
	CONSTRAINT FK_COMPRA_3 FOREIGN KEY (COMPRA_TARJETA) REFERENCES TARJETACREDITO (TARJETA_ID),
	CONSTRAINT CK_COMPRA_1 CHECK(COMPRA_PASAJE IS NOT NULL OR COMPRA_ENCOMIENDA IS NOT NULL)
)
GO

CREATE TABLE DEVOLUCION(
	DEVOLUCION_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	DEVOLUCION_NUM_COMPRA NUMERIC(18,0) NOT NULL,
	DEVOLUCION_FECHA DATETIME NOT NULL,
	DEVOLUCION_DESCRIPCION NVARCHAR(255),
	CONSTRAINT FK_DEVOLUCION_1 FOREIGN KEY (DEVOLUCION_NUM_COMPRA) REFERENCES COMPRA (COMPRA_ID)
)
GO

CREATE TABLE PRODUCTO(
	PRODUCTO_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	PRODUCTO_NOMBRE NVARCHAR(255) NOT NULL,
	PRODUCTO_MILLAS_NECESARIAS NUMERIC(18,2) NOT NULL,
	PRODUCTO_STOCK NUMERIC(18,0) NOT NULL
)
GO

CREATE TABLE CANJE(
	CANJE_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	CANJE_PROD NUMERIC(18,0) NOT NULL,
	CANJE_FECHA DATETIME NOT NULL,
	CANJE_CANTIDAD NUMERIC(18,0) NOT NULL,
	CONSTRAINT FK_CANJE_1 FOREIGN KEY (CANJE_PROD) REFERENCES PRODUCTO (PRODUCTO_ID)
)
GO

CREATE TABLE MILLA(
	MILLA_ID NUMERIC(18,0) IDENTITY PRIMARY KEY,
	MILLA_CLIENTE NUMERIC(18,0) NOT NULL,
	MILLA_COMPRA NUMERIC(18,0),
	MILLA_DEVOLUCION NUMERIC(18,0),
	MILLA_CANJE NUMERIC(18,0),
	MILLA_GANADA NUMERIC(18,0),
	MILLA_GASTADA NUMERIC(18,0),
	MILLA_DETALLE NVARCHAR(255),
	MILLA_FECHA_VENCIMIENTO DATETIME NOT NULL,
	CONSTRAINT FK_MILLA_1 FOREIGN KEY (MILLA_CLIENTE) REFERENCES CLIENTE (CLIENTE_ID),
	CONSTRAINT FK_MILLA_2 FOREIGN KEY (MILLA_COMPRA) REFERENCES COMPRA (COMPRA_ID),
	CONSTRAINT FK_MILLA_3 FOREIGN KEY (MILLA_DEVOLUCION) REFERENCES DEVOLUCION (DEVOLUCION_ID),
	CONSTRAINT FK_MILLA_4 FOREIGN KEY (MILLA_CANJE) REFERENCES CANJE (CANJE_ID),
	CONSTRAINT CK_MILLA_1 CHECK(MILLA_COMPRA IS NOT NULL OR MILLA_DEVOLUCION IS NOT NULL OR MILLA_CANJE IS NOT NULL),
	CONSTRAINT CK_MILLA_2 CHECK(MILLA_GANADA IS NOT NULL OR MILLA_GASTADA IS NOT NULL)
)
GO


CREATE PROCEDURE INIC_CLIENTE
AS
BEGIN
INSERT INTO CLIENTE (CLIENTE_APELLIDO,CLIENTE_DIR,CLIENTE_DNI,CLIENTE_FECHA_NAC,CLIENTE_MAIL,CLIENTE_NOMBRE,CLIENTE_TELEFONO)
SELECT DISTINCT Cli_Apellido,Cli_Dir,Cli_Dni,Cli_Fecha_Nac,Cli_Mail,Cli_Nombre,Cli_Telefono FROM GD2C2015.gd_esquema.Maestra ORDER BY Cli_Apellido, Cli_Nombre
END

GO

CREATE PROCEDURE INIC_CIUDAD
AS
BEGIN
INSERT INTO CIUDAD (CIUDAD_NOMBRE)
SELECT DISTINCT Ruta_Ciudad_Origen FROM GD2C2015.gd_esquema.Maestra
UNION
SELECT DISTINCT Ruta_Ciudad_Destino FROM GD2C2015.gd_esquema.Maestra
END
GO


CREATE PROCEDURE INIC_FABRICANTE
AS
BEGIN
INSERT INTO FABRICANTE (FABRICANTE_NOMBRE)
SELECT DISTINCT Aeronave_Fabricante FROM GD2C2015.gd_esquema.Maestra
END
GO

CREATE PROCEDURE INIC_SERVICIO
AS
BEGIN
INSERT INTO SERVICIO (SERVICIO_NOMBRE)
SELECT DISTINCT Tipo_Servicio FROM GD2C2015.gd_esquema.Maestra
END
GO

CREATE PROCEDURE INIC_AERONAVE
AS
BEGIN
INSERT INTO AERONAVE (AERONAVE_FABRICANTE_AVION, AERONAVE_ESPACIO_ENCOMIENDAS, AERONAVE_MATRICULA_AVION, AERONAVE_MODELO_AVION, AERONAVE_SERVICIO)
SELECT DISTINCT (SELECT FABRICANTE_ID FROM FABRICANTE WHERE FABRICANTE_NOMBRE = Aeronave_Fabricante), Aeronave_KG_Disponibles, Aeronave_Matricula, Aeronave_Modelo, (SELECT SERVICIO_ID FROM SERVICIO WHERE SERVICIO_NOMBRE = Tipo_Servicio) FROM GD2C2015.gd_esquema.Maestra
END
GO

CREATE PROCEDURE INIC_RUTA
AS
BEGIN
INSERT INTO RUTA (RUTA_CODIGO, RUTA_DESTINO, RUTA_ORIGEN, RUTA_PRECIO_BASE_POR_KILO, RUTA_PRECIO_BASE_POR_PASAJE)
SELECT DISTINCT Ruta_Codigo, (SELECT CIUDAD_ID FROM CIUDAD WHERE CIUDAD_NOMBRE = Ruta_Ciudad_Destino), (SELECT CIUDAD_ID FROM CIUDAD WHERE CIUDAD_NOMBRE = Ruta_Ciudad_Origen), Ruta_Precio_BaseKG, Ruta_Precio_BasePasaje FROM GD2C2015.gd_esquema.Maestra
END
GO

CREATE PROCEDURE INIC_VIAJE
AS
BEGIN
INSERT INTO VIAJE (VIAJE_FECHA_SALIDA, VIAJE_FECHA_LLEGADA, VIAJE_FECHA_LLEGADA_ESTIMADA, VIAJE_AERONAVE, VIAJE_RUTA)
SELECT DISTINCT FechaSalida, FechaLLegada, Fecha_LLegada_Estimada, (SELECT AERONAVE_ID FROM AERONAVE WHERE AERONAVE_FABRICANTE_AVION = (SELECT FABRICANTE_ID FROM FABRICANTE WHERE Aeronave_Fabricante = FABRICANTE_NOMBRE) AND AERONAVE_ESPACIO_ENCOMIENDAS = Aeronave_KG_Disponibles AND AERONAVE_MATRICULA_AVION = Aeronave_Matricula AND AERONAVE_MODELO_AVION = Aeronave_Modelo AND AERONAVE_SERVICIO = (SELECT SERVICIO_ID FROM SERVICIO WHERE SERVICIO_NOMBRE = Tipo_Servicio)), (SELECT RUTA_ID FROM RUTA WHERE RUTA_CODIGO = Ruta_Codigo AND (SELECT CIUDAD_ID FROM CIUDAD WHERE CIUDAD_NOMBRE = Ruta_Ciudad_Destino) = RUTA_DESTINO AND (SELECT CIUDAD_ID FROM CIUDAD WHERE CIUDAD_NOMBRE = Ruta_Ciudad_Origen) = RUTA_ORIGEN AND RUTA_PRECIO_BASE_POR_KILO = Ruta_Precio_BaseKG AND RUTA_PRECIO_BASE_POR_PASAJE = Ruta_Precio_BasePasaje) FROM GD2C2015.gd_esquema.Maestra
END 
GO



CREATE PROCEDURE INIC_PASAJE
AS
BEGIN
INSERT INTO PASAJE (PASAJE_CODIGO_PASAJE, PASAJE_CLI_ID, PASAJE_VIAJE_ID, PASAJE_FECHA_COMPRA, PASAJE_PRECIO_PASAJE)
SELECT DISTINCT Pasaje_Codigo, (SELECT CLIENTE_ID FROM CLIENTE WHERE CLIENTE_NOMBRE = Cli_Nombre AND CLIENTE_APELLIDO = Cli_Apellido AND CLIENTE_DIR = Cli_Dir AND CLIENTE_DNI = Cli_Dni AND CLIENTE_FECHA_NAC = Cli_Fecha_Nac AND CLIENTE_MAIL = Cli_Mail AND CLIENTE_TELEFONO = Cli_Telefono),(SELECT VIAJE_ID FROM VIAJE WHERE VIAJE_AERONAVE = (SELECT AERONAVE_ID FROM AERONAVE WHERE AERONAVE_FABRICANTE_AVION = (SELECT FABRICANTE_ID FROM FABRICANTE WHERE Aeronave_Fabricante = FABRICANTE_NOMBRE) AND AERONAVE_ESPACIO_ENCOMIENDAS = Aeronave_KG_Disponibles AND AERONAVE_MATRICULA_AVION = Aeronave_Matricula AND AERONAVE_MODELO_AVION = Aeronave_Modelo AND AERONAVE_SERVICIO = (SELECT SERVICIO_ID FROM SERVICIO WHERE SERVICIO_NOMBRE = Tipo_Servicio)) AND VIAJE_FECHA_LLEGADA = FechaLLegada AND VIAJE_FECHA_LLEGADA_ESTIMADA = Fecha_LLegada_Estimada AND VIAJE_FECHA_SALIDA = FechaSalida AND VIAJE_RUTA = (SELECT RUTA_ID FROM RUTA WHERE RUTA_CODIGO = Ruta_Codigo AND (SELECT CIUDAD_ID FROM CIUDAD WHERE CIUDAD_NOMBRE = Ruta_Ciudad_Destino) = RUTA_DESTINO AND (SELECT CIUDAD_ID FROM CIUDAD WHERE CIUDAD_NOMBRE = Ruta_Ciudad_Origen) = RUTA_ORIGEN AND RUTA_PRECIO_BASE_POR_KILO = Ruta_Precio_BaseKG AND RUTA_PRECIO_BASE_POR_PASAJE = Ruta_Precio_BasePasaje)),Pasaje_FechaCompra, Pasaje_Precio FROM GD2C2015.gd_esquema.Maestra
WHERE Pasaje_Codigo <> 0
END
GO


CREATE PROCEDURE INIC_ENCOMIENDA
AS
BEGIN
INSERT INTO ENCOMIENDA (ENCOMIENDA_CODIGO, ENCOMIENDA_CLI_ID, ENCOMIENDA_VIAJE_ID, ENCOMIENDA_PRECIO, ENCOMIENDA_KG, ENCOMIENDA_FECHA_COMPRA)
SELECT DISTINCT Paquete_Codigo, (SELECT CLIENTE_ID FROM CLIENTE WHERE CLIENTE_NOMBRE = Cli_Nombre AND CLIENTE_APELLIDO = Cli_Apellido AND CLIENTE_DIR = Cli_Dir AND CLIENTE_DNI = Cli_Dni AND CLIENTE_FECHA_NAC = Cli_Fecha_Nac AND CLIENTE_MAIL = Cli_Mail AND CLIENTE_TELEFONO = Cli_Telefono), (SELECT VIAJE_ID FROM VIAJE WHERE VIAJE_AERONAVE = (SELECT AERONAVE_ID FROM AERONAVE WHERE AERONAVE_FABRICANTE_AVION = (SELECT FABRICANTE_ID FROM FABRICANTE WHERE Aeronave_Fabricante = FABRICANTE_NOMBRE) AND AERONAVE_ESPACIO_ENCOMIENDAS = Aeronave_KG_Disponibles AND AERONAVE_MATRICULA_AVION = Aeronave_Matricula AND AERONAVE_MODELO_AVION = Aeronave_Modelo AND AERONAVE_SERVICIO = (SELECT SERVICIO_ID FROM SERVICIO WHERE SERVICIO_NOMBRE = Tipo_Servicio)) AND VIAJE_FECHA_LLEGADA = FechaLLegada AND VIAJE_FECHA_LLEGADA_ESTIMADA = Fecha_LLegada_Estimada AND VIAJE_FECHA_SALIDA = FechaSalida AND VIAJE_RUTA = (SELECT RUTA_ID FROM RUTA WHERE RUTA_CODIGO = Ruta_Codigo AND (SELECT CIUDAD_ID FROM CIUDAD WHERE CIUDAD_NOMBRE = Ruta_Ciudad_Destino) = RUTA_DESTINO AND (SELECT CIUDAD_ID FROM CIUDAD WHERE CIUDAD_NOMBRE = Ruta_Ciudad_Origen) = RUTA_ORIGEN AND RUTA_PRECIO_BASE_POR_KILO = Ruta_Precio_BaseKG AND RUTA_PRECIO_BASE_POR_PASAJE = Ruta_Precio_BasePasaje)), Paquete_Precio, Paquete_KG, Pasaje_FechaCompra FROM GD2C2015.gd_esquema.Maestra
WHERE Paquete_Codigo <> 0
END
GO

CREATE PROCEDURE INIC_BUTACA
AS 
BEGIN
INSERT INTO BUTACA (BUTACA_NRO, BUTACA_PISO, BUTACA_TIPO, BUTACA_PASAJE_ID, BUTACA_VIAJE_ID)
SELECT DISTINCT Butaca_Nro, Butaca_Piso, Butaca_Tipo, (SELECT PASAJE_ID FROM PASAJE WHERE PASAJE_CODIGO_PASAJE = Pasaje_Codigo AND PASAJE_CLI_ID =(SELECT CLIENTE_ID FROM CLIENTE WHERE CLIENTE_NOMBRE = Cli_Nombre AND CLIENTE_APELLIDO = Cli_Apellido AND CLIENTE_DIR = Cli_Dir AND CLIENTE_DNI = Cli_Dni AND CLIENTE_FECHA_NAC = Cli_Fecha_Nac AND CLIENTE_MAIL = Cli_Mail AND CLIENTE_TELEFONO = Cli_Telefono) AND PASAJE_VIAJE_ID = (SELECT VIAJE_ID FROM VIAJE WHERE VIAJE_AERONAVE = (SELECT AERONAVE_ID FROM AERONAVE WHERE AERONAVE_FABRICANTE_AVION = (SELECT FABRICANTE_ID FROM FABRICANTE WHERE Aeronave_Fabricante = FABRICANTE_NOMBRE) AND AERONAVE_ESPACIO_ENCOMIENDAS = Aeronave_KG_Disponibles AND AERONAVE_MATRICULA_AVION = Aeronave_Matricula AND AERONAVE_MODELO_AVION = Aeronave_Modelo AND AERONAVE_SERVICIO = (SELECT SERVICIO_ID FROM SERVICIO WHERE SERVICIO_NOMBRE = Tipo_Servicio)) AND VIAJE_FECHA_LLEGADA = FechaLLegada AND VIAJE_FECHA_LLEGADA_ESTIMADA = Fecha_LLegada_Estimada AND VIAJE_FECHA_SALIDA = FechaSalida AND VIAJE_RUTA = (SELECT RUTA_ID FROM RUTA WHERE RUTA_CODIGO = Ruta_Codigo AND (SELECT CIUDAD_ID FROM CIUDAD WHERE CIUDAD_NOMBRE = Ruta_Ciudad_Destino) = RUTA_DESTINO AND (SELECT CIUDAD_ID FROM CIUDAD WHERE CIUDAD_NOMBRE = Ruta_Ciudad_Origen) = RUTA_ORIGEN AND RUTA_PRECIO_BASE_POR_KILO = Ruta_Precio_BaseKG AND RUTA_PRECIO_BASE_POR_PASAJE = Ruta_Precio_BasePasaje)) AND PASAJE_PRECIO_PASAJE = Pasaje_Precio AND PASAJE_FECHA_COMPRA = Pasaje_FechaCompra), (SELECT VIAJE_ID FROM VIAJE WHERE VIAJE_AERONAVE = (SELECT AERONAVE_ID FROM AERONAVE WHERE AERONAVE_FABRICANTE_AVION = (SELECT FABRICANTE_ID FROM FABRICANTE WHERE Aeronave_Fabricante = FABRICANTE_NOMBRE) AND AERONAVE_ESPACIO_ENCOMIENDAS = Aeronave_KG_Disponibles AND AERONAVE_MATRICULA_AVION = Aeronave_Matricula AND AERONAVE_MODELO_AVION = Aeronave_Modelo AND AERONAVE_SERVICIO = (SELECT SERVICIO_ID FROM SERVICIO WHERE SERVICIO_NOMBRE = Tipo_Servicio)) AND VIAJE_FECHA_LLEGADA = FechaLLegada AND VIAJE_FECHA_LLEGADA_ESTIMADA = Fecha_LLegada_Estimada AND VIAJE_FECHA_SALIDA = FechaSalida AND VIAJE_RUTA = (SELECT RUTA_ID FROM RUTA WHERE RUTA_CODIGO = Ruta_Codigo AND (SELECT CIUDAD_ID FROM CIUDAD WHERE CIUDAD_NOMBRE = Ruta_Ciudad_Destino) = RUTA_DESTINO AND (SELECT CIUDAD_ID FROM CIUDAD WHERE CIUDAD_NOMBRE = Ruta_Ciudad_Origen) = RUTA_ORIGEN AND RUTA_PRECIO_BASE_POR_KILO = Ruta_Precio_BaseKG AND RUTA_PRECIO_BASE_POR_PASAJE = Ruta_Precio_BasePasaje)) FROM GD2C2015.gd_esquema.Maestra
WHERE Butaca_Nro <> 0
END
GO


EXECUTE INIC_FABRICANTE
EXECUTE INIC_CIUDAD
EXECUTE INIC_CLIENTE
EXECUTE INIC_SERVICIO
EXECUTE INIC_AERONAVE
EXECUTE INIC_RUTA
EXECUTE INIC_VIAJE
EXECUTE INIC_PASAJE
EXECUTE INIC_ENCOMIENDA
EXECUTE INIC_BUTACA


--select HASHBYTES('SHA2_256', 'w23e')

/*DROP TABLE MILLA
DROP TABLE CANJE
DROP TABLE DEVOLUCION
DROP TABLE PRODUCTO
DROP TABLE COMPRA
DROP TABLE TARJETACREDITO
DROP TABLE BUTACA
DROP TABLE PASAJE
DROP TABLE ENCOMIENDA
DROP TABLE CLIENTE
DROP TABLE VIAJE 
DROP TABLE RUTA
DROP TABLE AERONAVE
DROP TABLE FABRICANTE
DROP TABLE SERVICIO
DROP TABLE CIUDAD
DROP TABLE LOGUEO
DROP TABLE USUARIO
ALTER TABLE FUNCIONXROL DROP CONSTRAINT FK_FXR_1
ALTER TABLE FUNCIONXROL DROP CONSTRAINT FK_FXR_2
DROP TABLE ROL
DROP TABLE FUNCIONALIDAD
DROP TABLE FUNCIONXROL
DROP PROCEDURE INIC_CLIENTE
DROP PROCEDURE INIC_CIUDAD
DROP PROCEDURE INIC_FABRICANTE
DROP PROCEDURE INIC_SERVICIO
DROP PROCEDURE INIC_AERONAVE
DROP PROCEDURE INIC_RUTA
DROP PROCEDURE INIC_VIAJE
DROP PROCEDURE INIC_BUTACA
DROP PROCEDURE INIC_PASAJE
DROP PROCEDURE INIC_ENCOMIENDA*/



