IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Demo_Obtener]') AND type in (N'P', N'PC'))
   DROP PROCEDURE Demo_Obtener
GO

/****************************************************************************
* Nombre:		Demo_Obtener												*
* Autor:		Erick Vargas												*
* Fecha:		01/03/2022													*
* Descripción:	Procedimiento Almacenado de ejemplo para obtener datos      *
****************************************************************************/
GO
CREATE PROCEDURE Demo_Obtener
(  
 @CampoID int,  
 @Campo2 varchar(100),  
 @Campo4 bit
)  
AS
Begin 
	Select 1 as CampoID
End