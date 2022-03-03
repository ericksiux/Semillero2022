/********************************************************************
* Nombre:		DistTienda											*
* Autor:		Edna Lecea											*
* Fecha:		02/03/2022											*
* Descripción:	Tabla que guarda las tiendas asociadas a un fletero *
*********************************************************************/

CREATE TABLE [DistTienda] (
  [idListaDT] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [tienda] int,
  [fletero] int NOT NULL
)
GO

/********************************************************************
* Nombre:		Estado											                                  *
* Autor:		Edna Lecea																		  *
* Fecha:		02/03/2022																		  *
* Descripción:	Tabla que guarda el estado de los fleteros. Valores por default: Activo, Inactivo *
*********************************************************************/

CREATE TABLE [Estado] (
  [idEstado] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [estado] varchar(30) NOT NULL
)
GO

/********************************************************************
* Nombre:		Motivo											                   *
* Autor:		Edna Lecea														   *
* Fecha:		02/03/2022														   *
* Descripción:	Tabla que guarda el motivo del estado seleccionado para el fletero *
*********************************************************************/

CREATE TABLE [Motivo] (
  [idMotivo] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [motivo] int NOT NULL,
  [descripcion] varchar(300) NOT NULL,
  [fecha] date NOT NULL
)
GO

/********************************************************************
* Nombre:		Fletero									 *
* Autor:		Edna Lecea								 *
* Fecha:		02/03/2022						     	 *
* Descripción:	Tabla que guarda informacion del fletero *
*********************************************************************/

CREATE TABLE [Fletero] (
  [idFletero] int UNIQUE PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [nombreFletero] varchar(100) NOT NULL,
  [RFC] varchar(12) NOT NULL,
  [dirFCalle] varchar(100) NOT NULL,
  [dirFNum] int NOT NULL,
  [dirFCol] varchar(100) NOT NULL,
  [dirFMunicipio] int NOT NULL,
  [dirFCP] int NOT NULL,
  [dirBCalle] varchar(100) NOT NULL,
  [dirBNum] int NOT NULL,
  [dirBCol] varchar(100) NOT NULL,
  [dirBMunicipio] int NOT NULL,
  [dirBCP] int NOT NULL,
  [nombreRepresentante] varchar(50) NOT NULL,
  [nombreCont] varchar(50) NOT NULL,
  [telCelCont] varchar(12) NOT NULL,
  [telOficinaCont] varchar(20) NOT NULL,
  [telNextelCont] varchar(15) NOT NULL,
  [correoPrincipal] varchar(50) NOT NULL,
  [fechaAlta] date NOT NULL,
  [indicadorCertif] int NOT NULL,
  [estado] int NOT NULL,
  [motivo] int
)
GO
/********************************************************************
* Nombre:		TituloMotivo									                                         *
* Autor:		Edna Lecea																				 *
* Fecha:		02/03/2022						     													 *
* Descripción:	Tabla que tiene los motivos posibles para la habilitación o inhabiltiaicon de fleteros.  *
				Se relaciona junto con la tabla de Motivos                                               *
********************************************************/
CREATE TABLE [TituloMotivo] (
  [idTituloM] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [motivo] varchar(100)
)
GO

ALTER TABLE [DistTienda] ADD FOREIGN KEY ([fletero]) REFERENCES [Fletero] ([idFletero])
GO

ALTER TABLE [Motivo] ADD FOREIGN KEY ([motivo]) REFERENCES [TituloMotivo] ([idTituloM])
GO

ALTER TABLE [Fletero] ADD FOREIGN KEY ([estado]) REFERENCES [Estado] ([idEstado])
GO

ALTER TABLE [Fletero] ADD FOREIGN KEY ([motivo]) REFERENCES [Motivo] ([idMotivo])
GO


