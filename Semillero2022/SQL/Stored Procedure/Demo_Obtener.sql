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
AS
Begin 
	
	select IDSTORE CampoID,
	STORENAME Campo2,
	1 Campo4
	from Catalogo_Tienda

End