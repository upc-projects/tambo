
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Enzo Lizama
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_LISTAR_PRODUCTOS 
AS
BEGIN
	SELECT * FROM Producto
END
GO


CREATE PROCEDURE SP_REGISTRAR_PRODUCTO(
	@NOMBRE as varchar(50),
	@DESCRIPCION as varchar(100),
	@PRECIO as float
)
AS
BEGIN
	INSERT INTO Producto VALUES (@NOMBRE,@DESCRIPCION,@PRECIO)
END
GO

CREATE PROCEDURE SP_ELIMINAR_PRODUCTO(
	@ID as int
)
AS
BEGIN
	DELETE FROM Producto WHERE id = @ID
END
GO